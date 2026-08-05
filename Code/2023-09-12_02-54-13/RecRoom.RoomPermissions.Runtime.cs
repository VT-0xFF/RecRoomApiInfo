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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B8520", Offset = "0x67B7920", VA = "0x1867B8520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JIKNBPGHKOG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OCHJGMHMPOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HLEKIKFLIPD CBCHPMGEOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<FFHFHGMOGPP> NAGHJMCNLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DDJDJOCHLDH PPCKEOADBKP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<FFHFHGMOGPP> LPBODDKKDKK(bool NPNAHNMDMCD = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FFHFHGMOGPP MGFFEHHBMAH(NJNAENGEJEB BMPOPKHJCLB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JHDCMGOMGIL(NJNAENGEJEB BMPOPKHJCLB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<FFHFHGMOGPP> CPOIHDCGLME(NJNAENGEJEB BMPOPKHJCLB, bool EHBLKEBGCNH = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ECMPMKFJKDE(NJNAENGEJEB FJPCMICJGML, JMDCIJEEDJD HOPFEEPJHFL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FFHFHGMOGPP NPIMBENLCIA(JMDCIJEEDJD HOPFEEPJHFL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KALOLBFAEFK<T>(JMDCIJEEDJD HOPFEEPJHFL, LHDHGHFDONF LMLENLAJCOD, bool CLODBNNBOGC, T LBKPMPMCPAG) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KGPCHODGIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IOKOHCFACJI(DNADIKEEDJF LGMMPALIFIG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BICPBPCBPEJ(ref DNADIKEEDJF LGMMPALIFIG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OHLCBGAFAON
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JOKIIFBANNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BDNPOKFGBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JNIDFIHGENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ACCIDIIDNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ICDAMLADJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OOFGGDOKKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IHCHLABCDHN
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<JMDCIJEEDJD> JEHELMAIIMO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67B0CA0", Offset = "0x67B00A0", VA = "0x1867B0CA0")]
	public static bool ADDKILOMBFL(this NJNAENGEJEB DOHCAABJNHK, JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67B0D90", Offset = "0x67B0190", VA = "0x1867B0D90")]
	public static bool JAEHJCGNJDG(this NJNAENGEJEB DOHCAABJNHK, JMDCIJEEDJD HOPFEEPJHFL, MFKMLKAPGOD FKBFPEMHLED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class FOHNJEHIMEG : HIICAOAAJCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OCHJGMHMPOE LOFDAPBEFDM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	[RecRoom.NoEngine.Common.Preserve]
	public FOHNJEHIMEG([JLJFOFICIEA(null)] OCHJGMHMPOE GGBBANGBNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67B0610", Offset = "0x67AFA10", VA = "0x1867B0610")]
	private static NMBNKIGLCLI? EHGHLOHIDBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67B0B90", Offset = "0x67AFF90", VA = "0x1867B0B90", Slot = "4")]
	public bool KDBKACPPBBF(NJNAENGEJEB NAALDKKNFBP, NJNAENGEJEB NDPHKPOAPOP, IEnumerable<NJNAENGEJEB> OBAJIIJMCNH, out JIKNBPGHKOG BOCDOEABGIH, out LBIOAGGNLLG OJCPFIGAGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67B0660", Offset = "0x67AFA60", VA = "0x1867B0660")]
	internal bool GGNPINCPNHD(NJNAENGEJEB NAALDKKNFBP, NJNAENGEJEB NDPHKPOAPOP, IEnumerable<NJNAENGEJEB> OBAJIIJMCNH, MFKMLKAPGOD FKBFPEMHLED, NMBNKIGLCLI? MCHAONFLJLK, out JIKNBPGHKOG BOCDOEABGIH, out LBIOAGGNLLG OJCPFIGAGMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LJHFGAJKPJD<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string NHIDDIHEBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GLGBFOPLMHI<TPermission> CEPFLEBAEOH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void GLGBFOPLMHI<TPermission>(TPermission LMLENLAJCOD);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void DDJDJOCHLDH(NJNAENGEJEB BMPOPKHJCLB);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class LCPEBGPFFDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string MODHFGFBPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type CLHNDLAHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly HNBFFHGOPJC JHDDJLMHBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly LHDHGHFDONF INILDGEBAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public LIMNIDPBLND PDMKAAACPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public DAFGOHCNOMF GOMDKOLJFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public OCPAFLHHMOD ALHMNNIFPKA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67B69B0", Offset = "0x67B5DB0", VA = "0x1867B69B0")]
	public LCPEBGPFFDB(Type LMMMGKKAHMC, string JGDEGEIMMMJ, LHDHGHFDONF LMLENLAJCOD, LIMNIDPBLND CGNILBJKKME, DAFGOHCNOMF EHAKLLMPFMF, OCPAFLHHMOD BMDLNNNCMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67B68C0", Offset = "0x67B5CC0", VA = "0x1867B68C0")]
	public object GDACNPOHLJN(object? ICELKIGIKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2374E20", Offset = "0x2374220", VA = "0x182374E20")]
	public void GJGIDDIOOMK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67B6900", Offset = "0x67B5D00", VA = "0x1867B6900")]
	public void GJGIDDIOOMK(Type EECEHOKDJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KFEGGCMPLJO<T> : LCPEBGPFFDB where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string MPABBJHLMFJ(T AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T PDGDILDBDMN(string? EAPCHAIMDHF, T CHKFHALGEFG);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FEEPEBBILDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MPABBJHLMFJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PDGDILDBDMN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public FEEPEBBILDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x375D1E0", Offset = "0x375C5E0", VA = "0x18375D1E0")]
		internal string GOINEOOFNLD(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x375D200", Offset = "0x375C600", VA = "0x18375D200")]
		internal object OBEEBMHBCEE(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B80E80", Offset = "0x3B80280", VA = "0x183B80E80")]
	public KFEGGCMPLJO(LHDHGHFDONF LMLENLAJCOD, string JGDEGEIMMMJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F920", Offset = "0x71ED20")] KFEGGCMPLJO<T>.MPABBJHLMFJ CGNILBJKKME, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F980", Offset = "0x71ED80")] KFEGGCMPLJO<T>.PDGDILDBDMN EHAKLLMPFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B800E0", Offset = "0x3B7F4E0", VA = "0x183B800E0")]
	private static object? EFFJDOFDOEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F9E0", Offset = "0x71EDE0")] KFEGGCMPLJO<T?>.PDGDILDBDMN? EHAKLLMPFMF, string? EAPCHAIMDHF, object? CHKFHALGEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F860", Offset = "0x3B7EC60", VA = "0x183B7F860")]
	private static string CJMDONJKOCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71FA40", Offset = "0x71EE40")] KFEGGCMPLJO<T>.MPABBJHLMFJ FHLPDPFGCDA, object? AGLCIEKHLEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NBFCFIBJJCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NJNAENGEJEB JOGPMLOLHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GIFLFLGKBIH MNNKKGKMEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MFKMLKAPGOD INHJKCNMIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<DKBNENKPANK> LIFDMPOGMLO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action FHHOLLHONGN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMDCIJEEDJD OIIJKPJDOLP(NJNAENGEJEB BMPOPKHJCLB);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DKBNENKPANK> NKFNKDGNLMB(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ILCFIHMPMNL(long KFHMHOFPIPN, long BCJGCHKGEMF, IReadOnlyList<LBIOPGOHIMP> INADGCPGIBF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<NJNAENGEJEB> ACOELAKHFAI();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NPAPHGMCEOM
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67B84C0", Offset = "0x67B78C0", VA = "0x1867B84C0")]
	public static JMDCIJEEDJD DOKLNBONNBH(this NBFCFIBJJCC AEKMLBJGGMJ)
	{
		return default(JMDCIJEEDJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class DCAJKCDAJKN : FFHFHGMOGPP, EKKHNCAGNDP, OHLCBGAFAON, LJHFGAJKPJD<LHDHGHFDONF>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly COPHHEJBHED FFFCKDHFBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly NKPLPMFKPON MPENJMADECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? DNECHNNDHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? CEAOIMPDFAM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool IBGJAMHOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67AE9E0", Offset = "0x67ADDE0", VA = "0x1867AE9E0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool CCJEONBJCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67ADBE0", Offset = "0x67ACFE0", VA = "0x1867ADBE0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool MANGMPBFFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67AEAD0", Offset = "0x67ADED0", VA = "0x1867AEAD0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool DADDAKMFNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67AE800", Offset = "0x67ADC00", VA = "0x1867AE800", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool MKHCLMAKEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67AE990", Offset = "0x67ADD90", VA = "0x1867AE990", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool EFHHHEIJPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67AE2F0", Offset = "0x67AD6F0", VA = "0x1867AE2F0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JMDCIJEEDJD GCPPLGFNFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JMDCIJEEDJD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x901900", Offset = "0x900D00", VA = "0x180901900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NHIDDIHEBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67AEB20", Offset = "0x67ADF20", VA = "0x1867AEB20", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67AE390", Offset = "0x67AD790", VA = "0x1867AE390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string MBFKMEGFFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x67AEB20", Offset = "0x67ADF20", VA = "0x1867AEB20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LGHMMCMLIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6EE0", Offset = "0x9E62E0", VA = "0x1809E6EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6E20", Offset = "0x9E6220", VA = "0x1809E6E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BHGECOAGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67AE2A0", Offset = "0x67AD6A0", VA = "0x1867AE2A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JIKNBPGHKOG CFLOEAOFIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67AEBC0", Offset = "0x67ADFC0", VA = "0x1867AEBC0", Slot = "20")]
		get
		{
			return default(JIKNBPGHKOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KEFHNKBHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67AECB0", Offset = "0x67AE0B0", VA = "0x1867AECB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool HIJDHBKCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67AEC10", Offset = "0x67AE010", VA = "0x1867AEC10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool JPHCIILLLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67ADD20", Offset = "0x67AD120", VA = "0x1867ADD20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IPJAEHLEKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67AEC60", Offset = "0x67AE060", VA = "0x1867AEC60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool LNBFBBIKODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67AEEA0", Offset = "0x67AE2A0", VA = "0x1867AEEA0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EPFFPMIHFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67AEB70", Offset = "0x67ADF70", VA = "0x1867AEB70", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NHBIJFPGECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67ADCD0", Offset = "0x67AD0D0", VA = "0x1867ADCD0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FCEHDOKHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x67ADC30", Offset = "0x67AD030", VA = "0x1867ADC30", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> FODICIGIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67ADD70", Offset = "0x67AD170", VA = "0x1867ADD70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool PFJGMAPDHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67AE9E0", Offset = "0x67ADDE0", VA = "0x1867AE9E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool FEOEDJIFNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67AE990", Offset = "0x67ADD90", VA = "0x1867AE990", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool LNJDIMCIBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67ADBE0", Offset = "0x67ACFE0", VA = "0x1867ADBE0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CNHKLDGAOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67AE340", Offset = "0x67AD740", VA = "0x1867AE340", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool BCNJKPKPLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67ADC80", Offset = "0x67AD080", VA = "0x1867ADC80", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ACJNAJGAJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67AEAD0", Offset = "0x67ADED0", VA = "0x1867AEAD0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KFDLMKCECLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67AFB20", Offset = "0x67AEF20", VA = "0x1867AFB20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KPGKLHILAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67AE800", Offset = "0x67ADC00", VA = "0x1867AE800", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CCGGKEIODMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67AE2F0", Offset = "0x67AD6F0", VA = "0x1867AE2F0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GLGBFOPLMHI<LHDHGHFDONF> CEPFLEBAEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67AE8F0", Offset = "0x67ADCF0", VA = "0x1867AE8F0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67AED20", Offset = "0x67AE120", VA = "0x1867AED20", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28BB290", Offset = "0x28BA690", VA = "0x1828BB290", Slot = "6")]
	public (bool, T?) EOBNGJMGKAG<T>(LHDHGHFDONF LMLENLAJCOD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28BB250", Offset = "0x28BA650", VA = "0x1828BB250")]
	public DCAJKCDAJKN BCGJEAHOJOI<T>(LHDHGHFDONF LMLENLAJCOD, bool CLODBNNBOGC, T AGLCIEKHLEE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67AFD10", Offset = "0x67AF110", VA = "0x1867AFD10")]
	public DCAJKCDAJKN(JMDCIJEEDJD HOPFEEPJHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67AFCF0", Offset = "0x67AF0F0", VA = "0x1867AFCF0")]
	public DCAJKCDAJKN(JMDCIJEEDJD HOPFEEPJHFL, [Optional] string? DNECHNNDHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67AFE90", Offset = "0x67AF290", VA = "0x1867AFE90")]
	public DCAJKCDAJKN(DCAJKCDAJKN KGAIGJONNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67AFD30", Offset = "0x67AF130", VA = "0x1867AFD30")]
	internal DCAJKCDAJKN(JMDCIJEEDJD AJLIJBDACHE, [Optional] string? DNECHNNDHBF, [Optional] DCAJKCDAJKN? KGAIGJONNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67AE780", Offset = "0x67ADB80", VA = "0x1867AE780")]
	public static HNBFFHGOPJC FKHKDELPCJJ(LHDHGHFDONF LMLENLAJCOD)
	{
		return default(HNBFFHGOPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67AED00", Offset = "0x67AE100", VA = "0x1867AED00")]
	public void MADNLFAEOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67AE010", Offset = "0x67AD410", VA = "0x1867AE010")]
	internal DCAJKCDAJKN CJANLLJCDGE(DCAJKCDAJKN MODGGHKDPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67AE3E0", Offset = "0x67AD7E0", VA = "0x1867AE3E0")]
	internal IReadOnlyCollection<LHDHGHFDONF> EMCLIHJFPMF(DCAJKCDAJKN KGAIGJONNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67AEDC0", Offset = "0x67AE1C0", VA = "0x1867AEDC0")]
	public bool NFHIPAFKEGG(LHDHGHFDONF LMLENLAJCOD, bool CLODBNNBOGC, string DPJBHKGBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67AFB70", Offset = "0x67AEF70", VA = "0x1867AFB70")]
	public (bool, string) PMMCFILEFDO(LHDHGHFDONF LMLENLAJCOD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67AE850", Offset = "0x67ADC50", VA = "0x1867AE850")]
	internal void HHGIABGCIOF(LHDHGHFDONF LMLENLAJCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67ADDD0", Offset = "0x67AD1D0", VA = "0x1867ADDD0")]
	public MLNOPBOIINB CBDGBNHFKOC(Func<JMDCIJEEDJD, Guid> CGGPJECLJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67AEEF0", Offset = "0x67AE2F0", VA = "0x1867AEEF0")]
	public void OOPNBNKMJLO(MLNOPBOIINB GCGPIADPBEP, Func<Guid, JMDCIJEEDJD> AFDPFECFILJ, [Optional] JMDCIJEEDJD? JOAOEBJPBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67AEA30", Offset = "0x67ADE30", VA = "0x1867AEA30")]
	[CompilerGenerated]
	private void JHPFNHLODIN(LHDHGHFDONF OIGIHNODCHL, IFGCIKCNPPH NHELGHLOGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HIICAOAAJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDBKACPPBBF(NJNAENGEJEB NAALDKKNFBP, NJNAENGEJEB NDPHKPOAPOP, IEnumerable<NJNAENGEJEB> OBAJIIJMCNH, out JIKNBPGHKOG BOCDOEABGIH, out LBIOAGGNLLG OJCPFIGAGMI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LBIOAGGNLLG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EKKHNCAGNDP
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool BHGECOAGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KEFHNKBHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HIJDHBKCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JPHCIILLLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool IPJAEHLEKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool LNBFBBIKODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EPFFPMIHFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool NHBIJFPGECA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool FCEHDOKHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool CNHKLDGAOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool BCNJKPKPLME
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KFDLMKCECLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> FODICIGIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JIKNBPGHKOG CFLOEAOFIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FFHFHGMOGPP : EKKHNCAGNDP, OHLCBGAFAON, LJHFGAJKPJD<LHDHGHFDONF>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string MBFKMEGFFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JMDCIJEEDJD GCPPLGFNFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EOBNGJMGKAG<T>(LHDHGHFDONF LMLENLAJCOD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class FGACDNFHLDN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? LDIKGINHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	protected FGACDNFHLDN(object? BNLDOMAIEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OILNDJNBOIN(object? AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class POONGMIIIEG<T> : FGACDNFHLDN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T LNBIOGAPBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> FJOBDJAACBA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2452F90", Offset = "0x2452390", VA = "0x182452F90", Slot = "4")]
	public override bool OILNDJNBOIN(object? AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2452AB0", Offset = "0x2451EB0", VA = "0x182452AB0")]
	public bool BDNJDMEHGNI(T OCPCBAAODOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2453110", Offset = "0x2452510", VA = "0x182453110")]
	public POONGMIIIEG(T CHKFHALGEFG, IEqualityComparer<T> FJOBDJAACBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class DDMKDDJMLFN
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum ODNCAHPNJGI
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
	public static readonly Guid JIGHJHFGLFA;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid LOKAEGKEEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid MBBLAJHMAKM;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid GFEGAIJHCMK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid NMGJFIDPJLE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly IMGGOGIEJFC<JMDCIJEEDJD, Guid> EAJBGNLAIKD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<JMDCIJEEDJD> COBKEENDAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67B0110", Offset = "0x67AF510", VA = "0x1867B0110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67B01C0", Offset = "0x67AF5C0", VA = "0x1867B01C0")]
	public static JMDCIJEEDJD MJAJNFCDCEE(Guid DDJMKPCJBFO)
	{
		return default(JMDCIJEEDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67B0250", Offset = "0x67AF650", VA = "0x1867B0250")]
	public static Guid PCCGLFLPABN(JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67AFFC0", Offset = "0x67AF3C0", VA = "0x1867AFFC0")]
	public static bool HGKAKMHBFKE(JMDCIJEEDJD HOPFEEPJHFL, out Guid DDJMKPCJBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67AFF20", Offset = "0x67AF320", VA = "0x1867AFF20")]
	public static bool FKANKDAANAF(Guid DDJMKPCJBFO, out JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67B0190", Offset = "0x67AF590", VA = "0x1867B0190")]
	public static JMDCIJEEDJD MELOLJHAJNA(JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(JMDCIJEEDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67B0060", Offset = "0x67AF460", VA = "0x1867B0060")]
	public static ODNCAHPNJGI JPPOFNNOEKH(JMDCIJEEDJD PLDJBHAOKJG)
	{
		return default(ODNCAHPNJGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67B0300", Offset = "0x67AF700", VA = "0x1867B0300")]
	internal static JMDCIJEEDJD PIFOGCLPJEC(ODNCAHPNJGI ABDPNAMKFLE)
	{
		return default(JMDCIJEEDJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string LIMNIDPBLND(object? AGLCIEKHLEE);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object DAFGOHCNOMF(string? EAPCHAIMDHF, [Optional] object CHKFHALGEFG);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate FGACDNFHLDN OCPAFLHHMOD();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class COPHHEJBHED
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class NGDNJFPDBFO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static NGDNJFPDBFO FNGGPKJOCFE;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x67B6D60", Offset = "0x67B6160", VA = "0x1867B6D60", Slot = "4")]
		public bool Equals(List<string> EOMIKPKMCAG, List<string> PPNFDCNFKFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x67B6EC0", Offset = "0x67B62C0", VA = "0x1867B6EC0", Slot = "5")]
		public int GetHashCode(List<string> HFAGBIOODHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NGDNJFPDBFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class MAAIMFMDDID : GANKGCHEEBH<JIKNBPGHKOG>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67B6A40", Offset = "0x67B5E40", VA = "0x1867B6A40", Slot = "9")]
		public override string CJMDONJKOCN(JIKNBPGHKOG MNNPDPNIFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67B6B30", Offset = "0x67B5F30", VA = "0x1867B6B30", Slot = "10")]
		protected override bool GDNLDEIBIOI(string MNNPDPNIFNM, out JIKNBPGHKOG AGLCIEKHLEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x67B6D20", Offset = "0x67B6120", VA = "0x1867B6D20")]
		public MAAIMFMDDID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly NABHKBGCPOO BKPMNGFHBFG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly MAAIMFMDDID IKGNJABGFHO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<LCPEBGPFFDB> CDIECBBBKOE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<LHDHGHFDONF> KDOPFHOGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<LHDHGHFDONF, LCPEBGPFFDB> IIMFMHDIMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67AD470", Offset = "0x67AC870", VA = "0x1867AD470")]
	public COPHHEJBHED([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71FB20", Offset = "0x71EF20")] IList<LCPEBGPFFDB> PLONMOKMOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67AC890", Offset = "0x67ABC90", VA = "0x1867AC890")]
	public LCPEBGPFFDB GBFMPAMJLJE(LHDHGHFDONF LMLENLAJCOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JOIHMGKFNPA : KGPCHODGIJL, OCHJGMHMPOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AHBKNDPLAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DCAJKCDAJKN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AHBKNDPLAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67ABF40", Offset = "0x67AB340", VA = "0x1867ABF40")]
		internal bool KJLEPGJPJBN(DCAJKCDAJKN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JELHGJGCCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JMDCIJEEDJD roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JELHGJGCCEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67B0FE0", Offset = "0x67B03E0", VA = "0x1867B0FE0")]
		internal bool NOANONAHHNK(JMDCIJEEDJD r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PDKLHOKJLHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DNADIKEEDJF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JOIHMGKFNPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private DKBNENKPANK <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private DKBNENKPANK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7200B0", Offset = "0x71F4B0")]
		private TaskAwaiter<DKBNENKPANK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PDKLHOKJLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67B85B0", Offset = "0x67B79B0", VA = "0x1867B85B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ACAOINFCDEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ACAOINFCDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67ABE40", Offset = "0x67AB240", VA = "0x1867ABE40")]
		internal void DEIGHHAAMEK(MLNOPBOIINB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67ABD10", Offset = "0x67AB110", VA = "0x1867ABD10")]
		internal void BPLMFALDMAO(MLNOPBOIINB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct FAKIOOGJCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public DNADIKEEDJF roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NJKKJACOFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x720110", Offset = "0x71F510")]
		public Func<MLNOPBOIINB, IFGCIKCNPPH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NJKKJACOFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67B7D80", Offset = "0x67B7180", VA = "0x1867B7D80")]
		internal void KIDJPMDDPHL(MLNOPBOIINB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67B7CA0", Offset = "0x67B70A0", VA = "0x1867B7CA0")]
		internal void HLCBOFJLFMH(MLNOPBOIINB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67B7D10", Offset = "0x67B7110", VA = "0x1867B7D10")]
		internal void IJNJPPHKHAK(MLNOPBOIINB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OLEEAOLEFEG<T> where T : notnull
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
			public OLEEAOLEFEG<T> <>4__this;

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
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7201D0", Offset = "0x71F5D0")]
			private TaskAwaiter<DKBNENKPANK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x19DF780", Offset = "0x19DEB80", VA = "0x1819DF780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JOIHMGKFNPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public LHDHGHFDONF rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public JMDCIJEEDJD accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public HNBFFHGOPJC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public OLEEAOLEFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x15D7880", Offset = "0x15D6C80", VA = "0x1815D7880")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OLEEAOLEFEG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BFPBEOKGCDN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KAHKFEBCKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<LBIOPGOHIMP> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NIOPPBIMFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NBFCFIBJJCC rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DNADIKEEDJF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x720230", Offset = "0x71F630")]
		public IReadOnlyDictionary<JMDCIJEEDJD, DCAJKCDAJKN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FHPGBOJECFJ debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x720290", Offset = "0x71F690")]
		private List<LBIOPGOHIMP> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<MLNOPBOIINB> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MLNOPBOIINB <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private JMDCIJEEDJD <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private DCAJKCDAJKN <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<LHDHGHFDONF> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<LHDHGHFDONF> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LHDHGHFDONF <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private HNBFFHGOPJC <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7202F0", Offset = "0x71F6F0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NIOPPBIMFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67B7060", Offset = "0x67B6460", VA = "0x1867B7060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NBFCFIBJJCC AEKMLBJGGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CDDNPAKJHGL CAIPICCAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FHPGBOJECFJ OJMEENEKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, DCAJKCDAJKN> DEDKBIFPLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<JMDCIJEEDJD, DCAJKCDAJKN> CKMGALOBPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<JMDCIJEEDJD, DCAJKCDAJKN> LNNKPCPMMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<DCAJKCDAJKN> DLFCDDOCELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool AFPNAAPDLDM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly LHDHGHFDONF[] JENCFMOFECH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HLEKIKFLIPD CBCHPMGEOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<FFHFHGMOGPP> NAGHJMCNLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67B3B70", Offset = "0x67B2F70", VA = "0x1867B3B70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DDJDJOCHLDH PPCKEOADBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67B3A10", Offset = "0x67B2E10", VA = "0x1867B3A10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67B37C0", Offset = "0x67B2BC0", VA = "0x1867B37C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67B62B0", Offset = "0x67B56B0", VA = "0x1867B62B0")]
	[PGKDFPMEDOJ(OCCBJMOEDKI.Room, CDFBKAGHDGH.None)]
	private static void PIJPEIOOLKO(IFJJAPHPIAE LDNJCMFLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67B6630", Offset = "0x67B5A30", VA = "0x1867B6630")]
	[UnityEngine.Scripting.Preserve]
	internal JOIHMGKFNPA([JLJFOFICIEA(null)] NBFCFIBJJCC HLJKIMIOANA, [JLJFOFICIEA(null)] CDDNPAKJHGL HGFIKHLFHKM, [JLJFOFICIEA(null)] FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67B2460", Offset = "0x67B1860", VA = "0x1867B2460", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67B0FF0", Offset = "0x67B03F0", VA = "0x1867B0FF0")]
	private void AAKMCOAOEAF(IEnumerable<DCAJKCDAJKN> KCBFDKBNCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67B4310", Offset = "0x67B3710", VA = "0x1867B4310", Slot = "12")]
	public bool JHDCMGOMGIL(NJNAENGEJEB BMPOPKHJCLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67B3610", Offset = "0x67B2A10", VA = "0x1867B3610")]
	private void FHHOLLHONGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67B5DB0", Offset = "0x67B51B0", VA = "0x1867B5DB0")]
	private void OMIMABMHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67B46F0", Offset = "0x67B3AF0", VA = "0x1867B46F0", Slot = "10")]
	public IReadOnlyList<FFHFHGMOGPP> LPBODDKKDKK(bool NPNAHNMDMCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67B48D0", Offset = "0x67B3CD0", VA = "0x1867B48D0", Slot = "11")]
	public FFHFHGMOGPP MGFFEHHBMAH(NJNAENGEJEB BMPOPKHJCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67B3AB0", Offset = "0x67B2EB0", VA = "0x1867B3AB0")]
	private JMDCIJEEDJD HHAPDDGMANH(NJNAENGEJEB BMPOPKHJCLB)
	{
		return default(JMDCIJEEDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67B2570", Offset = "0x67B1970", VA = "0x1867B2570", Slot = "14")]
	public bool ECMPMKFJKDE(NJNAENGEJEB FJPCMICJGML, JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67B59E0", Offset = "0x67B4DE0", VA = "0x1867B59E0", Slot = "15")]
	public FFHFHGMOGPP NPIMBENLCIA(JMDCIJEEDJD HOPFEEPJHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67B1D80", Offset = "0x67B1180", VA = "0x1867B1D80")]
	private static bool CDDNDIJLLIN(IFDBAAICFDH EDLNLDHPPGE, JMDCIJEEDJD HOPFEEPJHFL, out MLNOPBOIINB? KCLDPOFOOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67B3BC0", Offset = "0x67B2FC0", VA = "0x1867B3BC0")]
	private static void INMCGLPPBLK(IFDBAAICFDH EDLNLDHPPGE, Action<MLNOPBOIINB> HAPJDKPDOGA, JMDCIJEEDJD CKBICDJNPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67B3CC0", Offset = "0x67B30C0", VA = "0x1867B3CC0")]
	private static void INMCGLPPBLK(IFDBAAICFDH EDLNLDHPPGE, Action<MLNOPBOIINB> HAPJDKPDOGA, Predicate<JMDCIJEEDJD> LAKOFLIPLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67B5F30", Offset = "0x67B5330", VA = "0x1867B5F30")]
	private void PDLEPEPENBE(NJNAENGEJEB BMPOPKHJCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67B3EC0", Offset = "0x67B32C0", VA = "0x1867B3EC0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDKLHOKJLHE))]
	public Task IOKOHCFACJI([CanBeNull] DNADIKEEDJF LGMMPALIFIG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void BICPBPCBPEJ(ref DNADIKEEDJF LGMMPALIFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67B5120", Offset = "0x67B4520", VA = "0x1867B5120")]
	private void NFKIGIAALFO(IFDBAAICFDH ENJBOMOHAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67B5A90", Offset = "0x67B4E90", VA = "0x1867B5A90")]
	internal static string OHMPJFNGIKD(NBFCFIBJJCC AEKMLBJGGMJ, DNADIKEEDJF LGMMPALIFIG, IReadOnlyDictionary<JMDCIJEEDJD, DCAJKCDAJKN> CKMGALOBPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67B2700", Offset = "0x67B1B00", VA = "0x1867B2700")]
	private static void EHNGLEFGDHD(DNADIKEEDJF LGMMPALIFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67B43E0", Offset = "0x67B37E0", VA = "0x1867B43E0")]
	private static void LGDGIEELAHM(IFDBAAICFDH HGGHJAIDDCJ, IReadOnlyDictionary<JMDCIJEEDJD, DCAJKCDAJKN> CKMGALOBPPD, StringBuilder OKGJMJJAAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67B4770", Offset = "0x67B3B70", VA = "0x1867B4770")]
	private static bool MBDPEKBECCO(string KJLHFGKFJCP, out Guid CFPPHIOKPMG, out JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67B53C0", Offset = "0x67B47C0", VA = "0x1867B53C0")]
	private static void NLBGJJHLMBA(DNADIKEEDJF LGMMPALIFIG, StringBuilder OKGJMJJAAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x164E720", Offset = "0x164DB20", VA = "0x18164E720", Slot = "16")]
	public bool KALOLBFAEFK<T>(JMDCIJEEDJD HOPFEEPJHFL, LHDHGHFDONF LMLENLAJCOD, bool CLODBNNBOGC, T LBKPMPMCPAG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67B3860", Offset = "0x67B2C60", VA = "0x1867B3860")]
	private void GDELGJHECFK(JMDCIJEEDJD HOPFEEPJHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67B53A0", Offset = "0x67B47A0", VA = "0x1867B53A0")]
	private bool NKNNNKDMFOD(NJNAENGEJEB BMPOPKHJCLB, JMDCIJEEDJD HOPFEEPJHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67B5F90", Offset = "0x67B5390", VA = "0x1867B5F90")]
	internal DCAJKCDAJKN PIHJHGDCEFF(NJNAENGEJEB BMPOPKHJCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67B2450", Offset = "0x67B1850", VA = "0x1867B2450", Slot = "13")]
	public IReadOnlyList<FFHFHGMOGPP> CPOIHDCGLME(NJNAENGEJEB BMPOPKHJCLB, bool EHBLKEBGCNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67B1B60", Offset = "0x67B0F60", VA = "0x1867B1B60")]
	internal IReadOnlyList<DCAJKCDAJKN> CCILMDAGBCA(NJNAENGEJEB BMPOPKHJCLB, bool EHBLKEBGCNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67B49E0", Offset = "0x67B3DE0", VA = "0x1867B49E0")]
	private void NCPOFHIEMPO(DKBNENKPANK APMMANPHAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x67B4030", Offset = "0x67B3430", VA = "0x1867B4030")]
	private static bool IOLOBLLBCAN(DCAJKCDAJKN PJLBNDJADEE, IReadOnlyDictionary<JMDCIJEEDJD, DCAJKCDAJKN> CKMGALOBPPD, out IReadOnlyList<LHDHGHFDONF> NIKEPGEOHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67B3620", Offset = "0x67B2A20", VA = "0x1867B3620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NIOPPBIMFAE))]
	private static Task FMBKEGNNPJC(NBFCFIBJJCC AEKMLBJGGMJ, DNADIKEEDJF LGMMPALIFIG, IReadOnlyDictionary<JMDCIJEEDJD, DCAJKCDAJKN> CKMGALOBPPD, FHPGBOJECFJ OJMEENEKFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x67B2170", Offset = "0x67B1570", VA = "0x1867B2170")]
	[CompilerGenerated]
	internal static void CMNAKBIFDCB(Func<MLNOPBOIINB, IFGCIKCNPPH> OJMKKKMDDDI, ref FAKIOOGJCAK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x67B17E0", Offset = "0x67B0BE0", VA = "0x1867B17E0")]
	[CompilerGenerated]
	internal static bool BOBGJDNIBNB(JMDCIJEEDJD HOPFEEPJHFL, LHDHGHFDONF LMLENLAJCOD, out LBIOPGOHIMP IHAHLOEIKEF, ref KAHKFEBCKIC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum LHDHGHFDONF
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
internal class NKPLPMFKPON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<LHDHGHFDONF, bool> HDBEFHBAFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<LHDHGHFDONF, FGACDNFHLDN> AHPGPIGLGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly COPHHEJBHED CMLEOKHOAND;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67B8270", Offset = "0x67B7670", VA = "0x1867B8270")]
	public NKPLPMFKPON(COPHHEJBHED CMLEOKHOAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67B7EE0", Offset = "0x67B72E0", VA = "0x1867B7EE0")]
	public bool DKPICBMBNCE(LHDHGHFDONF LMLENLAJCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x24053E0", Offset = "0x24047E0", VA = "0x1824053E0")]
	public bool EAAGOLONJDI<T>(LHDHGHFDONF LMLENLAJCOD, bool CLODBNNBOGC, T AGLCIEKHLEE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2404F70", Offset = "0x2404370", VA = "0x182404F70")]
	public (bool, T?) CNMFHDBNLMC<T>(LHDHGHFDONF LMLENLAJCOD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67B7F50", Offset = "0x67B7350", VA = "0x1867B7F50")]
	public bool EAAGOLONJDI(LHDHGHFDONF LMLENLAJCOD, bool CLODBNNBOGC, object AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67B7DF0", Offset = "0x67B71F0", VA = "0x1867B7DF0")]
	public (bool, object) CNMFHDBNLMC(LHDHGHFDONF LMLENLAJCOD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2405510", Offset = "0x2404910", VA = "0x182405510")]
	private void GJGIDDIOOMK<T>(LHDHGHFDONF LMLENLAJCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67B81B0", Offset = "0x67B75B0", VA = "0x1867B81B0")]
	private FGACDNFHLDN NNCIDCOFDFH(LHDHGHFDONF LMLENLAJCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x67B8030", Offset = "0x67B7430", VA = "0x1867B8030")]
	public void MADNLFAEOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HLEKIKFLIPD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FFHFHGMOGPP BBMAJINIGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class CDDNPAKJHGL : HLEKIKFLIPD
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static CDDNPAKJHGL MHCGBAJMGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly DCAJKCDAJKN KJDDFLCLANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<DCAJKCDAJKN> PKKGEOOIIHI;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FFHFHGMOGPP BBMAJINIGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67AC790", Offset = "0x67ABB90", VA = "0x1867AC790")]
	public CDDNPAKJHGL(DCAJKCDAJKN HNICOLIPIDC, IReadOnlyList<DCAJKCDAJKN> OGECBHADPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67ABF70", Offset = "0x67AB370", VA = "0x1867ABF70")]
	private static CDDNPAKJHGL LOMEMJDBJIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum GFEOBKCFPEH
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

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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x673E330", Offset = "0x673CF30", VA = "0x18673E330")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PBBOAMOLEMI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FNKDBHMCEFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BEKIJGFEHCA KADAPPKEJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<BGCFEEJMHBP> GFNAOHOLJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PHCFCNKNBPG ECAEEGOLBGB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BGCFEEJMHBP> FHIMDHLFCHI(bool AEKDEAOHPIG = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BGCFEEJMHBP KKMJPLBNGPG(IGGCDPKBFGF ILJFHAFPNBB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NJEMCBPEOEA(IGGCDPKBFGF ILJFHAFPNBB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BGCFEEJMHBP> HBICEJJCNKA(IGGCDPKBFGF ILJFHAFPNBB, bool NKMJEDFBLCN = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FFHMGFLPFDI(IGGCDPKBFGF IPILBAOKPEC, AOGHFIIJPGK GNFABOPCIDF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BGCFEEJMHBP IBBGFPBNCOL(AOGHFIIJPGK GNFABOPCIDF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FKIDMJOGIIC<T>(AOGHFIIJPGK GNFABOPCIDF, NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T AIMHDAMIMIL) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KBJNEOPPCEM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JBJHIANOAAE(BNIDNMGAHLD CMMCIHFHBLL, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBPJJJPMBLI(ref BNIDNMGAHLD CMMCIHFHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CENKNMAKBNH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DMCFIFBHEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FMFODNHECDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JPFFCCJGPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OIOCPKOFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OCEMAOOINCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PJEBJICNDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OIFAIHCBCNK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<AOGHFIIJPGK> MMIAAODFIAH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x673E440", Offset = "0x673D040", VA = "0x18673E440")]
	public static bool MHBLMPLGJHE(this IGGCDPKBFGF ACJGGEOLANN, AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x673E3C0", Offset = "0x673CFC0", VA = "0x18673E3C0")]
	public static bool BFHOJJDBLKF(this IGGCDPKBFGF ACJGGEOLANN, AOGHFIIJPGK GNFABOPCIDF, IEMLKNOFDEG EAIBLBKOGKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class FMOEPCPDHFB : KOPHFKPFFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FNKDBHMCEFA OAHLOOEFBCF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	[RecRoom.NoEngine.Common.Preserve]
	public FMOEPCPDHFB([ACEKLAKDMBL(null)] FNKDBHMCEFA EKPFFIBLPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x673B880", Offset = "0x673A480", VA = "0x18673B880")]
	private static EFPJGGLIGDF? OILIKDJKINO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x673B770", Offset = "0x673A370", VA = "0x18673B770", Slot = "4")]
	public bool JHJJDPEIODM(IGGCDPKBFGF HEEGMEGOJPA, IGGCDPKBFGF FAOJKDIDNHP, IEnumerable<IGGCDPKBFGF> MGKDFBEDJFG, out PBBOAMOLEMI LJPPNILOPCH, out IIBLPFMJEHP KFGJNJKCIHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x673B250", Offset = "0x6739E50", VA = "0x18673B250")]
	internal bool HKBCFHEBBBG(IGGCDPKBFGF HEEGMEGOJPA, IGGCDPKBFGF FAOJKDIDNHP, IEnumerable<IGGCDPKBFGF> MGKDFBEDJFG, IEMLKNOFDEG EAIBLBKOGKO, EFPJGGLIGDF? LECNKLKLJGI, out PBBOAMOLEMI LJPPNILOPCH, out IIBLPFMJEHP KFGJNJKCIHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BPPNLIDPNJK<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string GFCIDPAIIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FPKEPIDPABI<TPermission> GDECIPMCMFI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void FPKEPIDPABI<TPermission>(TPermission PJIMOOACGAM);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void PHCFCNKNBPG(IGGCDPKBFGF ILJFHAFPNBB);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class JAGILKFEEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string HFLCPAHPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type NDEGMBJCPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly FGIBCPMDCOI IBGIIIKMKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly NIAGAPJMDPC IDKDLOIOBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public EGEIJCAEDON FADKOBECKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public DOKJPPIMNLL IGFMEDPMPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public KPAPLGCFCBE PPOKGAHADOO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x673C9F0", Offset = "0x673B5F0", VA = "0x18673C9F0")]
	public JAGILKFEEBH(Type OEFLEKKAOMG, string EEJDHAPFKNI, NIAGAPJMDPC PJIMOOACGAM, EGEIJCAEDON DGEDDAGKIFE, DOKJPPIMNLL POAPGDPIKCI, KPAPLGCFCBE EKMPOAHKFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x673C900", Offset = "0x673B500", VA = "0x18673C900")]
	public object JPLKIMOCKDE(object? MDHJAFNLPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2384FD0", Offset = "0x2383BD0", VA = "0x182384FD0")]
	public void PPPJBCMJDOG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x673C940", Offset = "0x673B540", VA = "0x18673C940")]
	public void PPPJBCMJDOG(Type KHKLDKECJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class NPOJFHNFJGG<T> : JAGILKFEEBH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string CCBMCLKFPOL(T ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T PLDBMHEHOJN(string? MKCPDKJKKDJ, T IGBKLJLDCLC);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HNIMKJLLCEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CCBMCLKFPOL serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PLDBMHEHOJN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public HNIMKJLLCEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AAA0", Offset = "0x2E796A0", VA = "0x182E7AAA0")]
		internal string CMOMFNDMDFO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AB90", Offset = "0x2E79790", VA = "0x182E7AB90")]
		internal object HPOPKBBAEKB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38C03A0", Offset = "0x38BEFA0", VA = "0x1838C03A0")]
	public NPOJFHNFJGG(NIAGAPJMDPC PJIMOOACGAM, string EEJDHAPFKNI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3980", Offset = "0x7A2D80")] NPOJFHNFJGG<T>.CCBMCLKFPOL DGEDDAGKIFE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A39E0", Offset = "0x7A2DE0")] NPOJFHNFJGG<T>.PLDBMHEHOJN POAPGDPIKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38C0020", Offset = "0x38BEC20", VA = "0x1838C0020")]
	private static object? NLJPEOGMFGO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3A40", Offset = "0x7A2E40")] NPOJFHNFJGG<T?>.PLDBMHEHOJN? POAPGDPIKCI, string? MKCPDKJKKDJ, object? IGBKLJLDCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x38BF040", Offset = "0x38BDC40", VA = "0x1838BF040")]
	private static string ECCPKOGLKLF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3AA0", Offset = "0x7A2EA0")] NPOJFHNFJGG<T>.CCBMCLKFPOL EKNBBBDEPMK, object? ECNGHFJBIJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KANDIPBEDFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MHKEFJDKLJN GCAKDALBEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEMLKNOFDEG COPPBMJCHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<LKAMNMFEGMK> KAPDOKDCBMN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action OHPKHMEIECE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AOGHFIIJPGK GFFGFKNDLPH(IGGCDPKBFGF ILJFHAFPNBB);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LKAMNMFEGMK> ICALDKGPFIP(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BLFNJADNDPG(long HAMIEGOKEJC, long KIBMHJEFMKG, IReadOnlyList<BLLFLLIKKCK> JCNAGMFANOO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IGGCDPKBFGF> CLKGOIACEPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LEIKJHADGOH
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x673CA80", Offset = "0x673B680", VA = "0x18673CA80")]
	public static AOGHFIIJPGK BBPMEKFLOPG(this KANDIPBEDFG FPFDDKABGFP)
	{
		return default(AOGHFIIJPGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class CBGKIFBHBCE : BGCFEEJMHBP, KJFLPHCHMJM, CENKNMAKBNH, BPPNLIDPNJK<NIAGAPJMDPC>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly OLOGMHPPHML IOBKHMNMHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly AMHBLGOPGIO NDFFHBNOLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? HLNKIOKJPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? IFEIPGMOBKH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool HBGFKICHPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x673A430", Offset = "0x6739030", VA = "0x18673A430", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool HGOAALFNNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67387D0", Offset = "0x67373D0", VA = "0x1867387D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool ECJMIINGPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67389A0", Offset = "0x67375A0", VA = "0x1867389A0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool MOPGODCKGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67394C0", Offset = "0x67380C0", VA = "0x1867394C0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool CJMEHNJHBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6738F20", Offset = "0x6737B20", VA = "0x186738F20", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool FNPJLLEIJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x673A7B0", Offset = "0x67393B0", VA = "0x18673A7B0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AOGHFIIJPGK PNBIJAFAAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83D1F0", Offset = "0x83BDF0", VA = "0x18083D1F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AOGHFIIJPGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85E9A0", Offset = "0x85D5A0", VA = "0x18085E9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GFCIDPAIIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x673A390", Offset = "0x6738F90", VA = "0x18673A390", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6739470", Offset = "0x6738070", VA = "0x186739470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string OBCKLEIGGED
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x673A390", Offset = "0x6738F90", VA = "0x18673A390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PJHADCJOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x938FE0", Offset = "0x937BE0", VA = "0x180938FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB0BCE0", Offset = "0xB0A8E0", VA = "0x180B0BCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JALKIACADKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6739340", Offset = "0x6737F40", VA = "0x186739340", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PBBOAMOLEMI ANBLJGKMAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x673A800", Offset = "0x6739400", VA = "0x18673A800", Slot = "20")]
		get
		{
			return default(PBBOAMOLEMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AGKJPCBFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67390B0", Offset = "0x6737CB0", VA = "0x1867390B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IGIBMONOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x673A1C0", Offset = "0x6738DC0", VA = "0x18673A1C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NDFNDMKOMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6738900", Offset = "0x6737500", VA = "0x186738900", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool GAGHMECONAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6738FC0", Offset = "0x6737BC0", VA = "0x186738FC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool CBIIKDFMNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6739510", Offset = "0x6738110", VA = "0x186739510", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OEBJBCBHEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x673A170", Offset = "0x6738D70", VA = "0x18673A170", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CEOPLCGIAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6738F70", Offset = "0x6737B70", VA = "0x186738F70", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GDJHGKOMBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6738950", Offset = "0x6737550", VA = "0x186738950", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> LGADBLJGDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6739390", Offset = "0x6737F90", VA = "0x186739390", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool GKNFMEEOCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x673A430", Offset = "0x6739030", VA = "0x18673A430", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MONGMACOFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6738F20", Offset = "0x6737B20", VA = "0x186738F20", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool LEEJAJPEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67387D0", Offset = "0x67373D0", VA = "0x1867387D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EBKKEEAHFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x673A320", Offset = "0x6738F20", VA = "0x18673A320", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OONPHJELIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x673A3E0", Offset = "0x6738FE0", VA = "0x18673A3E0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IJEGKCFCILN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67389A0", Offset = "0x67375A0", VA = "0x1867389A0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IBMFDNGNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6738ED0", Offset = "0x6737AD0", VA = "0x186738ED0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OOEPGABGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67394C0", Offset = "0x67380C0", VA = "0x1867394C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OPLHANBPOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x673A7B0", Offset = "0x67393B0", VA = "0x18673A7B0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FPKEPIDPABI<NIAGAPJMDPC> GDECIPMCMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6738D90", Offset = "0x6737990", VA = "0x186738D90", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6739010", Offset = "0x6737C10", VA = "0x186739010", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C68140", Offset = "0x2C66D40", VA = "0x182C68140", Slot = "6")]
	public (bool, T?) DFDHKNDMKOK<T>(NIAGAPJMDPC PJIMOOACGAM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C682E0", Offset = "0x2C66EE0", VA = "0x182C682E0")]
	public CBGKIFBHBCE MCMAEOKBMBI<T>(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T ECNGHFJBIJL) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x673AA40", Offset = "0x6739640", VA = "0x18673AA40")]
	public CBGKIFBHBCE(AOGHFIIJPGK GNFABOPCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x673AA20", Offset = "0x6739620", VA = "0x18673AA20")]
	public CBGKIFBHBCE(AOGHFIIJPGK GNFABOPCIDF, [Optional] string? HLNKIOKJPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x673AA60", Offset = "0x6739660", VA = "0x18673AA60")]
	public CBGKIFBHBCE(CBGKIFBHBCE MIBKBMOGBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x673A8C0", Offset = "0x67394C0", VA = "0x18673A8C0")]
	internal CBGKIFBHBCE(AOGHFIIJPGK EPNOOHHPEMI, [Optional] string? HLNKIOKJPHH, [Optional] CBGKIFBHBCE? MIBKBMOGBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67393F0", Offset = "0x6737FF0", VA = "0x1867393F0")]
	public static FGIBCPMDCOI FPHGJDAHJIB(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default(FGIBCPMDCOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x673A370", Offset = "0x6738F70", VA = "0x18673A370")]
	public void MDBAOJEGDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x673A480", Offset = "0x6739080", VA = "0x18673A480")]
	internal CBGKIFBHBCE NGIJMOCGGED(CBGKIFBHBCE JHPGJJKOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67389F0", Offset = "0x67375F0", VA = "0x1867389F0")]
	internal IReadOnlyCollection<NIAGAPJMDPC> BOIMNMIKDGA(CBGKIFBHBCE MIBKBMOGBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6738820", Offset = "0x6737420", VA = "0x186738820")]
	public bool BAKNIFFELBH(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, string MAENKEFGOMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x673A210", Offset = "0x6738E10", VA = "0x18673A210")]
	public (bool, string) LJMKDJGBKLF(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6738E30", Offset = "0x6737A30", VA = "0x186738E30")]
	internal void CDJLNDKJAMA(NIAGAPJMDPC PJIMOOACGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6739100", Offset = "0x6737D00", VA = "0x186739100")]
	public LMIOPBAHGDP FEADFCNPGMN(Func<AOGHFIIJPGK, Guid> IJDFGHJNPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6739560", Offset = "0x6738160", VA = "0x186739560")]
	public void JPEAAKBBHGK(LMIOPBAHGDP IMLKIKFBFNG, Func<Guid, AOGHFIIJPGK> EJAOKBHGJDP, [Optional] AOGHFIIJPGK? ADGAMFGFLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x673A710", Offset = "0x6739310", VA = "0x18673A710")]
	[CompilerGenerated]
	private void NJAMEDBJMCP(NIAGAPJMDPC HAMLPIBAOMG, HFLPPJEOCHJ LKCGDINNDBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KOPHFKPFFCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JHJJDPEIODM(IGGCDPKBFGF HEEGMEGOJPA, IGGCDPKBFGF FAOJKDIDNHP, IEnumerable<IGGCDPKBFGF> MGKDFBEDJFG, out PBBOAMOLEMI LJPPNILOPCH, out IIBLPFMJEHP KFGJNJKCIHO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum IIBLPFMJEHP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KJFLPHCHMJM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JALKIACADKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool AGKJPCBFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool IGIBMONOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool NDFNDMKOMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool GAGHMECONAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool CBIIKDFMNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool OEBJBCBHEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CEOPLCGIAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool GDJHGKOMBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EBKKEEAHFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OONPHJELIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool IBMFDNGNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> LGADBLJGDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PBBOAMOLEMI ANBLJGKMAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BGCFEEJMHBP : KJFLPHCHMJM, CENKNMAKBNH, BPPNLIDPNJK<NIAGAPJMDPC>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string OBCKLEIGGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AOGHFIIJPGK PNBIJAFAAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) DFDHKNDMKOK<T>(NIAGAPJMDPC PJIMOOACGAM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class HOLHGNHJKPB
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? AJINEBFJBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	protected HOLHGNHJKPB(object? NMFBPLCAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MNBHKBFFHBK(object? ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GCCNDNNKAHB<T> : HOLHGNHJKPB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T CEKOCNNANED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> MJKDLIIFPMD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83D1F0", Offset = "0x83BDF0", VA = "0x18083D1F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25FC2A0", Offset = "0x25FAEA0", VA = "0x1825FC2A0", Slot = "4")]
	public override bool MNBHKBFFHBK(object? ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x25FBEC0", Offset = "0x25FAAC0", VA = "0x1825FBEC0")]
	public bool JMHHKDMNBHJ(T FEEEOGHEKFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x25FC390", Offset = "0x25FAF90", VA = "0x1825FC390")]
	public GCCNDNNKAHB(T IGBKLJLDCLC, IEqualityComparer<T> MJKDLIIFPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class GGMOJEMNFGO
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum NJGKBEBLDCB
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
	public static readonly Guid JMMIFABMOBK;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid JHPOMOBKMAL;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid GJEFHAKOJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid IOHFBDDGEFI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid BLHPMEBODIB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly CIHALCFMIHM<AOGHFIIJPGK, Guid> HCJLAPKLKFK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<AOGHFIIJPGK> LKMGDECJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x673BA60", Offset = "0x673A660", VA = "0x18673BA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x673BB10", Offset = "0x673A710", VA = "0x18673BB10")]
	public static AOGHFIIJPGK NALAMBCMNNO(Guid PCFHAIHNKAK)
	{
		return default(AOGHFIIJPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x673B910", Offset = "0x673A510", VA = "0x18673B910")]
	public static Guid FAPFHJNKJFL(AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x673B9C0", Offset = "0x673A5C0", VA = "0x18673B9C0")]
	public static bool FELGNIEIHOL(AOGHFIIJPGK GNFABOPCIDF, out Guid PCFHAIHNKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x673BC50", Offset = "0x673A850", VA = "0x18673BC50")]
	public static bool OPMJCMACBIJ(Guid PCFHAIHNKAK, out AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x673BAE0", Offset = "0x673A6E0", VA = "0x18673BAE0")]
	public static AOGHFIIJPGK MLBKMDGKGFE(AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(AOGHFIIJPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x673BBA0", Offset = "0x673A7A0", VA = "0x18673BBA0")]
	public static NJGKBEBLDCB NGKDOBPBMCO(AOGHFIIJPGK NGCOOCKBPCK)
	{
		return default(NJGKBEBLDCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x673B8D0", Offset = "0x673A4D0", VA = "0x18673B8D0")]
	internal static AOGHFIIJPGK CLJCAKCKMBI(NJGKBEBLDCB FHGAOMHCNGA)
	{
		return default(AOGHFIIJPGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string EGEIJCAEDON(object? ECNGHFJBIJL);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object DOKJPPIMNLL(string? MKCPDKJKKDJ, [Optional] object IGBKLJLDCLC);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate HOLHGNHJKPB KPAPLGCFCBE();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OLOGMHPPHML
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class LFDEOIHPHIP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static LFDEOIHPHIP EABDDJEADPB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x673CAE0", Offset = "0x673B6E0", VA = "0x18673CAE0", Slot = "4")]
		public bool Equals(List<string> OLGJDFCIILF, List<string> IKFJLOPMKHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x673CC40", Offset = "0x673B840", VA = "0x18673CC40", Slot = "5")]
		public int GetHashCode(List<string> HHNPCHNMLMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LFDEOIHPHIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class ELEPGBNIJEF : CIPELGAELCD<PBBOAMOLEMI>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x673AF20", Offset = "0x6739B20", VA = "0x18673AF20", Slot = "9")]
		public override string ECCPKOGLKLF(PBBOAMOLEMI BEEPMJAJNKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x673B020", Offset = "0x6739C20", VA = "0x18673B020", Slot = "10")]
		protected override bool EGOMAFHAGPI(string BEEPMJAJNKA, out PBBOAMOLEMI ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x673B210", Offset = "0x6739E10", VA = "0x18673B210")]
		public ELEPGBNIJEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly HNOJDMIPBKF LBOIOFBABLK;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly ELEPGBNIJEF BOIACIBAAOI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<JAGILKFEEBH> PGENCCHMGJE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<NIAGAPJMDPC> AMLGBEFMNCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<NIAGAPJMDPC, JAGILKFEEBH> DNDLDNMNPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x673F2F0", Offset = "0x673DEF0", VA = "0x18673F2F0")]
	public OLOGMHPPHML([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3B80", Offset = "0x7A2F80")] IList<JAGILKFEEBH> HJAGGCDKPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x673E700", Offset = "0x673D300", VA = "0x18673E700")]
	public JAGILKFEEBH GJGOLIHELNJ(NIAGAPJMDPC PJIMOOACGAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PPIJIAIIDNJ : KBJNEOPPCEM, FNKDBHMCEFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MDEHOAKJKKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CBGKIFBHBCE newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MDEHOAKJKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x673D930", Offset = "0x673C530", VA = "0x18673D930")]
		internal bool NGGPIPLLBOC(CBGKIFBHBCE rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DPCNGLPGJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AOGHFIIJPGK roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DPCNGLPGJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x673AF10", Offset = "0x6739B10", VA = "0x18673AF10")]
		internal bool GJKJGICAMKC(AOGHFIIJPGK r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NOBAKBGEECO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public BNIDNMGAHLD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PPIJIAIIDNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LKAMNMFEGMK <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LKAMNMFEGMK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4110", Offset = "0x7A3510")]
		private TaskAwaiter<LKAMNMFEGMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NOBAKBGEECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x673DB90", Offset = "0x673C790", VA = "0x18673DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MGNJEGDOAID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MGNJEGDOAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x673DA90", Offset = "0x673C690", VA = "0x18673DA90")]
		internal void FLCHPGFAGCB(LMIOPBAHGDP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x673D960", Offset = "0x673C560", VA = "0x18673D960")]
		internal void BNGEGBEHEEE(LMIOPBAHGDP r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct POPIKCHDLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BNIDNMGAHLD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ADLOJGKPIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4170", Offset = "0x7A3570")]
		public Func<LMIOPBAHGDP, HFLPPJEOCHJ> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ADLOJGKPIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6738060", Offset = "0x6736C60", VA = "0x186738060")]
		internal void KLDLLKGFLHM(LMIOPBAHGDP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6737FF0", Offset = "0x6736BF0", VA = "0x186737FF0")]
		internal void JLHOBLGJFOO(LMIOPBAHGDP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6737F80", Offset = "0x6736B80", VA = "0x186737F80")]
		internal void BDMGMEFLJMP(LMIOPBAHGDP r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GDPFIPJDBBF<T> where T : notnull
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
			public GDPFIPJDBBF<T> <>4__this;

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
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4230", Offset = "0x7A3630")]
			private TaskAwaiter<LKAMNMFEGMK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x22CAAF0", Offset = "0x22C96F0", VA = "0x1822CAAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public PPIJIAIIDNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NIAGAPJMDPC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AOGHFIIJPGK accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FGIBCPMDCOI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public GDPFIPJDBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x25FE050", Offset = "0x25FCC50", VA = "0x1825FE050")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GDPFIPJDBBF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OKEENLJCPON()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct IKMBOKLBIDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<BLLFLLIKKCK> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LILOGHFBLIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KANDIPBEDFG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BNIDNMGAHLD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4290", Offset = "0x7A3690")]
		public IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public GBEHEHLFCID debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A42F0", Offset = "0x7A36F0")]
		private List<BLLFLLIKKCK> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<LMIOPBAHGDP> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LMIOPBAHGDP <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private AOGHFIIJPGK <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CBGKIFBHBCE <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<NIAGAPJMDPC> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<NIAGAPJMDPC> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private NIAGAPJMDPC <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FGIBCPMDCOI <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4350", Offset = "0x7A3750")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LILOGHFBLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x673CDE0", Offset = "0x673B9E0", VA = "0x18673CDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KANDIPBEDFG FPFDDKABGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GGOIBBNBHLL EIMAJLIGEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GBEHEHLFCID GBLFMIICBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, CBGKIFBHBCE> GEBIOPKKPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<AOGHFIIJPGK, CBGKIFBHBCE> NDBNBCPPKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<CBGKIFBHBCE> NKHDOEEPAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool ILHPHJNKOPE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly NIAGAPJMDPC[] JIEMNPKKJOD;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BEKIJGFEHCA KADAPPKEJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<BGCFEEJMHBP> GFNAOHOLJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x673FDE0", Offset = "0x673E9E0", VA = "0x18673FDE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PHCFCNKNBPG ECAEEGOLBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x673FA50", Offset = "0x673E650", VA = "0x18673FA50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6741800", Offset = "0x6740400", VA = "0x186741800", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6743370", Offset = "0x6741F70", VA = "0x186743370")]
	[BBAPFPLPODF(BLGLNFDFDJO.Room, EDNJEIFHIMJ.None)]
	private static void LECKBAIJAMJ(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6744D10", Offset = "0x6743910", VA = "0x186744D10")]
	[UnityEngine.Scripting.Preserve]
	internal PPIJIAIIDNJ([ACEKLAKDMBL(null)] KANDIPBEDFG MKNBJLFHDDC, [ACEKLAKDMBL(null)] GGOIBBNBHLL DCJGABGJNLN, [ACEKLAKDMBL(null)] GBEHEHLFCID GBLFMIICBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67409B0", Offset = "0x673F5B0", VA = "0x1867409B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67426E0", Offset = "0x67412E0", VA = "0x1867426E0")]
	private void JAMOMBMNDKD(IEnumerable<CBGKIFBHBCE> MJDKNGLGPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67435B0", Offset = "0x67421B0", VA = "0x1867435B0", Slot = "12")]
	public bool NJEMCBPEOEA(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6744590", Offset = "0x6743190", VA = "0x186744590")]
	private void OHPKHMEIECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6740E60", Offset = "0x673FA60", VA = "0x186740E60")]
	private void FBNEJODGHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6741320", Offset = "0x673FF20", VA = "0x186741320", Slot = "10")]
	public IReadOnlyList<BGCFEEJMHBP> FHIMDHLFCHI(bool AEKDEAOHPIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6743260", Offset = "0x6741E60", VA = "0x186743260", Slot = "11")]
	public BGCFEEJMHBP KKMJPLBNGPG(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x673FFF0", Offset = "0x673EBF0", VA = "0x18673FFF0")]
	private AOGHFIIJPGK DAKMDDFLPIJ(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return default(AOGHFIIJPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6741190", Offset = "0x673FD90", VA = "0x186741190", Slot = "14")]
	public bool FFHMGFLPFDI(IGGCDPKBFGF IPILBAOKPEC, AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6742630", Offset = "0x6741230", VA = "0x186742630", Slot = "15")]
	public BGCFEEJMHBP IBBGFPBNCOL(AOGHFIIJPGK GNFABOPCIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x673F660", Offset = "0x673E260", VA = "0x18673F660")]
	private static bool AAPDFCDLEDH(LHNDJGDOOFF HLBGBCNNLKH, AOGHFIIJPGK GNFABOPCIDF, out LMIOPBAHGDP? MJAPIOPONHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6741500", Offset = "0x6740100", VA = "0x186741500")]
	private static void GMOKACOHNJP(LHNDJGDOOFF HLBGBCNNLKH, Action<LMIOPBAHGDP> LHCANCKPNCE, AOGHFIIJPGK DMDNIEAOBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6741600", Offset = "0x6740200", VA = "0x186741600")]
	private static void GMOKACOHNJP(LHNDJGDOOFF HLBGBCNNLKH, Action<LMIOPBAHGDP> LHCANCKPNCE, Predicate<AOGHFIIJPGK> FOJODEADCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6743550", Offset = "0x6742150", VA = "0x186743550")]
	private void MPPCHPNCJAE(IGGCDPKBFGF ILJFHAFPNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6742ED0", Offset = "0x6741AD0", VA = "0x186742ED0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOBAKBGEECO))]
	public Task JBJHIANOAAE([CanBeNull] BNIDNMGAHLD CMMCIHFHBLL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
	public void GBPJJJPMBLI(ref BNIDNMGAHLD CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67445A0", Offset = "0x67431A0", VA = "0x1867445A0")]
	private void PBPELMLDHAK(LHNDJGDOOFF OEBKHLNOAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6744820", Offset = "0x6743420", VA = "0x186744820")]
	internal static string PKELEDLKCHD(KANDIPBEDFG FPFDDKABGFP, BNIDNMGAHLD CMMCIHFHBLL, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6743680", Offset = "0x6742280", VA = "0x186743680")]
	private static void OFPEKLHKLOM(BNIDNMGAHLD CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6742310", Offset = "0x6740F10", VA = "0x186742310")]
	private static void IAPOPJKJOJP(LHNDJGDOOFF LMKKJPMBMCO, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP, StringBuilder FGBNFMFFMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67413A0", Offset = "0x673FFA0", VA = "0x1867413A0")]
	private static bool GFHNMBIKKEK(string JCIMKDAIEGA, out Guid JPOPADHIGCL, out AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6740390", Offset = "0x673EF90", VA = "0x186740390")]
	private static void DJADIFFCDGB(BNIDNMGAHLD CMMCIHFHBLL, StringBuilder FGBNFMFFMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C0A0", Offset = "0x1F7ACA0", VA = "0x181F7C0A0", Slot = "16")]
	public bool FKIDMJOGIIC<T>(AOGHFIIJPGK GNFABOPCIDF, NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T AIMHDAMIMIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x673FE30", Offset = "0x673EA30", VA = "0x18673FE30")]
	private void CFPNLGPCJHM(AOGHFIIJPGK GNFABOPCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6743530", Offset = "0x6742130", VA = "0x186743530")]
	private bool LMBMFGGOBLG(IGGCDPKBFGF ILJFHAFPNBB, AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6741FF0", Offset = "0x6740BF0", VA = "0x186741FF0")]
	internal CBGKIFBHBCE HKJDEAECGEG(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6741FE0", Offset = "0x6740BE0", VA = "0x186741FE0", Slot = "13")]
	public IReadOnlyList<BGCFEEJMHBP> HBICEJJCNKA(IGGCDPKBFGF ILJFHAFPNBB, bool NKMJEDFBLCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6743040", Offset = "0x6741C40", VA = "0x186743040")]
	internal IReadOnlyList<CBGKIFBHBCE> KAJODIJDPKH(IGGCDPKBFGF ILJFHAFPNBB, bool NKMJEDFBLCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67418A0", Offset = "0x67404A0", VA = "0x1867418A0")]
	private void GOADBGOHGAA(LKAMNMFEGMK IKBCNIMJBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x673FAF0", Offset = "0x673E6F0", VA = "0x18673FAF0")]
	private static bool AMOMPBALMPG(CBGKIFBHBCE OKJHEMOKIFA, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP, out IReadOnlyList<NIAGAPJMDPC> IFEGNCKBCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6740FF0", Offset = "0x673FBF0", VA = "0x186740FF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LILOGHFBLIN))]
	private static Task FCCMMIHACLG(KANDIPBEDFG FPFDDKABGFP, BNIDNMGAHLD CMMCIHFHBLL, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP, GBEHEHLFCID GBLFMIICBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x67400B0", Offset = "0x673ECB0", VA = "0x1867400B0")]
	[CompilerGenerated]
	internal static void DCOMPNAGOOG(Func<LMIOPBAHGDP, HFLPPJEOCHJ> JGJAHDBKHAA, ref POPIKCHDLNO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6740AC0", Offset = "0x673F6C0", VA = "0x186740AC0")]
	[CompilerGenerated]
	internal static bool FAJBCLPJLEO(AOGHFIIJPGK GNFABOPCIDF, NIAGAPJMDPC PJIMOOACGAM, out BLLFLLIKKCK EBNBECBGFGH, ref IKMBOKLBIDD P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum NIAGAPJMDPC
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
internal class AMHBLGOPGIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<NIAGAPJMDPC, bool> DFBHGLHICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<NIAGAPJMDPC, HOLHGNHJKPB> PHMHHDHKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly OLOGMHPPHML DHHICICDCFH;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6738570", Offset = "0x6737170", VA = "0x186738570")]
	public AMHBLGOPGIO(OLOGMHPPHML DHHICICDCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67380D0", Offset = "0x6736CD0", VA = "0x1867380D0")]
	public bool CCPHIANLIDO(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x274F760", Offset = "0x274E360", VA = "0x18274F760")]
	public bool MNJIBHAPIKE<T>(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T ECNGHFJBIJL) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x274F2D0", Offset = "0x274DED0", VA = "0x18274F2D0")]
	public (bool, T?) FFLBPPLHANE<T>(NIAGAPJMDPC PJIMOOACGAM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67383D0", Offset = "0x6736FD0", VA = "0x1867383D0")]
	public bool MNJIBHAPIKE(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, object ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6738140", Offset = "0x6736D40", VA = "0x186738140")]
	public (bool, object) FFLBPPLHANE(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x274F890", Offset = "0x274E490", VA = "0x18274F890")]
	private void PPPJBCMJDOG<T>(NIAGAPJMDPC PJIMOOACGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67384B0", Offset = "0x67370B0", VA = "0x1867384B0")]
	private HOLHGNHJKPB PPLLJGKCPIM(NIAGAPJMDPC PJIMOOACGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6738230", Offset = "0x6736E30", VA = "0x186738230")]
	public void MDBAOJEGDLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BEKIJGFEHCA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	BGCFEEJMHBP HDKNLAINMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class GGOIBBNBHLL : BEKIJGFEHCA
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static GGOIBBNBHLL LMOCLMDBCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly CBGKIFBHBCE CGIOMMNHHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<CBGKIFBHBCE> CCCLILOOPJG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BGCFEEJMHBP HDKNLAINMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x673C800", Offset = "0x673B400", VA = "0x18673C800")]
	public GGOIBBNBHLL(CBGKIFBHBCE DPNNMGHNMEN, IReadOnlyList<CBGKIFBHBCE> DBAKGDBFEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x673BFC0", Offset = "0x673ABC0", VA = "0x18673BFC0")]
	private static GGOIBBNBHLL CBKGHECMAAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum CLPOMMDIJAE
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

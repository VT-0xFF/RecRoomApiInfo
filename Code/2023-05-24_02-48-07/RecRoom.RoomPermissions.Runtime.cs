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
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
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
		[Cpp2IlInjected.Address(RVA = "0x67C3080", Offset = "0x67C1C80", VA = "0x1867C3080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
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
		[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
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
	[Cpp2IlInjected.Address(RVA = "0x67C3190", Offset = "0x67C1D90", VA = "0x1867C3190")]
	public static bool MHBLMPLGJHE(this IGGCDPKBFGF ACJGGEOLANN, AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67C3110", Offset = "0x67C1D10", VA = "0x1867C3110")]
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
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FMOEPCPDHFB([ACEKLAKDMBL(null)] FNKDBHMCEFA EKPFFIBLPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67C05D0", Offset = "0x67BF1D0", VA = "0x1867C05D0")]
	private static EFPJGGLIGDF? OILIKDJKINO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67C04C0", Offset = "0x67BF0C0", VA = "0x1867C04C0", Slot = "4")]
	public bool JHJJDPEIODM(IGGCDPKBFGF HEEGMEGOJPA, IGGCDPKBFGF FAOJKDIDNHP, IEnumerable<IGGCDPKBFGF> MGKDFBEDJFG, out PBBOAMOLEMI LJPPNILOPCH, out IIBLPFMJEHP KFGJNJKCIHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67BFFA0", Offset = "0x67BEBA0", VA = "0x1867BFFA0")]
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
	event global::FPKEPIDPABI<TPermission> GDECIPMCMFI;
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
	[Cpp2IlInjected.Address(RVA = "0x67C1740", Offset = "0x67C0340", VA = "0x1867C1740")]
	public JAGILKFEEBH(Type OEFLEKKAOMG, string EEJDHAPFKNI, NIAGAPJMDPC PJIMOOACGAM, EGEIJCAEDON DGEDDAGKIFE, DOKJPPIMNLL POAPGDPIKCI, KPAPLGCFCBE EKMPOAHKFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67C1650", Offset = "0x67C0250", VA = "0x1867C1650")]
	public object JPLKIMOCKDE(object? MDHJAFNLPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25C9310", Offset = "0x25C7F10", VA = "0x1825C9310")]
	public void PPPJBCMJDOG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67C1690", Offset = "0x67C0290", VA = "0x1867C1690")]
	public void PPPJBCMJDOG(Type KHKLDKECJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class NPOJFHNFJGG<T> : JAGILKFEEBH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string DGKLDIBPMGF(T ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T MDACLBJFLFK(string? MKCPDKJKKDJ, T IGBKLJLDCLC);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FAHAIIKPPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public DGKLDIBPMGF serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MDACLBJFLFK parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public FAHAIIKPPNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE460", Offset = "0x1BAD060", VA = "0x181BAE460")]
		internal string CMOMFNDMDFO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE500", Offset = "0x1BAD100", VA = "0x181BAE500")]
		internal object HPOPKBBAEKB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3A431E0", Offset = "0x3A41DE0", VA = "0x183A431E0")]
	public NPOJFHNFJGG(NIAGAPJMDPC PJIMOOACGAM, string EEJDHAPFKNI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AC500", Offset = "0x7AB900")] global::NPOJFHNFJGG<T>.DGKLDIBPMGF DGEDDAGKIFE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AC560", Offset = "0x7AB960")] global::NPOJFHNFJGG<T>.MDACLBJFLFK POAPGDPIKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3A42090", Offset = "0x3A40C90", VA = "0x183A42090")]
	private static object? NLJPEOGMFGO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AC5C0", Offset = "0x7AB9C0")] global::NPOJFHNFJGG<T?>.MDACLBJFLFK? POAPGDPIKCI, string? MKCPDKJKKDJ, object? IGBKLJLDCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3A41D70", Offset = "0x3A40970", VA = "0x183A41D70")]
	private static string ECCPKOGLKLF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AC620", Offset = "0x7ABA20")] global::NPOJFHNFJGG<T>.DGKLDIBPMGF EKNBBBDEPMK, object? ECNGHFJBIJL)
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
	[Cpp2IlInjected.Address(RVA = "0x67C17D0", Offset = "0x67C03D0", VA = "0x1867C17D0")]
	public static AOGHFIIJPGK BBPMEKFLOPG(this KANDIPBEDFG FPFDDKABGFP)
	{
		return default(AOGHFIIJPGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class CBGKIFBHBCE : BGCFEEJMHBP, KJFLPHCHMJM, CENKNMAKBNH, global::BPPNLIDPNJK<NIAGAPJMDPC>
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
		[Cpp2IlInjected.Address(RVA = "0x67BF180", Offset = "0x67BDD80", VA = "0x1867BF180", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool HGOAALFNNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67BD520", Offset = "0x67BC120", VA = "0x1867BD520", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool ECJMIINGPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67BD6F0", Offset = "0x67BC2F0", VA = "0x1867BD6F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool MOPGODCKGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67BE210", Offset = "0x67BCE10", VA = "0x1867BE210", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool CJMEHNJHBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67BDC70", Offset = "0x67BC870", VA = "0x1867BDC70", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool FNPJLLEIJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67BF500", Offset = "0x67BE100", VA = "0x1867BF500", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AOGHFIIJPGK PNBIJAFAAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x851940", Offset = "0x850540", VA = "0x180851940", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AOGHFIIJPGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x872FF0", Offset = "0x871BF0", VA = "0x180872FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GFCIDPAIIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67BF0E0", Offset = "0x67BDCE0", VA = "0x1867BF0E0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67BE1C0", Offset = "0x67BCDC0", VA = "0x1867BE1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string OBCKLEIGGED
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x67BF0E0", Offset = "0x67BDCE0", VA = "0x1867BF0E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PJHADCJOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9862F0", Offset = "0x984EF0", VA = "0x1809862F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB82630", Offset = "0xB81230", VA = "0x180B82630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JALKIACADKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67BE090", Offset = "0x67BCC90", VA = "0x1867BE090", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PBBOAMOLEMI ANBLJGKMAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67BF550", Offset = "0x67BE150", VA = "0x1867BF550", Slot = "20")]
		get
		{
			return default(PBBOAMOLEMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AGKJPCBFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67BDE00", Offset = "0x67BCA00", VA = "0x1867BDE00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IGIBMONOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67BEF10", Offset = "0x67BDB10", VA = "0x1867BEF10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NDFNDMKOMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67BD650", Offset = "0x67BC250", VA = "0x1867BD650", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool GAGHMECONAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67BDD10", Offset = "0x67BC910", VA = "0x1867BDD10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool CBIIKDFMNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67BE260", Offset = "0x67BCE60", VA = "0x1867BE260", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OEBJBCBHEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67BEEC0", Offset = "0x67BDAC0", VA = "0x1867BEEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CEOPLCGIAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67BDCC0", Offset = "0x67BC8C0", VA = "0x1867BDCC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GDJHGKOMBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x67BD6A0", Offset = "0x67BC2A0", VA = "0x1867BD6A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> LGADBLJGDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67BE0E0", Offset = "0x67BCCE0", VA = "0x1867BE0E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool GKNFMEEOCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67BF180", Offset = "0x67BDD80", VA = "0x1867BF180", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MONGMACOFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67BDC70", Offset = "0x67BC870", VA = "0x1867BDC70", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool LEEJAJPEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67BD520", Offset = "0x67BC120", VA = "0x1867BD520", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EBKKEEAHFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67BF070", Offset = "0x67BDC70", VA = "0x1867BF070", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OONPHJELIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67BF130", Offset = "0x67BDD30", VA = "0x1867BF130", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IJEGKCFCILN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67BD6F0", Offset = "0x67BC2F0", VA = "0x1867BD6F0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IBMFDNGNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67BDC20", Offset = "0x67BC820", VA = "0x1867BDC20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OOEPGABGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67BE210", Offset = "0x67BCE10", VA = "0x1867BE210", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OPLHANBPOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67BF500", Offset = "0x67BE100", VA = "0x1867BF500", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::FPKEPIDPABI<NIAGAPJMDPC> GDECIPMCMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67BDAE0", Offset = "0x67BC6E0", VA = "0x1867BDAE0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67BDD60", Offset = "0x67BC960", VA = "0x1867BDD60", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E53EE0", Offset = "0x2E52AE0", VA = "0x182E53EE0", Slot = "6")]
	public (bool, T?) DFDHKNDMKOK<T>(NIAGAPJMDPC PJIMOOACGAM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E54080", Offset = "0x2E52C80", VA = "0x182E54080")]
	public CBGKIFBHBCE MCMAEOKBMBI<T>(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T ECNGHFJBIJL) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67BF790", Offset = "0x67BE390", VA = "0x1867BF790")]
	public CBGKIFBHBCE(AOGHFIIJPGK GNFABOPCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67BF770", Offset = "0x67BE370", VA = "0x1867BF770")]
	public CBGKIFBHBCE(AOGHFIIJPGK GNFABOPCIDF, [Optional] string? HLNKIOKJPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67BF7B0", Offset = "0x67BE3B0", VA = "0x1867BF7B0")]
	public CBGKIFBHBCE(CBGKIFBHBCE MIBKBMOGBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67BF610", Offset = "0x67BE210", VA = "0x1867BF610")]
	internal CBGKIFBHBCE(AOGHFIIJPGK EPNOOHHPEMI, [Optional] string? HLNKIOKJPHH, [Optional] CBGKIFBHBCE? MIBKBMOGBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67BE140", Offset = "0x67BCD40", VA = "0x1867BE140")]
	public static FGIBCPMDCOI FPHGJDAHJIB(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default(FGIBCPMDCOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67BF0C0", Offset = "0x67BDCC0", VA = "0x1867BF0C0")]
	public void MDBAOJEGDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67BF1D0", Offset = "0x67BDDD0", VA = "0x1867BF1D0")]
	internal CBGKIFBHBCE NGIJMOCGGED(CBGKIFBHBCE JHPGJJKOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67BD740", Offset = "0x67BC340", VA = "0x1867BD740")]
	internal IReadOnlyCollection<NIAGAPJMDPC> BOIMNMIKDGA(CBGKIFBHBCE MIBKBMOGBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67BD570", Offset = "0x67BC170", VA = "0x1867BD570")]
	public bool BAKNIFFELBH(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, string MAENKEFGOMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67BEF60", Offset = "0x67BDB60", VA = "0x1867BEF60")]
	public (bool, string) LJMKDJGBKLF(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67BDB80", Offset = "0x67BC780", VA = "0x1867BDB80")]
	internal void CDJLNDKJAMA(NIAGAPJMDPC PJIMOOACGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67BDE50", Offset = "0x67BCA50", VA = "0x1867BDE50")]
	public LMIOPBAHGDP FEADFCNPGMN(Func<AOGHFIIJPGK, Guid> IJDFGHJNPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67BE2B0", Offset = "0x67BCEB0", VA = "0x1867BE2B0")]
	public void JPEAAKBBHGK(LMIOPBAHGDP IMLKIKFBFNG, Func<Guid, AOGHFIIJPGK> EJAOKBHGJDP, [Optional] AOGHFIIJPGK? ADGAMFGFLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67BF460", Offset = "0x67BE060", VA = "0x1867BF460")]
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
public interface BGCFEEJMHBP : KJFLPHCHMJM, CENKNMAKBNH, global::BPPNLIDPNJK<NIAGAPJMDPC>
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x851940", Offset = "0x850540", VA = "0x180851940")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x48DC0A0", Offset = "0x48DACA0", VA = "0x1848DC0A0", Slot = "4")]
	public override bool MNBHKBFFHBK(object? ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x48DBC30", Offset = "0x48DA830", VA = "0x1848DBC30")]
	public bool JMHHKDMNBHJ(T FEEEOGHEKFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48DC560", Offset = "0x48DB160", VA = "0x1848DC560")]
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
	private static readonly global::CIHALCFMIHM<AOGHFIIJPGK, Guid> HCJLAPKLKFK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<AOGHFIIJPGK> LKMGDECJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67C07B0", Offset = "0x67BF3B0", VA = "0x1867C07B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67C0860", Offset = "0x67BF460", VA = "0x1867C0860")]
	public static AOGHFIIJPGK NALAMBCMNNO(Guid PCFHAIHNKAK)
	{
		return default(AOGHFIIJPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67C0660", Offset = "0x67BF260", VA = "0x1867C0660")]
	public static Guid FAPFHJNKJFL(AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67C0710", Offset = "0x67BF310", VA = "0x1867C0710")]
	public static bool FELGNIEIHOL(AOGHFIIJPGK GNFABOPCIDF, out Guid PCFHAIHNKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67C09A0", Offset = "0x67BF5A0", VA = "0x1867C09A0")]
	public static bool OPMJCMACBIJ(Guid PCFHAIHNKAK, out AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67C0830", Offset = "0x67BF430", VA = "0x1867C0830")]
	public static AOGHFIIJPGK MLBKMDGKGFE(AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(AOGHFIIJPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67C08F0", Offset = "0x67BF4F0", VA = "0x1867C08F0")]
	public static NJGKBEBLDCB NGKDOBPBMCO(AOGHFIIJPGK NGCOOCKBPCK)
	{
		return default(NJGKBEBLDCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67C0620", Offset = "0x67BF220", VA = "0x1867C0620")]
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
		[Cpp2IlInjected.Address(RVA = "0x67C1830", Offset = "0x67C0430", VA = "0x1867C1830", Slot = "4")]
		public bool Equals(List<string> OLGJDFCIILF, List<string> IKFJLOPMKHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x67C1990", Offset = "0x67C0590", VA = "0x1867C1990", Slot = "5")]
		public int GetHashCode(List<string> HHNPCHNMLMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LFDEOIHPHIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class ELEPGBNIJEF : global::CIPELGAELCD<PBBOAMOLEMI>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67BFC70", Offset = "0x67BE870", VA = "0x1867BFC70", Slot = "9")]
		public override string ECCPKOGLKLF(PBBOAMOLEMI BEEPMJAJNKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67BFD70", Offset = "0x67BE970", VA = "0x1867BFD70", Slot = "10")]
		protected override bool EGOMAFHAGPI(string BEEPMJAJNKA, out PBBOAMOLEMI ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x67BFF60", Offset = "0x67BEB60", VA = "0x1867BFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67C4040", Offset = "0x67C2C40", VA = "0x1867C4040")]
	public OLOGMHPPHML([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AC700", Offset = "0x7ABB00")] IList<JAGILKFEEBH> HJAGGCDKPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67C3450", Offset = "0x67C2050", VA = "0x1867C3450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MDEHOAKJKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67C2680", Offset = "0x67C1280", VA = "0x1867C2680")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DPCNGLPGJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67BFC60", Offset = "0x67BE860", VA = "0x1867BFC60")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ACC90", Offset = "0x7AC090")]
		private TaskAwaiter<LKAMNMFEGMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NOBAKBGEECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67C28E0", Offset = "0x67C14E0", VA = "0x1867C28E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MGNJEGDOAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67C27E0", Offset = "0x67C13E0", VA = "0x1867C27E0")]
		internal void FLCHPGFAGCB(LMIOPBAHGDP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67C26B0", Offset = "0x67C12B0", VA = "0x1867C26B0")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ACCF0", Offset = "0x7AC0F0")]
		public Func<LMIOPBAHGDP, HFLPPJEOCHJ> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ADLOJGKPIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67BCDB0", Offset = "0x67BB9B0", VA = "0x1867BCDB0")]
		internal void KLDLLKGFLHM(LMIOPBAHGDP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67BCD40", Offset = "0x67BB940", VA = "0x1867BCD40")]
		internal void JLHOBLGJFOO(LMIOPBAHGDP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67BCCD0", Offset = "0x67BB8D0", VA = "0x1867BCCD0")]
		internal void BDMGMEFLJMP(LMIOPBAHGDP r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GDPFIPJDBBF<T> where T : notnull
	{
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public GDPFIPJDBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4693780", Offset = "0x4692380", VA = "0x184693780")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ACE10", Offset = "0x7AC210")]
		public IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public GBEHEHLFCID debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ACE70", Offset = "0x7AC270")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ACED0", Offset = "0x7AC2D0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LILOGHFBLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67C1B30", Offset = "0x67C0730", VA = "0x1867C1B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<BGCFEEJMHBP> GFNAOHOLJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67C4B30", Offset = "0x67C3730", VA = "0x1867C4B30", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PHCFCNKNBPG ECAEEGOLBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67C47A0", Offset = "0x67C33A0", VA = "0x1867C47A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67C6550", Offset = "0x67C5150", VA = "0x1867C6550", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67C80C0", Offset = "0x67C6CC0", VA = "0x1867C80C0")]
	[BBAPFPLPODF(BLGLNFDFDJO.Room, EDNJEIFHIMJ.None)]
	private static void LECKBAIJAMJ(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67C9A60", Offset = "0x67C8660", VA = "0x1867C9A60")]
	[UnityEngine.Scripting.Preserve]
	internal PPIJIAIIDNJ([ACEKLAKDMBL(null)] KANDIPBEDFG MKNBJLFHDDC, [ACEKLAKDMBL(null)] GGOIBBNBHLL DCJGABGJNLN, [ACEKLAKDMBL(null)] GBEHEHLFCID GBLFMIICBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67C5700", Offset = "0x67C4300", VA = "0x1867C5700", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67C7430", Offset = "0x67C6030", VA = "0x1867C7430")]
	private void JAMOMBMNDKD(IEnumerable<CBGKIFBHBCE> MJDKNGLGPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67C8300", Offset = "0x67C6F00", VA = "0x1867C8300", Slot = "12")]
	public bool NJEMCBPEOEA(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67C92E0", Offset = "0x67C7EE0", VA = "0x1867C92E0")]
	private void OHPKHMEIECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67C5BB0", Offset = "0x67C47B0", VA = "0x1867C5BB0")]
	private void FBNEJODGHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67C6070", Offset = "0x67C4C70", VA = "0x1867C6070", Slot = "10")]
	public IReadOnlyList<BGCFEEJMHBP> FHIMDHLFCHI(bool AEKDEAOHPIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67C7FB0", Offset = "0x67C6BB0", VA = "0x1867C7FB0", Slot = "11")]
	public BGCFEEJMHBP KKMJPLBNGPG(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67C4D40", Offset = "0x67C3940", VA = "0x1867C4D40")]
	private AOGHFIIJPGK DAKMDDFLPIJ(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return default(AOGHFIIJPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67C5EE0", Offset = "0x67C4AE0", VA = "0x1867C5EE0", Slot = "14")]
	public bool FFHMGFLPFDI(IGGCDPKBFGF IPILBAOKPEC, AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67C7380", Offset = "0x67C5F80", VA = "0x1867C7380", Slot = "15")]
	public BGCFEEJMHBP IBBGFPBNCOL(AOGHFIIJPGK GNFABOPCIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67C43B0", Offset = "0x67C2FB0", VA = "0x1867C43B0")]
	private static bool AAPDFCDLEDH(LHNDJGDOOFF HLBGBCNNLKH, AOGHFIIJPGK GNFABOPCIDF, out LMIOPBAHGDP? MJAPIOPONHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67C6250", Offset = "0x67C4E50", VA = "0x1867C6250")]
	private static void GMOKACOHNJP(LHNDJGDOOFF HLBGBCNNLKH, Action<LMIOPBAHGDP> LHCANCKPNCE, AOGHFIIJPGK DMDNIEAOBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67C6350", Offset = "0x67C4F50", VA = "0x1867C6350")]
	private static void GMOKACOHNJP(LHNDJGDOOFF HLBGBCNNLKH, Action<LMIOPBAHGDP> LHCANCKPNCE, Predicate<AOGHFIIJPGK> FOJODEADCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67C82A0", Offset = "0x67C6EA0", VA = "0x1867C82A0")]
	private void MPPCHPNCJAE(IGGCDPKBFGF ILJFHAFPNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67C7C20", Offset = "0x67C6820", VA = "0x1867C7C20", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOBAKBGEECO))]
	public Task JBJHIANOAAE([CanBeNull] BNIDNMGAHLD CMMCIHFHBLL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
	public void GBPJJJPMBLI(ref BNIDNMGAHLD CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67C92F0", Offset = "0x67C7EF0", VA = "0x1867C92F0")]
	private void PBPELMLDHAK(LHNDJGDOOFF OEBKHLNOAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67C9570", Offset = "0x67C8170", VA = "0x1867C9570")]
	internal static string PKELEDLKCHD(KANDIPBEDFG FPFDDKABGFP, BNIDNMGAHLD CMMCIHFHBLL, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67C83D0", Offset = "0x67C6FD0", VA = "0x1867C83D0")]
	private static void OFPEKLHKLOM(BNIDNMGAHLD CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67C7060", Offset = "0x67C5C60", VA = "0x1867C7060")]
	private static void IAPOPJKJOJP(LHNDJGDOOFF LMKKJPMBMCO, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP, StringBuilder FGBNFMFFMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67C60F0", Offset = "0x67C4CF0", VA = "0x1867C60F0")]
	private static bool GFHNMBIKKEK(string JCIMKDAIEGA, out Guid JPOPADHIGCL, out AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67C50E0", Offset = "0x67C3CE0", VA = "0x1867C50E0")]
	private static void DJADIFFCDGB(BNIDNMGAHLD CMMCIHFHBLL, StringBuilder FGBNFMFFMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x21100B0", Offset = "0x210ECB0", VA = "0x1821100B0", Slot = "16")]
	public bool FKIDMJOGIIC<T>(AOGHFIIJPGK GNFABOPCIDF, NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T AIMHDAMIMIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67C4B80", Offset = "0x67C3780", VA = "0x1867C4B80")]
	private void CFPNLGPCJHM(AOGHFIIJPGK GNFABOPCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67C8280", Offset = "0x67C6E80", VA = "0x1867C8280")]
	private bool LMBMFGGOBLG(IGGCDPKBFGF ILJFHAFPNBB, AOGHFIIJPGK GNFABOPCIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67C6D40", Offset = "0x67C5940", VA = "0x1867C6D40")]
	internal CBGKIFBHBCE HKJDEAECGEG(IGGCDPKBFGF ILJFHAFPNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67C6D30", Offset = "0x67C5930", VA = "0x1867C6D30", Slot = "13")]
	public IReadOnlyList<BGCFEEJMHBP> HBICEJJCNKA(IGGCDPKBFGF ILJFHAFPNBB, bool NKMJEDFBLCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67C7D90", Offset = "0x67C6990", VA = "0x1867C7D90")]
	internal IReadOnlyList<CBGKIFBHBCE> KAJODIJDPKH(IGGCDPKBFGF ILJFHAFPNBB, bool NKMJEDFBLCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67C65F0", Offset = "0x67C51F0", VA = "0x1867C65F0")]
	private void GOADBGOHGAA(LKAMNMFEGMK IKBCNIMJBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x67C4840", Offset = "0x67C3440", VA = "0x1867C4840")]
	private static bool AMOMPBALMPG(CBGKIFBHBCE OKJHEMOKIFA, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP, out IReadOnlyList<NIAGAPJMDPC> IFEGNCKBCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67C5D40", Offset = "0x67C4940", VA = "0x1867C5D40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LILOGHFBLIN))]
	private static Task FCCMMIHACLG(KANDIPBEDFG FPFDDKABGFP, BNIDNMGAHLD CMMCIHFHBLL, IReadOnlyDictionary<AOGHFIIJPGK, CBGKIFBHBCE> DMFLCGKCJJP, GBEHEHLFCID GBLFMIICBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x67C4E00", Offset = "0x67C3A00", VA = "0x1867C4E00")]
	[CompilerGenerated]
	internal static void DCOMPNAGOOG(Func<LMIOPBAHGDP, HFLPPJEOCHJ> JGJAHDBKHAA, ref POPIKCHDLNO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x67C5810", Offset = "0x67C4410", VA = "0x1867C5810")]
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
	[Cpp2IlInjected.Address(RVA = "0x67BD2C0", Offset = "0x67BBEC0", VA = "0x1867BD2C0")]
	public AMHBLGOPGIO(OLOGMHPPHML DHHICICDCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67BCE20", Offset = "0x67BBA20", VA = "0x1867BCE20")]
	public bool CCPHIANLIDO(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x28FFB20", Offset = "0x28FE720", VA = "0x1828FFB20")]
	public bool MNJIBHAPIKE<T>(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, T ECNGHFJBIJL) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x28FF690", Offset = "0x28FE290", VA = "0x1828FF690")]
	public (bool, T?) FFLBPPLHANE<T>(NIAGAPJMDPC PJIMOOACGAM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67BD120", Offset = "0x67BBD20", VA = "0x1867BD120")]
	public bool MNJIBHAPIKE(NIAGAPJMDPC PJIMOOACGAM, bool LOKMACHDPKB, object ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67BCE90", Offset = "0x67BBA90", VA = "0x1867BCE90")]
	public (bool, object) FFLBPPLHANE(NIAGAPJMDPC PJIMOOACGAM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x28FFC50", Offset = "0x28FE850", VA = "0x1828FFC50")]
	private void PPPJBCMJDOG<T>(NIAGAPJMDPC PJIMOOACGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67BD200", Offset = "0x67BBE00", VA = "0x1867BD200")]
	private HOLHGNHJKPB PPLLJGKCPIM(NIAGAPJMDPC PJIMOOACGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x67BCF80", Offset = "0x67BBB80", VA = "0x1867BCF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67C1550", Offset = "0x67C0150", VA = "0x1867C1550")]
	public GGOIBBNBHLL(CBGKIFBHBCE DPNNMGHNMEN, IReadOnlyList<CBGKIFBHBCE> DBAKGDBFEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67C0D10", Offset = "0x67BF910", VA = "0x1867C0D10")]
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

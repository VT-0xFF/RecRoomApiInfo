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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x265D370", Offset = "0x265C770", VA = "0x18265D370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct NLLHCEKBIKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> CFIEFIHDPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MCKFPDMFILD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
	public NLLHCEKBIKK(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> NGGDGEGELFB, int NPELPNMIGOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PJPDHMOOMGC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BNOFDHGNPOM : ICEKOGPAHCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NNOPOFGPIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly GGMLKLKGFPB<byte> GFOIFMPIBBG;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26107B0", Offset = "0x260FBB0", VA = "0x1826107B0")]
		public NNOPOFGPIFK(GGMLKLKGFPB<byte> FIKLNMFCLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x265D300", Offset = "0x265C700", VA = "0x18265D300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LOIIGALCMKM : ICEKOGPAHCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MLDLPAGECHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> MFJPPNEPKBH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public MLDLPAGECHK(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> FDEBCGCODMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum OKAHGKBMFPL
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
	public sealed class DMPLDGKPELF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class ICEKOGPAHCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct IGILFFCPHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly OKAHGKBMFPL BLIBCCCHBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly EECNAGIPCBM<ICEKOGPAHCA> ILEBBDCEKFG;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		public IGILFFCPHCD(OKAHGKBMFPL LOIJJNIFOIJ, EECNAGIPCBM<ICEKOGPAHCA> EGGEHMOJIBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IHKALKFBKBB : ICEKOGPAHCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct NDAGIKPPDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LFHGJELFJNM;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public NDAGIKPPDEE(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class NAGCPJKJNMD : ICEKOGPAHCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct FBJFPHFECEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly IOFJIGKIBJE HBKBEMHJLCG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public FBJFPHFECEA(IOFJIGKIBJE IGPOKBHLOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x26589E0", Offset = "0x2657DE0", VA = "0x1826589E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal JJELNEGKCGH<DMPLDGKPELF, IGILFFCPHCD> GBBBIPLHAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal JJELNEGKCGH<BNOFDHGNPOM, NNOPOFGPIFK> ABAIFDPIMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal JJELNEGKCGH<LOIIGALCMKM, MLDLPAGECHK> EPAJMEIMBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JJELNEGKCGH<IHKALKFBKBB, NDAGIKPPDEE> AOOFJOAPCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal JJELNEGKCGH<NAGCPJKJNMD, FBJFPHFECEA> KBIHAFGMGMH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2662930", Offset = "0x2661D30", VA = "0x182662930")]
	private PJPDHMOOMGC([In] JJELNEGKCGH<DMPLDGKPELF, IGILFFCPHCD> KOPDNBDNPHO, [In] JJELNEGKCGH<BNOFDHGNPOM, NNOPOFGPIFK> NMJNLHLAHPE, [In] JJELNEGKCGH<LOIIGALCMKM, MLDLPAGECHK> LFAOJPDHMOH, [In] JJELNEGKCGH<IHKALKFBKBB, NDAGIKPPDEE> LNJGAOHGNND, [In] JJELNEGKCGH<NAGCPJKJNMD, FBJFPHFECEA> PBPFIKBNDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26627F0", Offset = "0x2661BF0", VA = "0x1826627F0")]
	public static PJPDHMOOMGC AFLKMMODJAC()
	{
		return default(PJPDHMOOMGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FLINBPNGEAO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2658DF0", Offset = "0x26581F0", VA = "0x182658DF0")]
	public static void DPGGICHIMDD(this PJPDHMOOMGC CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum HLCHIJBHGDA
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
public struct IGEMNCMFBBG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class AKEBMPPPHEL : BPCMGPLHFNF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct HMKIJEIKHOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> JDAIBEENBCN;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public HMKIJEIKHOO(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> LLPFAJGBDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum BEMJDPLFNEN
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
	public sealed class PPBAFGOLANA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BPCMGPLHFNF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct JHGENHDOCHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly BEMJDPLFNEN BLIBCCCHBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly EECNAGIPCBM<BPCMGPLHFNF> ILEBBDCEKFG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		public JHGENHDOCHL(BEMJDPLFNEN LOIJJNIFOIJ, EECNAGIPCBM<BPCMGPLHFNF> EGGEHMOJIBL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JJELNEGKCGH<PPBAFGOLANA, JHGENHDOCHL> GBBBIPLHAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JJELNEGKCGH<AKEBMPPPHEL, HMKIJEIKHOO> NPAPGNKMDMM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x265BAE0", Offset = "0x265AEE0", VA = "0x18265BAE0")]
	private IGEMNCMFBBG([In] JJELNEGKCGH<PPBAFGOLANA, JHGENHDOCHL> KOPDNBDNPHO, [In] JJELNEGKCGH<AKEBMPPPHEL, HMKIJEIKHOO> MACELGEABMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x265BA50", Offset = "0x265AE50", VA = "0x18265BA50")]
	public static IGEMNCMFBBG AFLKMMODJAC()
	{
		return default(IGEMNCMFBBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MKDMCLNOEPL
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x265D1F0", Offset = "0x265C5F0", VA = "0x18265D1F0")]
	public static void DPGGICHIMDD(this IGEMNCMFBBG CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HCAAKLNHGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public EPPNKNJKIOI<int> HCEBJCBJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public EPPNKNJKIOI<int> LIEKDBPJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GPCCIAAGOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int NCIDAOJEIAC;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26591A0", Offset = "0x26585A0", VA = "0x1826591A0")]
	private HCAAKLNHGPM([In] EPPNKNJKIOI<int> IBBELGCDODJ, [In] EPPNKNJKIOI<int> OPKBJDLNFHO, int PHHKAPDFGOP, int IGMEJPHBJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2659100", Offset = "0x2658500", VA = "0x182659100")]
	public static HCAAKLNHGPM AFLKMMODJAC()
	{
		return default(HCAAKLNHGPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GKJFJGNBNKA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26590B0", Offset = "0x26584B0", VA = "0x1826590B0")]
	public static void DPGGICHIMDD(this HCAAKLNHGPM CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DHMFJKHGMGO
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum HAJAEKFOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class EEINGIOMKLI : DBHEEPLLJDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct CKFJIODBOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly EECNAGIPCBM<HBGEKKIHFCM> PCGIBELEJHD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public CKFJIODBOPK(EECNAGIPCBM<HBGEKKIHFCM> IPLDJACDDHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class LMPEOAGOEEL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class DBHEEPLLJDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct BADPAOOJCKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly HAJAEKFOJEM BLIBCCCHBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly EECNAGIPCBM<DBHEEPLLJDC> ILEBBDCEKFG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		private BADPAOOJCKI(HAJAEKFOJEM LOIJJNIFOIJ, EECNAGIPCBM<DBHEEPLLJDC> EGGEHMOJIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2656ED0", Offset = "0x26562D0", VA = "0x182656ED0")]
		public static BADPAOOJCKI AFLKMMODJAC(HAJAEKFOJEM LOIJJNIFOIJ, EECNAGIPCBM<DBHEEPLLJDC> EGGEHMOJIBL)
		{
			return default(BADPAOOJCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class CMLJADFGAIP : DBHEEPLLJDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct KNJLDOFOJFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly EECNAGIPCBM<HBGEKKIHFCM> PCGIBELEJHD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public KNJLDOFOJFO(EECNAGIPCBM<HBGEKKIHFCM> IPLDJACDDHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class HBGEKKIHFCM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct ONHBLADPMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public EPPNKNJKIOI<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> ACHGAIDLNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public EPPNKNJKIOI<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> CANJMPJGKFO;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x265BAE0", Offset = "0x265AEE0", VA = "0x18265BAE0")]
		private ONHBLADPMIH([In] EPPNKNJKIOI<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> HGIBOFDMGIA, [In] EPPNKNJKIOI<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> CMEFFOCHLHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x265D410", Offset = "0x265C810", VA = "0x18265D410")]
		public static ONHBLADPMIH AFLKMMODJAC()
		{
			return default(ONHBLADPMIH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal JJELNEGKCGH<LMPEOAGOEEL, BADPAOOJCKI> GBBBIPLHAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal JJELNEGKCGH<CMLJADFGAIP, KNJLDOFOJFO> DEELJBHAGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal JJELNEGKCGH<EEINGIOMKLI, CKFJIODBOPK> AGAENIOJEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal EPPNKNJKIOI<(EECNAGIPCBM<LMPEOAGOEEL> CallId, EECNAGIPCBM<HBGEKKIHFCM> IOId)> NFBKHEHBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal JJELNEGKCGH<HBGEKKIHFCM, ONHBLADPMIH> GHMNBCGJBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal CCCBKFAHMKF<HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> DLJIDCCJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal CCCBKFAHMKF<HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> CAPINNGIIKJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26583A0", Offset = "0x26577A0", VA = "0x1826583A0")]
	private DHMFJKHGMGO([In] JJELNEGKCGH<LMPEOAGOEEL, BADPAOOJCKI> KOPDNBDNPHO, [In] JJELNEGKCGH<CMLJADFGAIP, KNJLDOFOJFO> PKGNLGBJCCG, [In] JJELNEGKCGH<EEINGIOMKLI, CKFJIODBOPK> NNOEEKLNAPG, [In] EPPNKNJKIOI<(EECNAGIPCBM<LMPEOAGOEEL> CallId, EECNAGIPCBM<HBGEKKIHFCM> IOId)> PGOJOPEDAEL, [In] JJELNEGKCGH<HBGEKKIHFCM, ONHBLADPMIH> EJCNBBCJACG, [In] CCCBKFAHMKF<HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> IJDCENNHKFC, [In] CCCBKFAHMKF<HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> CHPJIMDJIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2658200", Offset = "0x2657600", VA = "0x182658200")]
	public static DHMFJKHGMGO AFLKMMODJAC()
	{
		return default(DHMFJKHGMGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FFEFJPCJEMI
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2658DA0", Offset = "0x26581A0", VA = "0x182658DA0")]
	private static void DPGGICHIMDD(this DHMFJKHGMGO.ONHBLADPMIH CAMFIHKHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2658B90", Offset = "0x2657F90", VA = "0x182658B90")]
	public static void DPGGICHIMDD(this DHMFJKHGMGO CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct IOKGLICIDEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public EPPNKNJKIOI<byte> IFEDJOHECNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal DHMFJKHGMGO HDGAJLGAPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CONANDLBPOH JFDGIJLOMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> OPKLMMCMJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal PJPDHMOOMGC PMLCIDBBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IGEMNCMFBBG KAMGHCFGNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal CCCBKFAHMKF<BPHLKFKIMPM, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>?> GILDOGCHOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal EPPNKNJKIOI<EECNAGIPCBM<BPHLKFKIMPM>> EDIMMNOLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> IJHOJFKJPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> DNNLLGNFEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> HBKLKDBMOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal EFIGFLMDEKG FKFCAHPLBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal KKCGLIHIMNA GAIONMAOFHH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x265C580", Offset = "0x265B980", VA = "0x18265C580")]
	private IOKGLICIDEE([In] EPPNKNJKIOI<byte> HALFFKHDADM, [In] DHMFJKHGMGO LGGBPKDCHGL, [In] CONANDLBPOH AGJKCPEKGJI, [In] PJPDHMOOMGC OELIMBAOLPO, [In] IGEMNCMFBBG DEKCGBOIJJE, [In] CCCBKFAHMKF<BPHLKFKIMPM, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>?> JBPHBLHEHOM, [In] EPPNKNJKIOI<EECNAGIPCBM<BPHLKFKIMPM>> NMDBEJLIAGF, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> HAMIKCBANCF, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> AAKLACNMIOA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> LKHHOIMCHJD, [In] EFIGFLMDEKG IANIOJAIFBL, [In] KKCGLIHIMNA ACHICPHNDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x265BBD0", Offset = "0x265AFD0", VA = "0x18265BBD0")]
	public static IOKGLICIDEE AFLKMMODJAC()
	{
		return default(IOKGLICIDEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IBEOJBOFPAG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JCHLAFCDNAI : NCEAOIMCKHD<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>, CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x265C920", Offset = "0x265BD20", VA = "0x18265C920")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x265C8E0", Offset = "0x265BCE0", VA = "0x18265C8E0", Slot = "4")]
		public EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> AAADANHJMBK(int KDCAMOIGIMA)
		{
			return default(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		public bool NHDFDADGCDP(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "5")]
		private bool NNEEKMKHHEA(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x265C910", Offset = "0x265BD10", VA = "0x18265C910", Slot = "6")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JDFMMEMBCEL(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct JNOHNNCMCNH : JFONNPICNHC<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>, CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x265CC00", Offset = "0x265C000", VA = "0x18265CC00")]
		public EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>> HCNCBFGMAMK(int GNINAHMNGMN, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x265CC70", Offset = "0x265C070", VA = "0x18265CC70")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x265CD30", Offset = "0x265C130", VA = "0x18265CD30", Slot = "6")]
		public void NOPKFBOGOLC(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x265CC00", Offset = "0x265C000", VA = "0x18265CC00", Slot = "4")]
		private EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>> DICKPPGHCFE(int GNINAHMNGMN, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x265CD20", Offset = "0x265C120", VA = "0x18265CD20", Slot = "5")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> MADMFKMBAGN(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct AAAJLPMNIKI : NCEAOIMCKHD<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>, CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2656DA0", Offset = "0x26561A0", VA = "0x182656DA0")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2656D60", Offset = "0x2656160", VA = "0x182656D60", Slot = "4")]
		public EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> AAADANHJMBK(int KDCAMOIGIMA)
		{
			return default(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		public bool NHDFDADGCDP(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "5")]
		private bool IMONBDGBIEJ(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2656D90", Offset = "0x2656190", VA = "0x182656D90", Slot = "6")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> EHICHCMGIJB(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct LHFDMDBKJNO : JFONNPICNHC<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>, CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x265CF30", Offset = "0x265C330", VA = "0x18265CF30")]
		public EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>> HCNCBFGMAMK(int GNINAHMNGMN, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x265CFA0", Offset = "0x265C3A0", VA = "0x18265CFA0")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x265D060", Offset = "0x265C460", VA = "0x18265D060", Slot = "6")]
		public void NOPKFBOGOLC(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x265CF30", Offset = "0x265C330", VA = "0x18265CF30", Slot = "4")]
		private EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>> GOBOIGEEGBP(int GNINAHMNGMN, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x265D050", Offset = "0x265C450", VA = "0x18265D050", Slot = "5")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> KHNJNLFHKLG(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> KDCAMOIGIMA, [In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct FDHNLMDHJGC : NCEAOIMCKHD<EECNAGIPCBM<BOBCICDOPCN>, CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2658AC0", Offset = "0x2657EC0", VA = "0x182658AC0")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2658A00", Offset = "0x2657E00", VA = "0x182658A00", Slot = "4")]
		public EECNAGIPCBM<BOBCICDOPCN> AAADANHJMBK(int KDCAMOIGIMA)
		{
			return default(EECNAGIPCBM<BOBCICDOPCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2658A30", Offset = "0x2657E30", VA = "0x182658A30")]
		public bool NHDFDADGCDP(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2658A30", Offset = "0x2657E30", VA = "0x182658A30", Slot = "5")]
		private bool BKNPBJFIBNJ(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2658AB0", Offset = "0x2657EB0", VA = "0x182658AB0", Slot = "6")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> BOHFMKALMPC(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct JFECOAJPAMJ : JFONNPICNHC<EECNAGIPCBM<BOBCICDOPCN>, CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x265C9D0", Offset = "0x265BDD0", VA = "0x18265C9D0")]
		public EPPNKNJKIOI<EECNAGIPCBM<BOBCICDOPCN>> HCNCBFGMAMK(int GNINAHMNGMN, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<EECNAGIPCBM<BOBCICDOPCN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x265CA50", Offset = "0x265BE50", VA = "0x18265CA50")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x265CB20", Offset = "0x265BF20", VA = "0x18265CB20", Slot = "6")]
		public void NOPKFBOGOLC(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x265C9D0", Offset = "0x265BDD0", VA = "0x18265C9D0", Slot = "4")]
		private EPPNKNJKIOI<EECNAGIPCBM<BOBCICDOPCN>> OOLGNBDLCHA(int GNINAHMNGMN, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<EECNAGIPCBM<BOBCICDOPCN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x265CA40", Offset = "0x265BE40", VA = "0x18265CA40", Slot = "5")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> HPPBKAICOLM(EECNAGIPCBM<BOBCICDOPCN> KDCAMOIGIMA, [In] CCCBKFAHMKF<BOBCICDOPCN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>?> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct ONODLJFMFGE : NCEAOIMCKHD<int, EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x265D490", Offset = "0x265C890", VA = "0x18265D490")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCFB520", Offset = "0xCFA920", VA = "0x180CFB520", Slot = "4")]
		public int AAADANHJMBK(int KDCAMOIGIMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		public bool NHDFDADGCDP(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "5")]
		private bool LBKPGIKGKJE(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x265D530", Offset = "0x265C930", VA = "0x18265D530", Slot = "6")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> OJKMEDHBHKO(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct ECJABPCINOE : JFONNPICNHC<int, EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2658460", Offset = "0x2657860", VA = "0x182658460")]
		public EPPNKNJKIOI<int> HCNCBFGMAMK(int GNINAHMNGMN, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x26584E0", Offset = "0x26578E0", VA = "0x1826584E0")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2658580", Offset = "0x2657980", VA = "0x182658580", Slot = "6")]
		public void NOPKFBOGOLC(int KDCAMOIGIMA, EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2658460", Offset = "0x2657860", VA = "0x182658460", Slot = "4")]
		private EPPNKNJKIOI<int> FFBLFDDABGE(int GNINAHMNGMN, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x26584D0", Offset = "0x26578D0", VA = "0x1826584D0", Slot = "5")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> HMOEHFLOGCH(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> VariableId, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<AIBFMNHAJPD>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct DBIKMGOGEGL : NCEAOIMCKHD<int, EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2658160", Offset = "0x2657560", VA = "0x182658160")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCFB520", Offset = "0xCFA920", VA = "0x180CFB520", Slot = "4")]
		public int AAADANHJMBK(int KDCAMOIGIMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		public bool NHDFDADGCDP(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "5")]
		private bool JOGBHFAJLAO(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2658150", Offset = "0x2657550", VA = "0x182658150", Slot = "6")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> IPMKEGAPCFM(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct DAPEKPCINMA : JFONNPICNHC<int, EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2657F40", Offset = "0x2657340", VA = "0x182657F40")]
		public EPPNKNJKIOI<int> HCNCBFGMAMK(int GNINAHMNGMN, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2657FC0", Offset = "0x26573C0", VA = "0x182657FC0")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2658060", Offset = "0x2657460", VA = "0x182658060", Slot = "6")]
		public void NOPKFBOGOLC(int KDCAMOIGIMA, EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2657F40", Offset = "0x2657340", VA = "0x182657F40", Slot = "4")]
		private EPPNKNJKIOI<int> DJBBADEJMAF(int GNINAHMNGMN, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2657FB0", Offset = "0x26573B0", VA = "0x182657FB0", Slot = "5")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> EDBLOCOPGLH(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct IIMLHCILIOG : NCEAOIMCKHD<int, EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x265BB30", Offset = "0x265AF30", VA = "0x18265BB30")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xCFB520", Offset = "0xCFA920", VA = "0x180CFB520", Slot = "4")]
		public int AAADANHJMBK(int KDCAMOIGIMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		public bool NHDFDADGCDP(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "5")]
		private bool JOGBHFAJLAO(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x265BB20", Offset = "0x265AF20", VA = "0x18265BB20", Slot = "6")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> IPMKEGAPCFM(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct BPJLNNGGOLF : JFONNPICNHC<int, EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2657A00", Offset = "0x2656E00", VA = "0x182657A00")]
		public EPPNKNJKIOI<int> HCNCBFGMAMK(int GNINAHMNGMN, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2657A80", Offset = "0x2656E80", VA = "0x182657A80")]
		public EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2657B20", Offset = "0x2656F20", VA = "0x182657B20", Slot = "6")]
		public void NOPKFBOGOLC(int KDCAMOIGIMA, EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2657A00", Offset = "0x2656E00", VA = "0x182657A00", Slot = "4")]
		private EPPNKNJKIOI<int> DJBBADEJMAF(int GNINAHMNGMN, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EPPNKNJKIOI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2657A70", Offset = "0x2656E70", VA = "0x182657A70", Slot = "5")]
		private EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> EDBLOCOPGLH(int KDCAMOIGIMA, [In] EPPNKNJKIOI<(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> Target, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> ByteCodeWriteLocation)> EDJBENPLFOA)
		{
			return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct OACDEPNCGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> IFFGANIAAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool NJIGIJBGAMP;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D17590", Offset = "0x1D16990", VA = "0x181D17590")]
		public OACDEPNCGLO(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF, bool ADGMCJPEDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x265D3F0", Offset = "0x265C7F0", VA = "0x18265D3F0")]
		public void KGKDCLGKMAN([Out] EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF, [Out] bool ADGMCJPEDMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct EONIFOKECJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EECNAGIPCBM<BOBCICDOPCN> NNGKIMDLBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> IFFGANIAAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool NJIGIJBGAMP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x26589D0", Offset = "0x2657DD0", VA = "0x1826589D0")]
		public EONIFOKECJE(EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF, bool ADGMCJPEDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x26589A0", Offset = "0x2657DA0", VA = "0x1826589A0")]
		public void KGKDCLGKMAN([Out] EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF, [Out] bool ADGMCJPEDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x26589B0", Offset = "0x2657DB0", VA = "0x1826589B0")]
		public void KGKDCLGKMAN([Out] EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF, [Out] EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP, [Out] bool ADGMCJPEDMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct OIJJGLJMHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly EECNAGIPCBM<BOBCICDOPCN> NNGKIMDLBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> IFFGANIAAAF;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		public OIJJGLJMHON(EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x265D400", Offset = "0x265C800", VA = "0x18265D400")]
		public void KGKDCLGKMAN([Out] EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF, [Out] EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2659930", Offset = "0x2658D30", VA = "0x182659930")]
	public static void DPGGICHIMDD(this IOKGLICIDEE CAMFIHKHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x265ADD0", Offset = "0x265A1D0", VA = "0x18265ADD0")]
	public static void LAPHKDCPIAL(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> BCLLEKNIEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26595E0", Offset = "0x26589E0", VA = "0x1826595E0")]
	public static void CEONJNCCGPG(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> BCLLEKNIEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x265A990", Offset = "0x2659D90", VA = "0x18265A990")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>? JIOMHPAFKMJ([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x265AE60", Offset = "0x265A260", VA = "0x18265AE60")]
	public static EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> LDPBPAEMPDK([In] this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x265A6B0", Offset = "0x2659AB0", VA = "0x18265A6B0")]
	private static void HPDECIJLCGD(this IOKGLICIDEE CAMFIHKHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x265B5A0", Offset = "0x265A9A0", VA = "0x18265B5A0")]
	private static EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>? OMIHPOMONAP([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x265AC60", Offset = "0x265A060", VA = "0x18265AC60")]
	public static void KONFACJIEID(this IOKGLICIDEE CAMFIHKHJNG, [In] EPPNKNJKIOI<NLLHCEKBIKK> BMPJCPPCPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2659560", Offset = "0x2658960", VA = "0x182659560")]
	public static PJPDHMOOMGC.OKAHGKBMFPL BHLNDKMGPNM([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
	{
		return default(PJPDHMOOMGC.OKAHGKBMFPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x265A8A0", Offset = "0x2659CA0", VA = "0x18265A8A0")]
	public static GGMLKLKGFPB<byte> JIHCPMMGDFM([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
	{
		return default(GGMLKLKGFPB<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x265A4C0", Offset = "0x26598C0", VA = "0x18265A4C0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> HFKCNADGNIL([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x265B0E0", Offset = "0x265A4E0", VA = "0x18265B0E0")]
	public static IOFJIGKIBJE LPCDPKMFHGC([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x364DEF0", Offset = "0x364D2F0", VA = "0x18364DEF0")]
	private static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> NLJEJBNGABC<TMJoin>(this IOKGLICIDEE CAMFIHKHJNG, PJPDHMOOMGC.OKAHGKBMFPL LOIJJNIFOIJ, EECNAGIPCBM<TMJoin> EGGEHMOJIBL) where TMJoin : PJPDHMOOMGC.ICEKOGPAHCA
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x265B660", Offset = "0x265AA60", VA = "0x18265B660")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> OOIHMFMFJFA(this IOKGLICIDEE CAMFIHKHJNG, bool DJKBLCPLIPJ)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26594D0", Offset = "0x26588D0", VA = "0x1826594D0")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> ANDKBNHPLDI(this IOKGLICIDEE CAMFIHKHJNG, GGMLKLKGFPB<byte> FIKLNMFCLIL)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2659450", Offset = "0x2658850", VA = "0x182659450")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> ALMOKGMLJFD(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> FDEBCGCODMD)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x265B400", Offset = "0x265A800", VA = "0x18265B400")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> NDLPCEHNEOD(this IOKGLICIDEE CAMFIHKHJNG, int GBKMDMBKNCI)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x265A820", Offset = "0x2659C20", VA = "0x18265A820")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> JENIPKNCPIL(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x364DFA0", Offset = "0x364D3A0", VA = "0x18364DFA0")]
	private static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> PCMIDGAOEEN<TMJoin>(this IOKGLICIDEE CAMFIHKHJNG, IGEMNCMFBBG.BEMJDPLFNEN LOIJJNIFOIJ, EECNAGIPCBM<TMJoin> EGGEHMOJIBL) where TMJoin : IGEMNCMFBBG.BPCMGPLHFNF
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x265B480", Offset = "0x265A880", VA = "0x18265B480")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> NFFILFJFHIJ(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x265A140", Offset = "0x2659540", VA = "0x18265A140")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> GCMLIBCDGAK(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26593D0", Offset = "0x26587D0", VA = "0x1826593D0")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> AGCDNPJPBEH(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> LLPFAJGBDDM)
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x265B550", Offset = "0x265A950", VA = "0x18265B550")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> OIGJDFFLCPC(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2659C80", Offset = "0x2659080", VA = "0x182659C80")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> FABLMHKPHDA(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x265A5B0", Offset = "0x26599B0", VA = "0x18265A5B0")]
	public static DHMFJKHGMGO.HAJAEKFOJEM HHNFFJCOEMG([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> KCOMDMNMIFE)
	{
		return default(DHMFJKHGMGO.HAJAEKFOJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x265B6E0", Offset = "0x265AAE0", VA = "0x18265B6E0")]
	public static MAMOBGBCBON<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>, MMJMAGPBPBI<DHMFJKHGMGO.HBGEKKIHFCM>> OOLDBKJNCFB([In] this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(MAMOBGBCBON<EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>, MMJMAGPBPBI<DHMFJKHGMGO.HBGEKKIHFCM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x265A190", Offset = "0x2659590", VA = "0x18265A190")]
	public static EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> GIKLBCPJBBL([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> KCOMDMNMIFE)
	{
		return default(EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2659C00", Offset = "0x2659000", VA = "0x182659C00")]
	public static DHMFJKHGMGO.ONHBLADPMIH EGGAEMAOGDO([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> IPLDJACDDHN)
	{
		return default(DHMFJKHGMGO.ONHBLADPMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x265A630", Offset = "0x2659A30", VA = "0x18265A630")]
	public static DHMFJKHGMGO.ONHBLADPMIH HLLECLHFEJH(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> IPLDJACDDHN)
	{
		return default(DHMFJKHGMGO.ONHBLADPMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x364DE50", Offset = "0x364D250", VA = "0x18364DE50")]
	private static EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> NACFLOBBKFD<TMJoin>(this IOKGLICIDEE CAMFIHKHJNG, DHMFJKHGMGO.HAJAEKFOJEM LOIJJNIFOIJ, EECNAGIPCBM<TMJoin> EGGEHMOJIBL) where TMJoin : DHMFJKHGMGO.DBHEEPLLJDC
	{
		return default(EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x265AAB0", Offset = "0x2659EB0", VA = "0x18265AAB0")]
	public static (EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>) KFAMCADPHCN(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default((EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x265B770", Offset = "0x265AB70", VA = "0x18265B770")]
	public static (EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>) PLFPIEBECAE(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default((EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x265B720", Offset = "0x265AB20", VA = "0x18265B720")]
	public static EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> PIGFBFICKDL(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x265B4C0", Offset = "0x265A8C0", VA = "0x18265B4C0")]
	public static void OEOMIEOCECI(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM> IPLDJACDDHN, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> PNDOFNNPFPO, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>> AOCMICDFJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x364C2A0", Offset = "0x364B6A0", VA = "0x18364C2A0")]
	public static OACDEPNCGLO DDMDOIFLGFK<TDeps, TStateSys>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP) where TDeps : MALMBDEDPDK<TStateSys>
	{
		return default(OACDEPNCGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x364D6A0", Offset = "0x364CAA0", VA = "0x18364D6A0")]
	public static EONIFOKECJE KLHGACFIIDJ<TDeps, TStateSys>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, int FEFGMNOLHFG) where TDeps : MALMBDEDPDK<TStateSys>
	{
		return default(EONIFOKECJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x364D940", Offset = "0x364CD40", VA = "0x18364D940")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>? KOMOBGCEOMB<TDeps, TStateSys>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, [In] ReadOnlySpan<int> MPPBAFLGODB, [In] Span<OIJJGLJMHON> ADHLAEAHAHI) where TDeps : MALMBDEDPDK<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x364D0D0", Offset = "0x364C4D0", VA = "0x18364D0D0")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> IPKBNHKJMHC<TDeps, TStateSys>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF) where TDeps : MALMBDEDPDK<TStateSys>
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2659DA0", Offset = "0x26591A0", VA = "0x182659DA0")]
	public static CONANDLBPOH.FLLMJBDNGJF FKBAAJEAJGI([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH)
	{
		return default(CONANDLBPOH.FLLMJBDNGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x265AF20", Offset = "0x265A320", VA = "0x18265AF20")]
	public static CONANDLBPOH.FDLKBJCCNHN LINOCHONFPF([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH)
	{
		return default(CONANDLBPOH.FDLKBJCCNHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x26597D0", Offset = "0x2658BD0", VA = "0x1826597D0")]
	public static CONANDLBPOH.LLPOCNJDECL DIBKCBEPECC([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH)
	{
		return default(CONANDLBPOH.LLPOCNJDECL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2659F20", Offset = "0x2659320", VA = "0x182659F20")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> GBJPANBHIFE(this IOKGLICIDEE CAMFIHKHJNG, int? NIAOABFOKBG, string MPGDCPPMNJN)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x265B310", Offset = "0x265A710", VA = "0x18265B310")]
	public static CONANDLBPOH.IHIAMFAHJJF NBFILNKJICE([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH)
	{
		return default(CONANDLBPOH.IHIAMFAHJJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26598C0", Offset = "0x2658CC0", VA = "0x1826598C0")]
	public static CONANDLBPOH.PNNIDBEEFAG DNBHAGCPCMN([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH)
	{
		return default(CONANDLBPOH.PNNIDBEEFAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26596B0", Offset = "0x2658AB0", VA = "0x1826596B0")]
	public static int? CLHGEHBGHBJ([In] this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x364E050", Offset = "0x364D450", VA = "0x18364E050")]
	private static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PFOBFKGPHKM<TMJoin>(this IOKGLICIDEE CAMFIHKHJNG, int? NIAOABFOKBG, CONANDLBPOH.PNNIDBEEFAG LOIJJNIFOIJ, EECNAGIPCBM<TMJoin> EGGEHMOJIBL) where TMJoin : CONANDLBPOH.PBNGKJHBHGE
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2659720", Offset = "0x2658B20", VA = "0x182659720")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> DCFKLBPNKLL(this IOKGLICIDEE CAMFIHKHJNG, int? NIAOABFOKBG, EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> KCOMDMNMIFE, int KDCAMOIGIMA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x265AA50", Offset = "0x2659E50", VA = "0x18265AA50")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> KDDCGABAEBO(this IOKGLICIDEE CAMFIHKHJNG, int? NIAOABFOKBG)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x265A370", Offset = "0x2659770", VA = "0x18265A370")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> GPGKDNHHAGE(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? LMBPELCIJME, int? NIAOABFOKBG)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x265A0B0", Offset = "0x26594B0", VA = "0x18265A0B0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> GBLLJADDHHF(this IOKGLICIDEE CAMFIHKHJNG, int? NIAOABFOKBG, int KDCAMOIGIMA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x265AEC0", Offset = "0x265A2C0", VA = "0x18265AEC0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LGEPAPJDGKA(this IOKGLICIDEE CAMFIHKHJNG, int? NIAOABFOKBG)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x265B1D0", Offset = "0x265A5D0", VA = "0x18265B1D0")]
	public static void MAJMMNPOBPD(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH, EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> KCOMDMNMIFE, int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x265B920", Offset = "0x265AD20", VA = "0x18265B920")]
	public static void POOJLEJMDKF(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH, int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2659CD0", Offset = "0x26590D0", VA = "0x182659CD0")]
	public static void FGHHPPMMMNI(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2659E90", Offset = "0x2659290", VA = "0x182659E90")]
	public static void FMFIOONLHFO(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> JMBMDICGCNK, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> EFBBAHHBMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x265B010", Offset = "0x265A410", VA = "0x18265B010")]
	public static void LNCDLMLDPBF(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH, EECNAGIPCBM<AMGCLMOKHAB<IFPJNCFJMEK>> HNFBNHIDOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x364DD80", Offset = "0x364D180", VA = "0x18364DD80")]
	public static void MKBGAHNEFND<M>(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IFHOALLLIAH, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<M>>> HNFBNHIDOFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MALMBDEDPDK<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EECNAGIPCBM<JFJBMCNMGML> MCKEIHELNCA(TStateSys OECCOANCCMM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EECNAGIPCBM<JFJBMCNMGML> KJBBJBOEFMD(TStateSys OECCOANCCMM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EECNAGIPCBM<JFJBMCNMGML> BEOFKDKLEBO(TStateSys OECCOANCCMM);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EECNAGIPCBM<JFJBMCNMGML> BFMOKAPGFKJ(TStateSys OECCOANCCMM);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> OOLOMHOGKAN(TStateSys OECCOANCCMM, IOKGLICIDEE LDEPDFMJLLO, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> PMDCLHKIMKM(TStateSys OECCOANCCMM, IOKGLICIDEE LDEPDFMJLLO, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DDEGFFEKMPM(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EECNAGIPCBM<BPHLKFKIMPM> NKBAJJLBMMG(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP, int DLNGNEBLCOK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HLCHIJBHGDA PJBDMAABICI(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PKECDPJGIOJ(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int FJADNEOHCOM(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GGMLKLKGFPB<byte> ADGKLHJLDNO(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(GGMLKLKGFPB<byte>, EECNAGIPCBM<JFJBMCNMGML>) DBNJHMFILCJ(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FIPEBMBLNFJ(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EECNAGIPCBM<BOBCICDOPCN> BCMHHBFKBOA(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF, int FEFGMNOLHFG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EECNAGIPCBM<BOBCICDOPCN> DFLADKELLLL(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, int FEFGMNOLHFG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int HHHNKMEEMIM(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? KNBFIPLICAK(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, int KDCAMOIGIMA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int JOHKMPIALPM(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? PJBEDMMCCCM(TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, int KDCAMOIGIMA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PECMNDBDPNF
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37DFE50", Offset = "0x37DF250", VA = "0x1837DFE50")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML?> DMBNIJEGCNH<T, TOpInput, TOpOutput>(this IOKGLICIDEE CAMFIHKHJNG, T ONMPMLDKLEL, T CEMDANFAAHB, int HJPIOCMNCCG, IntPtr FECOBDLBHJF)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37E13E0", Offset = "0x37E07E0", VA = "0x1837E13E0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML?> PELMGDOGAED<T, TOpInput, TOpOutput>(this IOKGLICIDEE CAMFIHKHJNG, T ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB, int HJPIOCMNCCG, IntPtr FECOBDLBHJF)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37E0CD0", Offset = "0x37E00D0", VA = "0x1837E0CD0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML?> KOHBBPKPOFP<TOpInput, TOpOutput>(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB, int HJPIOCMNCCG, IntPtr FECOBDLBHJF)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x265FC90", Offset = "0x265F090", VA = "0x18265FC90")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> HEFIKAKPGEP(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x265D940", Offset = "0x265CD40", VA = "0x18265D940")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BBCDKDJNBLC(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x265FF30", Offset = "0x265F330", VA = "0x18265FF30")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ICACOOJOKOK(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x26603D0", Offset = "0x265F7D0", VA = "0x1826603D0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> JGKIJHGIMEK(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x26610D0", Offset = "0x26604D0", VA = "0x1826610D0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> MGNNNKALCHL(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x26626B0", Offset = "0x2661AB0", VA = "0x1826626B0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PPCMKCJLKBL(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2661FB0", Offset = "0x26613B0", VA = "0x182661FB0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PFNKPDMOIML(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x265F8F0", Offset = "0x265ECF0", VA = "0x18265F8F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> GDMIPBGDDGK(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x265FA30", Offset = "0x265EE30", VA = "0x18265FA30")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> GGGNBMIAJEK(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2660D20", Offset = "0x2660120", VA = "0x182660D20")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LEAILCBBHAC(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, int CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x265F110", Offset = "0x265E510", VA = "0x18265F110")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> EJKKJGAELGE(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x265EC50", Offset = "0x265E050", VA = "0x18265EC50")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ECCCNMIPFHC(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x265EB50", Offset = "0x265DF50", VA = "0x18265EB50")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> EAHAHNAOFFK(this IOKGLICIDEE CAMFIHKHJNG, float ONMPMLDKLEL, float CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2660E20", Offset = "0x2660220", VA = "0x182660E20")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LLFMEPEELDC(this IOKGLICIDEE CAMFIHKHJNG, float ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x265ED90", Offset = "0x265E190", VA = "0x18265ED90")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> EDAPAMLABLJ(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x265DD10", Offset = "0x265D110", VA = "0x18265DD10")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CFPPGKNAGLP(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, int CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2660B60", Offset = "0x265FF60", VA = "0x182660B60")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LCCGMPOLNHF(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2661D70", Offset = "0x2661170", VA = "0x182661D70")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMCKFGFKPK(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x265FB70", Offset = "0x265EF70", VA = "0x18265FB70")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> GGKCJHHLGBK(this IOKGLICIDEE CAMFIHKHJNG, float ONMPMLDKLEL, float CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x265DC90", Offset = "0x265D090", VA = "0x18265DC90")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BIJCKJMNGIE(this IOKGLICIDEE CAMFIHKHJNG, float ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26605D0", Offset = "0x265F9D0", VA = "0x1826605D0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> JJNDIENKGCA(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2661A30", Offset = "0x2660E30", VA = "0x182661A30")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> OGBIJCINMKD(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, int CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x265FD90", Offset = "0x265F190", VA = "0x18265FD90")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> HGLBAOMDMBA(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2661F30", Offset = "0x2661330", VA = "0x182661F30")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PCOLOFAOMBM(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26609F0", Offset = "0x265FDF0", VA = "0x1826609F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> KINPDGEOFNF(this IOKGLICIDEE CAMFIHKHJNG, float ONMPMLDKLEL, float CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x265F230", Offset = "0x265E630", VA = "0x18265F230")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> EPECCLCKBNF(this IOKGLICIDEE CAMFIHKHJNG, float ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2662590", Offset = "0x2661990", VA = "0x182662590")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PMALKGBAELJ(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26623E0", Offset = "0x26617E0", VA = "0x1826623E0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> PLDFIAKFBOF(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x265D8C0", Offset = "0x265CCC0", VA = "0x18265D8C0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> AOKLBDCMHDD(this IOKGLICIDEE CAMFIHKHJNG, int FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x265FBF0", Offset = "0x265EFF0", VA = "0x18265FBF0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> HCBBKPBLJHN(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2661540", Offset = "0x2660940", VA = "0x182661540")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> NKJKOALAJAN(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FKAJKCDGEGF)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2661330", Offset = "0x2660730", VA = "0x182661330")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> MIPCFIMFDLL(this IOKGLICIDEE CAMFIHKHJNG, int FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2662610", Offset = "0x2661A10", VA = "0x182662610")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> POJCHMLEDCA(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x265F2B0", Offset = "0x265E6B0", VA = "0x18265F2B0")]
	public static (EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>) FEICNHJPFAK(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CIPOGONPJJK> CNNMGJCDOMP, [In] ReadOnlySpan<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> HGIBOFDMGIA, [In] ReadOnlySpan<int?> NJGBPELDJIP, [In] Span<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> GDLDJPJLHNM)
	{
		return default((EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x265E410", Offset = "0x265D810", VA = "0x18265E410")]
	public static (EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>) DJAJHKCJBJO(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<FGGDFLMIIJC> EGEMIAEJAHH, [In] ReadOnlySpan<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> HGIBOFDMGIA, [In] ReadOnlySpan<int?> NJGBPELDJIP, [In] Span<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> GDLDJPJLHNM)
	{
		return default((EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x37E0820", Offset = "0x37DFC20", VA = "0x1837E0820")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<JFJBMCNMGML>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<TMarker>>, EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>) GLKFDFBJGHL<TMarker>(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<JFJBMCNMGML> PIKKDFAKDKI, [In] ReadOnlySpan<byte> AMHCLKHIFKH)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<JFJBMCNMGML>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<TMarker>>, EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x265DED0", Offset = "0x265D2D0", VA = "0x18265DED0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CKCPICFECKC(this IOKGLICIDEE CAMFIHKHJNG, int PBMDLFOECGG, [Optional] EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2660A70", Offset = "0x265FE70", VA = "0x182660A70")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> KKGIGKNGLNO(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PBMDLFOECGG, [Optional] EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2661820", Offset = "0x2660C20", VA = "0x182661820")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ODHHKGOAJID(this IOKGLICIDEE CAMFIHKHJNG, [In] ReadOnlySpan<byte> PBMDLFOECGG, [Optional] EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2660190", Offset = "0x265F590", VA = "0x182660190")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IOCGOEBKCHH(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PBMDLFOECGG, int EOKAMHLPIFK, [Optional] EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26622E0", Offset = "0x26616E0", VA = "0x1826622E0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PKHPCGOPJFN(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2661910", Offset = "0x2660D10", VA = "0x182661910")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> OFDNAAJFPGJ(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2660770", Offset = "0x265FB70", VA = "0x182660770")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> KEBHOLHLLHG(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x265F6F0", Offset = "0x265EAF0", VA = "0x18265F6F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> FHNFLJBCJOC(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2660070", Offset = "0x265F470", VA = "0x182660070")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIADKFCPACC(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2660BE0", Offset = "0x265FFE0", VA = "0x182660BE0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LDMMAHGHOGG(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x26614C0", Offset = "0x26608C0", VA = "0x1826614C0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> NDOBNNAIFLC(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, int CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2661050", Offset = "0x2660450", VA = "0x182661050")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> MFOIKPBHDIP(this IOKGLICIDEE CAMFIHKHJNG, int ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2661AB0", Offset = "0x2660EB0", VA = "0x182661AB0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> OGIFHENLJIL(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ONMPMLDKLEL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CEMDANFAAHB)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x265F7F0", Offset = "0x265EBF0", VA = "0x18265F7F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> FIJCOIADIME(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x26616F0", Offset = "0x2660AF0", VA = "0x1826616F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> NKKFOIGKCNK(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2661DF0", Offset = "0x26611F0", VA = "0x182661DF0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PALGIBNIJMJ(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x26620B0", Offset = "0x26614B0", VA = "0x1826620B0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PHDAKOAEJDF(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x265D660", Offset = "0x265CA60", VA = "0x18265D660")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AJLGBFILHKB(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x265EFD0", Offset = "0x265E3D0", VA = "0x18265EFD0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> EHECCPKOPIE(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x265FA10", Offset = "0x265EE10", VA = "0x18265FA10")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>> GECLHDOOIBP(this IOKGLICIDEE CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x265EED0", Offset = "0x265E2D0", VA = "0x18265EED0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> EHCDFHOHEPN(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x265D540", Offset = "0x265C940", VA = "0x18265D540")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AEKOJPMCKNM(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x265D780", Offset = "0x265CB80", VA = "0x18265D780")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> ANIGOJIFGCE(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x26613C0", Offset = "0x26607C0", VA = "0x1826613C0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> NDIILGOACJK(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2660650", Offset = "0x265FA50", VA = "0x182660650")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> JMPKEIOEGBD(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x26611F0", Offset = "0x26605F0", VA = "0x1826611F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> MGPBDONJFKE(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x26604D0", Offset = "0x265F8D0", VA = "0x1826604D0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> JJMMADAHFFP(this IOKGLICIDEE CAMFIHKHJNG, int FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x265DA60", Offset = "0x265CE60", VA = "0x18265DA60")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BDONOBIAMNA(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x26613B0", Offset = "0x26607B0", VA = "0x1826613B0")]
	public static void MLCEMAFPLGB(this IOKGLICIDEE CAMFIHKHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2661B30", Offset = "0x2660F30", VA = "0x182661B30")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> OIFJOGDPGPI(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x26602B0", Offset = "0x265F6B0", VA = "0x1826602B0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IPEHHKALOFK(this IOKGLICIDEE CAMFIHKHJNG, float AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2661C30", Offset = "0x2661030", VA = "0x182661C30")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> OMJFCONGJCF(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2660F50", Offset = "0x2660350", VA = "0x182660F50")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> MCHDEIGNAGL(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x265FE10", Offset = "0x265F210", VA = "0x18265FE10")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> HOIBCPJNBHH(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x265DD90", Offset = "0x265D190", VA = "0x18265DD90")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CKCCIJCJEKB(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x265E090", Offset = "0x265D490", VA = "0x18265E090")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> DGKMMGINIDL(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> GJCJKCGAJNN, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FCHOGDLDOIN)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x265DF90", Offset = "0x265D390", VA = "0x18265DF90")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> DDELLEHDDAK(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x265DB70", Offset = "0x265CF70", VA = "0x18265DB70")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BGNBKOPKOCL(this IOKGLICIDEE CAMFIHKHJNG, int AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26608B0", Offset = "0x265FCB0", VA = "0x1826608B0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> KEPCBKBBOBI(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> AKAPFCIGAAM, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BPDIMNMHBCA)
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x37E0E40", Offset = "0x37E0240", VA = "0x1837E0E40")]
	public static void KOJDKJJDCLN<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<CIPOGONPJJK> CNNMGJCDOMP, [In] ReadOnlySpan<EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>> JNGDIFCHCCA, [In] ReadOnlySpan<int?> NJGBPELDJIP, [In] Span<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> GDLDJPJLHNM, [In] Span<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> CMLIIOPNCPE, [In] ReadOnlySpan<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>?> CNDMBHODFAK) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x37DF450", Offset = "0x37DE850", VA = "0x1837DF450")]
	public static void DBCKAHKAPNM<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<FGGDFLMIIJC> HGCIPPLBBMM, [In] ReadOnlySpan<EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>> JNJIIIKDNMG, [In] ReadOnlySpan<int?> NJGBPELDJIP, [In] Span<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> GDLDJPJLHNM, [In] Span<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>> CMLIIOPNCPE, [In] ReadOnlySpan<EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>?> CNDMBHODFAK) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x37DF270", Offset = "0x37DE670", VA = "0x1837DF270")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> CHLEEGBCNAJ<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> LMBPELCIJME, [Optional] EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x37DF9F0", Offset = "0x37DEDF0", VA = "0x1837DF9F0")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> DGBCKBAJMFO<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> LLPFAJGBDDM, [Optional] EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x37E0150", Offset = "0x37DF550", VA = "0x1837E0150")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> DNGMCIKBFAI<TDeps, TStateSys>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM) where TDeps : notnull, MALMBDEDPDK<TStateSys> where TStateSys : notnull
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x37E0380", Offset = "0x37DF780", VA = "0x1837E0380")]
	public static EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA> FBNHHBPIPPI<TDeps, TStateSys>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM) where TDeps : notnull, MALMBDEDPDK<TStateSys> where TStateSys : notnull
	{
		return default(EECNAGIPCBM<IGEMNCMFBBG.PPBAFGOLANA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x26621B0", Offset = "0x26615B0", VA = "0x1826621B0")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> PKBFJCBKICJ(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> BAAINEHOJIL, IntPtr LJEPIBDEEPM, IntPtr BJAEGOFKIIH)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x265E850", Offset = "0x265DC50", VA = "0x18265E850")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> DKNAAHGDEJP(this IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> GLMMEOPBLEG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FCLACNBLJKA, IntPtr CLADEBCMDMD, IntPtr NNLAAGPNEAJ, IntPtr IIOAMJOAILC, bool GGJAHHPAAMF)
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x37E1780", Offset = "0x37E0B80", VA = "0x1837E1780")]
	public static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> PFHGNHLNNOP<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<CIPOGONPJJK> HOJPDDJCIPD, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> GLMMEOPBLEG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FCLACNBLJKA, int? MBBBKADINGK, [Optional] IntPtr JMDPBPHNHMM) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x37E1990", Offset = "0x37E0D90", VA = "0x1837E1990")]
	private static EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> PFHGNHLNNOP<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<CIPOGONPJJK> HOJPDDJCIPD, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> GLMMEOPBLEG, EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF> FCLACNBLJKA, int? MBBBKADINGK) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
		return default(EECNAGIPCBM<PJPDHMOOMGC.DMPLDGKPELF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x37E0920", Offset = "0x37DFD20", VA = "0x1837E0920")]
	public static EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IMHLDCOJPIC<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> PBMDLFOECGG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>? JAPINDHIFOD) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
		return default(EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x37E0590", Offset = "0x37DF990", VA = "0x1837E0590")]
	public static void FNDGLKMDLLI<TDeps, TState>(this IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TState FBOKGPFKJCL, int HHNEPEBBIEN) where TDeps : notnull, MALMBDEDPDK<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BJJLIELOGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> CCOKHCBCPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> GMIGKIJIAHE;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
	public BJJLIELOGAP(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> GJOKKCJJLFJ, EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> FPEMMKJJKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x26579F0", Offset = "0x2656DF0", VA = "0x1826579F0")]
	public static BJJLIELOGAP AFLKMMODJAC(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> GJOKKCJJLFJ)
	{
		return default(BJJLIELOGAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CONANDLBPOH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DEKNHCMLIBB : PBNGKJHBHGE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FLLMJBDNGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> GEJNEPPODMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int BNBIOAJGDHO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		public FLLMJBDNGJF(EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> KCOMDMNMIFE, int KDCAMOIGIMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class OLIPLLJHMNM : PBNGKJHBHGE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct FDLKBJCCNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BNBIOAJGDHO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public FDLKBJCCNHN(int KDCAMOIGIMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class PEECGHDPFKO : PBNGKJHBHGE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct LLPOCNJDECL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> GEJNEPPODMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int BNBIOAJGDHO;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		public LLPOCNJDECL(EECNAGIPCBM<DHMFJKHGMGO.LMPEOAGOEEL> KCOMDMNMIFE, int KDCAMOIGIMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum PNNIDBEEFAG
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
	public sealed class OEFMFICFDML
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class PBNGKJHBHGE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct MIKGCGHIGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? CIIKELIBPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BJJLIELOGAP FFMHCHMELNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PNNIDBEEFAG BLIBCCCHBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EECNAGIPCBM<PBNGKJHBHGE> ILEBBDCEKFG;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x265D1D0", Offset = "0x265C5D0", VA = "0x18265D1D0")]
		public MIKGCGHIGNJ(int? NIAOABFOKBG, [In] BJJLIELOGAP AILDABHPONA, PNNIDBEEFAG LOIJJNIFOIJ, EECNAGIPCBM<PBNGKJHBHGE> EGGEHMOJIBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class KBNBDDEJBGH : PBNGKJHBHGE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IHIAMFAHJJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int BNBIOAJGDHO;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public IHIAMFAHJJF(int KDCAMOIGIMA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal HLBIMBKEHMM<OEFMFICFDML, MIKGCGHIGNJ> GBBBIPLHAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal HLBIMBKEHMM<DEKNHCMLIBB, FLLMJBDNGJF> CCKECFJAPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal HLBIMBKEHMM<PEECGHDPFKO, LLPOCNJDECL> LCPPCPCMJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal HLBIMBKEHMM<KBNBDDEJBGH, IHIAMFAHJJF> DFHCGEEJFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal HLBIMBKEHMM<OLIPLLJHMNM, FDLKBJCCNHN> GNLKIICFEBC;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2657E10", Offset = "0x2657210", VA = "0x182657E10")]
	private CONANDLBPOH([In] HLBIMBKEHMM<OEFMFICFDML, MIKGCGHIGNJ> KOPDNBDNPHO, [In] HLBIMBKEHMM<DEKNHCMLIBB, FLLMJBDNGJF> NGNFKHIEANL, [In] HLBIMBKEHMM<PEECGHDPFKO, LLPOCNJDECL> DNJEAHKOGHA, [In] HLBIMBKEHMM<KBNBDDEJBGH, IHIAMFAHJJF> FJBDAAHLNGA, [In] HLBIMBKEHMM<OLIPLLJHMNM, FDLKBJCCNHN> EDHHLGGJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2657C20", Offset = "0x2657020", VA = "0x182657C20")]
	public static CONANDLBPOH AFLKMMODJAC()
	{
		return default(CONANDLBPOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NBAKLMHLICL
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x265D250", Offset = "0x265C650", VA = "0x18265D250")]
	public static void DPGGICHIMDD(this CONANDLBPOH CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GIGJDDPJJAP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2658F50", Offset = "0x2658350", VA = "0x182658F50")]
	public static void CAFDDKMELKN(IOKGLICIDEE CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EFIGFLMDEKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, HCAAKLNHGPM> CLBIOJINCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int FLPEJLJMHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int JGABLANGNMP;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x26588E0", Offset = "0x2657CE0", VA = "0x1826588E0")]
	private EFIGFLMDEKG([In] CCCBKFAHMKF<DHMFJKHGMGO.HBGEKKIHFCM, HCAAKLNHGPM> ONDNNPCGOIM, int BACILCFGAON, int KPILDMLKAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2658680", Offset = "0x2657A80", VA = "0x182658680")]
	public static EFIGFLMDEKG AFLKMMODJAC()
	{
		return default(EFIGFLMDEKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x26586F0", Offset = "0x2657AF0", VA = "0x1826586F0")]
	public void DPGGICHIMDD([In] IOKGLICIDEE BGMFHIEECKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x343A770", Offset = "0x3439B70", VA = "0x18343A770")]
	public static void CAFDDKMELKN<TDeps, TStateSys>(IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO) where TDeps : notnull, MALMBDEDPDK<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HDIOPOBFKCL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2659200", Offset = "0x2658600", VA = "0x182659200")]
	public static void CAFDDKMELKN(IOKGLICIDEE CAMFIHKHJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KKCGLIHIMNA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface ENNLIJGJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MIPNBIKPHHA(EPPNKNJKIOI<byte> HALFFKHDADM, int CGDLCOMIHOM);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct EMNBNOIBPGG : ENNLIJGJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2658920", Offset = "0x2657D20", VA = "0x182658920", Slot = "4")]
		public void MIPNBIKPHHA(EPPNKNJKIOI<byte> HALFFKHDADM, int CGDLCOMIHOM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct LOGPIANCANN : ENNLIJGJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x265D120", Offset = "0x265C520", VA = "0x18265D120", Slot = "4")]
		public void MIPNBIKPHHA(EPPNKNJKIOI<byte> HALFFKHDADM, int CGDLCOMIHOM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct AJOBDKBIAMH : ENNLIJGJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2656E50", Offset = "0x2656250", VA = "0x182656E50", Slot = "4")]
		public void MIPNBIKPHHA(EPPNKNJKIOI<byte> HALFFKHDADM, int CGDLCOMIHOM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct FMBLEHKDIEO : ENNLIJGJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2658EA0", Offset = "0x26582A0", VA = "0x182658EA0", Slot = "4")]
		public void MIPNBIKPHHA(EPPNKNJKIOI<byte> HALFFKHDADM, int CGDLCOMIHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class PHODPOOHFGG<TCallProcessorDeps> where TCallProcessorDeps : struct, ENNLIJGJPAP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps EGDADDGFBOH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2910", Offset = "0x3BB1D10", VA = "0x183BB2910")]
		public static int CAFDDKMELKN<TDeps, TStateSys>(TDeps EIHGNKDHDGF, TStateSys FBOKGPFKJCL, IOKGLICIDEE BGMFHIEECKK, [In] EPPNKNJKIOI<byte> IOIFOMCJIME, int BCDCNENCNNI) where TDeps : MALMBDEDPDK<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private EPPNKNJKIOI<NLLHCEKBIKK> GHKOIOEFFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>> DENCKJBNJMP;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x265CEF0", Offset = "0x265C2F0", VA = "0x18265CEF0")]
	private KKCGLIHIMNA([In] EPPNKNJKIOI<NLLHCEKBIKK> BMPJCPPCPLA, Dictionary<EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<DHMFJKHGMGO.HBGEKKIHFCM>> EMFIHHMJDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x265CDF0", Offset = "0x265C1F0", VA = "0x18265CDF0")]
	public static KKCGLIHIMNA AFLKMMODJAC()
	{
		return default(KKCGLIHIMNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x265CEB0", Offset = "0x265C2B0", VA = "0x18265CEB0")]
	public void DPGGICHIMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x36B1170", Offset = "0x36B0570", VA = "0x1836B1170")]
	public static void CAFDDKMELKN<TDeps, TStateSys>(IOKGLICIDEE CAMFIHKHJNG, TDeps EIHGNKDHDGF, TStateSys OECCOANCCMM) where TDeps : MALMBDEDPDK<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BHPLBFCBDKH
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct FKLCLIJGMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> BLMLJNCEFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int AKCEIFNMHPB;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int EFDFIBDHIML;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int MEBLIOGCOLO;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2656EE0", Offset = "0x26562E0", VA = "0x182656EE0")]
	public static void CAFDDKMELKN(IOKGLICIDEE CAMFIHKHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x26576E0", Offset = "0x2656AE0", VA = "0x1826576E0")]
	private static void IBKGCMGJCAI([In] IOKGLICIDEE CAMFIHKHJNG, EECNAGIPCBM<CONANDLBPOH.OEFMFICFDML> IIKCEJDFBDH, EPPNKNJKIOI<byte> NEENOACLHCI, List<FKLCLIJGMIJ> ACOGKJNBEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26575A0", Offset = "0x26569A0", VA = "0x1826575A0")]
	private static void IBKGCMGJCAI(EPPNKNJKIOI<byte> NEENOACLHCI, int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2657870", Offset = "0x2656C70", VA = "0x182657870")]
	private static void JBNLDEIBFJE(IOKGLICIDEE CAMFIHKHJNG, List<FKLCLIJGMIJ> ACOGKJNBEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MGFDGGEBCHK<TDeps, TIndex, TValues> where TDeps : struct, JFONNPICNHC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps EGDADDGFBOH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4F8A060", Offset = "0x4F89460", VA = "0x184F8A060")]
	public static void CAFDDKMELKN([In] EPPNKNJKIOI<NLLHCEKBIKK> BMPJCPPCPLA, int GNINAHMNGMN, TValues EDJBENPLFOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JFONNPICNHC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPPNKNJKIOI<TIndex> HCNCBFGMAMK(int GNINAHMNGMN, [In] TValues EDJBENPLFOA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(TIndex KDCAMOIGIMA, [In] TValues EDJBENPLFOA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOPKFBOGOLC(TIndex KDCAMOIGIMA, TValues EDJBENPLFOA, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NCEAOIMCKHD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex AAADANHJMBK(int KDCAMOIGIMA);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHDFDADGCDP(TIndex KDCAMOIGIMA, [In] TValues EDJBENPLFOA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> JLLCEBHFKHG(TIndex KDCAMOIGIMA, [In] TValues EDJBENPLFOA);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AEPBBOCLPCA<TDeps, TIndex, TValues> where TDeps : struct, NCEAOIMCKHD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps EGDADDGFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x48D8610", Offset = "0x48D7A10", VA = "0x1848D8610")]
	public static EPPNKNJKIOI<TIndex> CAFDDKMELKN(int GNINAHMNGMN, [In] TValues EDJBENPLFOA)
	{
		return default(EPPNKNJKIOI<TIndex>);
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

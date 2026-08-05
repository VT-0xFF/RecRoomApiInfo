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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A97FC0", Offset = "0x2A973C0", VA = "0x182A97FC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct MNHJJAKPIHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> KIABMHODHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int JDOCBDPHMKD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
	public MNHJJAKPIHP(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> JCAANBHEGJH, int FDIDNNCIDHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HAGEPAEDCPI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class CPJKIEMBGLF : JMFEJNKDAPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct DPACMFBOHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly NGBIHHKOKHH<byte> HDPPPCEMLBF;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C8F0", Offset = "0x2A2BCF0", VA = "0x182A2C8F0")]
		public DPACMFBOHMN(NGBIHHKOKHH<byte> FGHKEPJEKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DB0", Offset = "0x2A901B0", VA = "0x182A90DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class MNJCBFNNNHH : JMFEJNKDAPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct EEKMABNJNEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> FHMCADNAMDA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public EEKMABNJNEI(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> OHNELIKLKNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum MEDDLBDECNK
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
	public sealed class FNKCIADPENA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class JMFEJNKDAPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FHOALHOPHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly MEDDLBDECNK HOOGMKCONIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly JGDCCHDHIKG<JMFEJNKDAPF> AGIOLIEFOGE;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		public FHOALHOPHNK(MEDDLBDECNK OJMMNEBDONA, JGDCCHDHIKG<JMFEJNKDAPF> ABNFADBAGOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class GEGLDAMJJNO : JMFEJNKDAPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct LLLLHLLDMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EDAPDEAIGPK;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public LLLLHLLDMGF(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class JMCLMHPBDEE : JMFEJNKDAPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JAGMJGDLGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly OKGEIGJJJJK DFDILLOJKMO;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public JAGMJGDLGGO(OKGEIGJJJJK HAMHHLNEILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A92310", Offset = "0x2A91710", VA = "0x182A92310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DEPMAGCIBML<FNKCIADPENA, FHOALHOPHNK> JGHHJDMPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal DEPMAGCIBML<CPJKIEMBGLF, DPACMFBOHMN> FDGPFHACLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal DEPMAGCIBML<MNJCBFNNNHH, EEKMABNJNEI> FFOKAGJLCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DEPMAGCIBML<GEGLDAMJJNO, LLLLHLLDMGF> ICAMJAHBBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal DEPMAGCIBML<JMCLMHPBDEE, JAGMJGDLGGO> LGFIENLBPOD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A91E30", Offset = "0x2A91230", VA = "0x182A91E30")]
	private HAGEPAEDCPI([In] DEPMAGCIBML<FNKCIADPENA, FHOALHOPHNK> IEOJJHOFHLO, [In] DEPMAGCIBML<CPJKIEMBGLF, DPACMFBOHMN> INEENIHNPFP, [In] DEPMAGCIBML<MNJCBFNNNHH, EEKMABNJNEI> FCNPAJAPCDB, [In] DEPMAGCIBML<GEGLDAMJJNO, LLLLHLLDMGF> CFNBOOOMIEH, [In] DEPMAGCIBML<JMCLMHPBDEE, JAGMJGDLGGO> NCBEACCHAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A91CF0", Offset = "0x2A910F0", VA = "0x182A91CF0")]
	public static HAGEPAEDCPI EJOLKNBPCJB()
	{
		return default(HAGEPAEDCPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DCGLPANIDBH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A90A80", Offset = "0x2A8FE80", VA = "0x182A90A80")]
	public static void ONLDIMNIKII(this HAGEPAEDCPI DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KELHLFBMNPK
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
public struct BLKNBCNGEGI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class GGCGJJPCEGI : DBNKPNKJMAK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct EPBDPNPEDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> CGOGPDFEADH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public EPBDPNPEDBA(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> KGFJICNCMDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum NNPPFJNEJLF
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
	public sealed class DBOKPIKPBBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class DBNKPNKJMAK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct DILBOCNNCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly NNPPFJNEJLF HOOGMKCONIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly JGDCCHDHIKG<DBNKPNKJMAK> AGIOLIEFOGE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		public DILBOCNNCPC(NNPPFJNEJLF OJMMNEBDONA, JGDCCHDHIKG<DBNKPNKJMAK> ABNFADBAGOM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal DEPMAGCIBML<DBOKPIKPBBB, DILBOCNNCPC> JGHHJDMPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DEPMAGCIBML<GGCGJJPCEGI, EPBDPNPEDBA> CJLCGGNFFMB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E0C0", Offset = "0x2A8D4C0", VA = "0x182A8E0C0")]
	private BLKNBCNGEGI([In] DEPMAGCIBML<DBOKPIKPBBB, DILBOCNNCPC> IEOJJHOFHLO, [In] DEPMAGCIBML<GGCGJJPCEGI, EPBDPNPEDBA> NBILDINALEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E030", Offset = "0x2A8D430", VA = "0x182A8E030")]
	public static BLKNBCNGEGI EJOLKNBPCJB()
	{
		return default(BLKNBCNGEGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PGEDEHEOBMD
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A98E60", Offset = "0x2A98260", VA = "0x182A98E60")]
	public static void ONLDIMNIKII(this BLKNBCNGEGI DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OOALEMPJJEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public JAEBKFJJIPK<int> PNKMGDONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public JAEBKFJJIPK<int> DCEBDDKADOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PCLLCCOGIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int JHOJKKCJCOL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A98D80", Offset = "0x2A98180", VA = "0x182A98D80")]
	private OOALEMPJJEK([In] JAEBKFJJIPK<int> JKDFBLDBLBK, [In] JAEBKFJJIPK<int> FGBCMLAAFCI, int NNJEILHLMFG, int JDDPIEFOCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A98CE0", Offset = "0x2A980E0", VA = "0x182A98CE0")]
	public static OOALEMPJJEK EJOLKNBPCJB()
	{
		return default(OOALEMPJJEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CBAKFGFJMCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E100", Offset = "0x2A8D500", VA = "0x182A8E100")]
	public static void ONLDIMNIKII(this OOALEMPJJEK DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ILGCHJAGDPO
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum CFPMKCKPOAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class GBDOHAELIIK : ONNACDKNNNI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct GOFDMHLFIGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly JGDCCHDHIKG<BOHFDFELHLP> EDMIALHPILO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public GOFDMHLFIGI(JGDCCHDHIKG<BOHFDFELHLP> EDIGMEPMFBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class DEJOJPHDJIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ONNACDKNNNI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct OAEFHMAACCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly CFPMKCKPOAE HOOGMKCONIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly JGDCCHDHIKG<ONNACDKNNNI> AGIOLIEFOGE;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		private OAEFHMAACCG(CFPMKCKPOAE OJMMNEBDONA, JGDCCHDHIKG<ONNACDKNNNI> ABNFADBAGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A98040", Offset = "0x2A97440", VA = "0x182A98040")]
		public static OAEFHMAACCG EJOLKNBPCJB(CFPMKCKPOAE OJMMNEBDONA, JGDCCHDHIKG<ONNACDKNNNI> ABNFADBAGOM)
		{
			return default(OAEFHMAACCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class AODNOPAEDLE : ONNACDKNNNI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct ACOAECJJEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly JGDCCHDHIKG<BOHFDFELHLP> EDMIALHPILO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public ACOAECJJEAB(JGDCCHDHIKG<BOHFDFELHLP> EDIGMEPMFBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BOHFDFELHLP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NJBGEFCAJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JAEBKFJJIPK<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> HFGKOCCMEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JAEBKFJJIPK<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> OJNIBBELABL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E0C0", Offset = "0x2A8D4C0", VA = "0x182A8E0C0")]
		private NJBGEFCAJKF([In] JAEBKFJJIPK<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> NODDCIHHMPD, [In] JAEBKFJJIPK<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> JJLJIAFNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A97DE0", Offset = "0x2A971E0", VA = "0x182A97DE0")]
		public static NJBGEFCAJKF EJOLKNBPCJB()
		{
			return default(NJBGEFCAJKF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal DEPMAGCIBML<DEJOJPHDJIN, OAEFHMAACCG> JGHHJDMPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal DEPMAGCIBML<AODNOPAEDLE, ACOAECJJEAB> NOHDJMGIBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DEPMAGCIBML<GBDOHAELIIK, GOFDMHLFIGI> AFILFFAFFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal JAEBKFJJIPK<(JGDCCHDHIKG<DEJOJPHDJIN> CallId, JGDCCHDHIKG<BOHFDFELHLP> IOId)> BCDDDBMAIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DEPMAGCIBML<BOHFDFELHLP, NJBGEFCAJKF> DHKLNCPHHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal NHGMKBGLCBA<BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> JDBMJKHJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal NHGMKBGLCBA<BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> MFBFIKODGPL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A92250", Offset = "0x2A91650", VA = "0x182A92250")]
	private ILGCHJAGDPO([In] DEPMAGCIBML<DEJOJPHDJIN, OAEFHMAACCG> IEOJJHOFHLO, [In] DEPMAGCIBML<AODNOPAEDLE, ACOAECJJEAB> GCLHDNABHDL, [In] DEPMAGCIBML<GBDOHAELIIK, GOFDMHLFIGI> AMINKBJBNJK, [In] JAEBKFJJIPK<(JGDCCHDHIKG<DEJOJPHDJIN> CallId, JGDCCHDHIKG<BOHFDFELHLP> IOId)> BIGMNFBBIMO, [In] DEPMAGCIBML<BOHFDFELHLP, NJBGEFCAJKF> MPBHPKIGJGP, [In] NHGMKBGLCBA<BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> OHDOEKHHJMG, [In] NHGMKBGLCBA<BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> OCAHCBKDPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A920B0", Offset = "0x2A914B0", VA = "0x182A920B0")]
	public static ILGCHJAGDPO EJOLKNBPCJB()
	{
		return default(ILGCHJAGDPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MIDBKODCIKC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2A97D80", Offset = "0x2A97180", VA = "0x182A97D80")]
	private static void ONLDIMNIKII(this ILGCHJAGDPO.NJBGEFCAJKF DMFKPMONDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A97B70", Offset = "0x2A96F70", VA = "0x182A97B70")]
	public static void ONLDIMNIKII(this ILGCHJAGDPO DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FLHJJLFPHNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JAEBKFJJIPK<byte> FAEBNFHJIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal ILGCHJAGDPO LIHDLDKFGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CJGOKJPEKOH LKNKGIEEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> IFPOGOLDBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal HAGEPAEDCPI OCGLFBOJIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal BLKNBCNGEGI GFFLPOACDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal NHGMKBGLCBA<AGHHHMBIGJH, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>?> NFHPJOIAPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal JAEBKFJJIPK<JGDCCHDHIKG<AGHHHMBIGJH>> DMBHOAPEHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> HLKDADFOENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> AJIEHCLMBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> KIEOKONDOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal DFPPJEJFOBP EBPMJEOAJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal HJPBPCBBCJB CJEEPGNJHAH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A91850", Offset = "0x2A90C50", VA = "0x182A91850")]
	private FLHJJLFPHNI([In] JAEBKFJJIPK<byte> ODIIOEFHEAM, [In] ILGCHJAGDPO BFJEAMLICMC, [In] CJGOKJPEKOH KLAMMNKEPKF, [In] HAGEPAEDCPI KAPGALEAHKO, [In] BLKNBCNGEGI LONLPEIIPEA, [In] NHGMKBGLCBA<AGHHHMBIGJH, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>?> LBFEGEMADHE, [In] JAEBKFJJIPK<JGDCCHDHIKG<AGHHHMBIGJH>> IBNHDMCHOHM, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> CLBOJNMHPCP, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> DGHDFDOIJCB, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> ACNHHIBHJOG, [In] DFPPJEJFOBP ICHEIPBIFPC, [In] HJPBPCBBCJB BFGBFHHFAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A90EA0", Offset = "0x2A902A0", VA = "0x182A90EA0")]
	public static FLHJJLFPHNI EJOLKNBPCJB()
	{
		return default(FLHJJLFPHNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CNFKKJMNGBO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct PKKOGFAACFG : IGMPJFJJDAI<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>, NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A98EC0", Offset = "0x2A982C0", VA = "0x182A98EC0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A98F40", Offset = "0x2A98340", VA = "0x182A98F40", Slot = "4")]
		public JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> DEFIPBBNEBB(int NOEININIMIL)
		{
			return default(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		public bool KAMKKHLLJEL(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "5")]
		private bool AINCDNLCGLJ(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2A98EC0", Offset = "0x2A982C0", VA = "0x182A98EC0", Slot = "6")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> AOLLLKJEDGH(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct BBPIIHKFKBE : JIAIIJIJLEB<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>, NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAB0", Offset = "0x2A8CEB0", VA = "0x182A8DAB0")]
		public JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>> JPMIGGHMDHI(int DKAGNKJNKMF, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA30", Offset = "0x2A8CE30", VA = "0x182A8DA30")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DB20", Offset = "0x2A8CF20", VA = "0x182A8DB20", Slot = "6")]
		public void MPOCIDANMGP(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAB0", Offset = "0x2A8CEB0", VA = "0x182A8DAB0", Slot = "4")]
		private JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>> NLBCEPBNCHJ(int DKAGNKJNKMF, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA30", Offset = "0x2A8CE30", VA = "0x182A8DA30", Slot = "5")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> MEFFOBHHFKE(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct HBDBJNKLGIG : IGMPJFJJDAI<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>, NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A91EC0", Offset = "0x2A912C0", VA = "0x182A91EC0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A91F40", Offset = "0x2A91340", VA = "0x182A91F40", Slot = "4")]
		public JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> DEFIPBBNEBB(int NOEININIMIL)
		{
			return default(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		public bool KAMKKHLLJEL(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "5")]
		private bool PPOMOEMECME(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2A91EC0", Offset = "0x2A912C0", VA = "0x182A91EC0", Slot = "6")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> AGFGGGKEFKD(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct KKIACFKBBKA : JIAIIJIJLEB<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>, NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A92450", Offset = "0x2A91850", VA = "0x182A92450")]
		public JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>> JPMIGGHMDHI(int DKAGNKJNKMF, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A923D0", Offset = "0x2A917D0", VA = "0x182A923D0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A924C0", Offset = "0x2A918C0", VA = "0x182A924C0", Slot = "6")]
		public void MPOCIDANMGP(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92450", Offset = "0x2A91850", VA = "0x182A92450", Slot = "4")]
		private JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>> MFPCLBHFBDP(int DKAGNKJNKMF, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A923D0", Offset = "0x2A917D0", VA = "0x182A923D0", Slot = "5")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> OIIFOLFJKCH(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> NOEININIMIL, [In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GFHLJOILLKN : IGMPJFJJDAI<JGDCCHDHIKG<KJEBJIOBLPE>, NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A91BC0", Offset = "0x2A90FC0", VA = "0x182A91BC0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2A91C60", Offset = "0x2A91060", VA = "0x182A91C60", Slot = "4")]
		public JGDCCHDHIKG<KJEBJIOBLPE> DEFIPBBNEBB(int NOEININIMIL)
		{
			return default(JGDCCHDHIKG<KJEBJIOBLPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A91C90", Offset = "0x2A91090", VA = "0x182A91C90")]
		public bool KAMKKHLLJEL(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2A91C90", Offset = "0x2A91090", VA = "0x182A91C90", Slot = "5")]
		private bool MAGPJINHACE(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A91BB0", Offset = "0x2A90FB0", VA = "0x182A91BB0", Slot = "6")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> BBIHMBIOBDH(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct LCHJIPFIDMO : JIAIIJIJLEB<JGDCCHDHIKG<KJEBJIOBLPE>, NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2A92680", Offset = "0x2A91A80", VA = "0x182A92680")]
		public JAEBKFJJIPK<JGDCCHDHIKG<KJEBJIOBLPE>> JPMIGGHMDHI(int DKAGNKJNKMF, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<JGDCCHDHIKG<KJEBJIOBLPE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A925E0", Offset = "0x2A919E0", VA = "0x182A925E0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A926F0", Offset = "0x2A91AF0", VA = "0x182A926F0", Slot = "6")]
		public void MPOCIDANMGP(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2A92680", Offset = "0x2A91A80", VA = "0x182A92680", Slot = "4")]
		private JAEBKFJJIPK<JGDCCHDHIKG<KJEBJIOBLPE>> NKDJJHDIEOL(int DKAGNKJNKMF, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<JGDCCHDHIKG<KJEBJIOBLPE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2A927A0", Offset = "0x2A91BA0", VA = "0x182A927A0", Slot = "5")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> NKMJGAPCHBG(JGDCCHDHIKG<KJEBJIOBLPE> NOEININIMIL, [In] NHGMKBGLCBA<KJEBJIOBLPE, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>?> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct OFBDJFADGKP : IGMPJFJJDAI<int, JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2A98AA0", Offset = "0x2A97EA0", VA = "0x182A98AA0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB69C40", Offset = "0xB69040", VA = "0x180B69C40", Slot = "4")]
		public int DEFIPBBNEBB(int NOEININIMIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		public bool KAMKKHLLJEL(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "5")]
		private bool CGFMDIPKFFC(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2A98B20", Offset = "0x2A97F20", VA = "0x182A98B20", Slot = "6")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> NLOJBEPJLIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct CGMNGBIJLBG : JIAIIJIJLEB<int, JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E1D0", Offset = "0x2A8D5D0", VA = "0x182A8E1D0")]
		public JAEBKFJJIPK<int> JPMIGGHMDHI(int DKAGNKJNKMF, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E150", Offset = "0x2A8D550", VA = "0x182A8E150")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E240", Offset = "0x2A8D640", VA = "0x182A8E240", Slot = "6")]
		public void MPOCIDANMGP(int NOEININIMIL, JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E1D0", Offset = "0x2A8D5D0", VA = "0x182A8E1D0", Slot = "4")]
		private JAEBKFJJIPK<int> LCMMDPEOIME(int DKAGNKJNKMF, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E330", Offset = "0x2A8D730", VA = "0x182A8E330", Slot = "5")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> OFLDBCLNEBP(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> VariableId, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FJJLGBAEDPD>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct AEPFECEMMOI : IGMPJFJJDAI<int, JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D980", Offset = "0x2A8CD80", VA = "0x182A8D980")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB69C40", Offset = "0xB69040", VA = "0x180B69C40", Slot = "4")]
		public int DEFIPBBNEBB(int NOEININIMIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		public bool KAMKKHLLJEL(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "5")]
		private bool POAACNNFLEO(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D980", Offset = "0x2A8CD80", VA = "0x182A8D980", Slot = "6")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> LCLAPOKKBJI(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct BCJODJPPACK : JIAIIJIJLEB<int, JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DC30", Offset = "0x2A8D030", VA = "0x182A8DC30")]
		public JAEBKFJJIPK<int> JPMIGGHMDHI(int DKAGNKJNKMF, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DBB0", Offset = "0x2A8CFB0", VA = "0x182A8DBB0")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DCA0", Offset = "0x2A8D0A0", VA = "0x182A8DCA0", Slot = "6")]
		public void MPOCIDANMGP(int NOEININIMIL, JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DC30", Offset = "0x2A8D030", VA = "0x182A8DC30", Slot = "4")]
		private JAEBKFJJIPK<int> FMHBKMHNAPC(int DKAGNKJNKMF, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DBB0", Offset = "0x2A8CFB0", VA = "0x182A8DBB0", Slot = "5")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> BKAEILICLOL(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct LBGJBIEPFMA : IGMPJFJJDAI<int, JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92550", Offset = "0x2A91950", VA = "0x182A92550")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB69C40", Offset = "0xB69040", VA = "0x180B69C40", Slot = "4")]
		public int DEFIPBBNEBB(int NOEININIMIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		public bool KAMKKHLLJEL(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "5")]
		private bool POAACNNFLEO(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2A925D0", Offset = "0x2A919D0", VA = "0x182A925D0", Slot = "6")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> LCLAPOKKBJI(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct BJMICLGMMBK : JIAIIJIJLEB<int, JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DED0", Offset = "0x2A8D2D0", VA = "0x182A8DED0")]
		public JAEBKFJJIPK<int> JPMIGGHMDHI(int DKAGNKJNKMF, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DE50", Offset = "0x2A8D250", VA = "0x182A8DE50")]
		public JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DF40", Offset = "0x2A8D340", VA = "0x182A8DF40", Slot = "6")]
		public void MPOCIDANMGP(int NOEININIMIL, JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DED0", Offset = "0x2A8D2D0", VA = "0x182A8DED0", Slot = "4")]
		private JAEBKFJJIPK<int> FMHBKMHNAPC(int DKAGNKJNKMF, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JAEBKFJJIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DE40", Offset = "0x2A8D240", VA = "0x182A8DE40", Slot = "5")]
		private JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> BKAEILICLOL(int NOEININIMIL, [In] JAEBKFJJIPK<(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> Target, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ByteCodeWriteLocation)> EJCCOPPBIIG)
		{
			return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NJAOCEDFLKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> NPCDDKOMCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool POHNOIAPDPG;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2128200", Offset = "0x2127600", VA = "0x182128200")]
		public NJAOCEDFLKA(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI, bool BNBFPCKMGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2A97DD0", Offset = "0x2A971D0", VA = "0x182A97DD0")]
		public void BBBPACNHLNO([Out] JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI, [Out] bool BNBFPCKMGCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct AAEOCBOFKOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly JGDCCHDHIKG<KJEBJIOBLPE> GMLCLOEHKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> NPCDDKOMCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool POHNOIAPDPG;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D970", Offset = "0x2A8CD70", VA = "0x182A8D970")]
		public AAEOCBOFKOJ(JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI, bool BNBFPCKMGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D940", Offset = "0x2A8CD40", VA = "0x182A8D940")]
		public void BBBPACNHLNO([Out] JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI, [Out] bool BNBFPCKMGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D950", Offset = "0x2A8CD50", VA = "0x182A8D950")]
		public void BBBPACNHLNO([Out] JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI, [Out] JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA, [Out] bool BNBFPCKMGCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct BELHJDELGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly JGDCCHDHIKG<KJEBJIOBLPE> GMLCLOEHKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> NPCDDKOMCHF;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		public BELHJDELGHD(JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DD80", Offset = "0x2A8D180", VA = "0x182A8DD80")]
		public void BBBPACNHLNO([Out] JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI, [Out] JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A90720", Offset = "0x2A8FB20", VA = "0x182A90720")]
	public static void ONLDIMNIKII(this FLHJJLFPHNI DMFKPMONDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F950", Offset = "0x2A8ED50", VA = "0x182A8F950")]
	public static void JNKLGDNAMGN(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> BIJKDGCFNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F400", Offset = "0x2A8E800", VA = "0x182A8F400")]
	public static void IMLMMNEJONB(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> BIJKDGCFNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A90180", Offset = "0x2A8F580", VA = "0x182A90180")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>? MOGCJMEKIPH([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EEA0", Offset = "0x2A8E2A0", VA = "0x182A8EEA0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> DPEFCADDCMJ([In] this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F590", Offset = "0x2A8E990", VA = "0x182A8F590")]
	private static void JLCBBOMCHBG(this FLHJJLFPHNI DMFKPMONDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F220", Offset = "0x2A8E620", VA = "0x182A8F220")]
	private static JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>? IADIHGGAONG([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EB00", Offset = "0x2A8DF00", VA = "0x182A8EB00")]
	public static void DAACIFLNDEB(this FLHJJLFPHNI DMFKPMONDPO, [In] JAEBKFJJIPK<MNHJJAKPIHP> HHGHPJGDGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A90460", Offset = "0x2A8F860", VA = "0x182A90460")]
	public static HAGEPAEDCPI.MEDDLBDECNK NMLCGNKLLPJ([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
	{
		return default(HAGEPAEDCPI.MEDDLBDECNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E700", Offset = "0x2A8DB00", VA = "0x182A8E700")]
	public static NGBIHHKOKHH<byte> AAIKPMIJKIN([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
	{
		return default(NGBIHHKOKHH<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A903B0", Offset = "0x2A8F7B0", VA = "0x182A903B0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NJHPNOCPINB([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E830", Offset = "0x2A8DC30", VA = "0x182A8E830")]
	public static OKGEIGJJJJK BBDFKCNIACM([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0020", Offset = "0x3AAF420", VA = "0x183AB0020")]
	private static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> OICNMLFAJDB<TMJoin>(this FLHJJLFPHNI DMFKPMONDPO, HAGEPAEDCPI.MEDDLBDECNK OJMMNEBDONA, JGDCCHDHIKG<TMJoin> ABNFADBAGOM) where TMJoin : HAGEPAEDCPI.JMFEJNKDAPF
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E7B0", Offset = "0x2A8DBB0", VA = "0x182A8E7B0")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> AJHEODHFEKG(this FLHJJLFPHNI DMFKPMONDPO, bool LFCPLENDPPK)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A909F0", Offset = "0x2A8FDF0", VA = "0x182A909F0")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> PAKJPILDCOB(this FLHJJLFPHNI DMFKPMONDPO, NGBIHHKOKHH<byte> FGHKEPJEKFP)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F9E0", Offset = "0x2A8EDE0", VA = "0x182A8F9E0")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> JPMOEFOEDDD(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> OHNELIKLKNO)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E8E0", Offset = "0x2A8DCE0", VA = "0x182A8E8E0")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> BBNLINLOIKH(this FLHJJLFPHNI DMFKPMONDPO, int POGJGJIJNFA)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A90330", Offset = "0x2A8F730", VA = "0x182A90330")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> NHNFIHJFPKH(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFF90", Offset = "0x3AAF390", VA = "0x183AAFF90")]
	private static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> MFLGKOBLIOB<TMJoin>(this FLHJJLFPHNI DMFKPMONDPO, BLKNBCNGEGI.NNPPFJNEJLF OJMMNEBDONA, JGDCCHDHIKG<TMJoin> ABNFADBAGOM) where TMJoin : BLKNBCNGEGI.DBNKPNKJMAK
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EAC0", Offset = "0x2A8DEC0", VA = "0x182A8EAC0")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> CEDNGHEMHDD(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EFB0", Offset = "0x2A8E3B0", VA = "0x182A8EFB0")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> GCJGJMCNOJD(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FE60", Offset = "0x2A8F260", VA = "0x182A8FE60")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> MAJFDKLBFOC(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> KGFJICNCMDN)
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F900", Offset = "0x2A8ED00", VA = "0x182A8F900")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> JNEPEBCJPAG(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FD80", Offset = "0x2A8F180", VA = "0x182A8FD80")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> LCGPECBGLPP(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A90500", Offset = "0x2A8F900", VA = "0x182A90500")]
	public static ILGCHJAGDPO.CFPMKCKPOAE OFDADIKLIEL([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> JBDOLHBCMGE)
	{
		return default(ILGCHJAGDPO.CFPMKCKPOAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A904C0", Offset = "0x2A8F8C0", VA = "0x182A904C0")]
	public static AFHHLMECHFE<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>, BGCLPKJPGIO<ILGCHJAGDPO.BOHFDFELHLP>> NMPDFPEMMGG([In] this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(AFHHLMECHFE<JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>, BGCLPKJPGIO<ILGCHJAGDPO.BOHFDFELHLP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EC70", Offset = "0x2A8E070", VA = "0x182A8EC70")]
	public static JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> DGANANFMMJL([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> JBDOLHBCMGE)
	{
		return default(JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EF00", Offset = "0x2A8E300", VA = "0x182A8EF00")]
	public static ILGCHJAGDPO.NJBGEFCAJKF EGEJNCEACAD([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> EDIGMEPMFBC)
	{
		return default(ILGCHJAGDPO.NJBGEFCAJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FD20", Offset = "0x2A8F120", VA = "0x182A8FD20")]
	public static ILGCHJAGDPO.NJBGEFCAJKF KIIHCBCCEBL(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> EDIGMEPMFBC)
	{
		return default(ILGCHJAGDPO.NJBGEFCAJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0170", Offset = "0x3AAF570", VA = "0x183AB0170")]
	private static JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> PAIABKFNMKA<TMJoin>(this FLHJJLFPHNI DMFKPMONDPO, ILGCHJAGDPO.CFPMKCKPOAE OJMMNEBDONA, JGDCCHDHIKG<TMJoin> ABNFADBAGOM) where TMJoin : ILGCHJAGDPO.ONNACDKNNNI
	{
		return default(JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F750", Offset = "0x2A8EB50", VA = "0x182A8F750")]
	public static (JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>) JNELAPKEOLH(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default((JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FA60", Offset = "0x2A8EE60", VA = "0x182A8FA60")]
	public static (JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>) KDFFLIFMGNB(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default((JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EF60", Offset = "0x2A8E360", VA = "0x182A8EF60")]
	public static JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> FBOCFMAADMO(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F190", Offset = "0x2A8E590", VA = "0x182A8F190")]
	public static void HFBEONDEINA(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP> EDIGMEPMFBC, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> LFELBJBGJNN, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>> LGNJCHEELGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE8C0", Offset = "0x3AADCC0", VA = "0x183AAE8C0")]
	public static NJAOCEDFLKA DNEBJEDBCLN<TDeps, TStateSys>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA) where TDeps : ONOBAKPDMEE<TStateSys>
	{
		return default(NJAOCEDFLKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF6A0", Offset = "0x3AAEAA0", VA = "0x183AAF6A0")]
	public static AAEOCBOFKOJ EBFFGOKMHGO<TDeps, TStateSys>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<HEGDLLCPNGA> BBEBJBEHHMM, int COCEEKDJBOA) where TDeps : ONOBAKPDMEE<TStateSys>
	{
		return default(AAEOCBOFKOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE4A0", Offset = "0x3AAD8A0", VA = "0x183AAE4A0")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>? AELLOHPENEJ<TDeps, TStateSys>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<HEGDLLCPNGA> BBEBJBEHHMM, [In] ReadOnlySpan<int> FJMIJNNNIIB, [In] Span<BELHJDELGHD> DPONMPIFHCF) where TDeps : ONOBAKPDMEE<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFA00", Offset = "0x3AAEE00", VA = "0x183AAFA00")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> IAOAHFKALGK<TDeps, TStateSys>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB) where TDeps : ONOBAKPDMEE<TStateSys>
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A90010", Offset = "0x2A8F410", VA = "0x182A90010")]
	public static CJGOKJPEKOH.FEBMCMOLFPE MDJGMLNHAFK([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI)
	{
		return default(CJGOKJPEKOH.FEBMCMOLFPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EA10", Offset = "0x2A8DE10", VA = "0x182A8EA10")]
	public static CJGOKJPEKOH.AOLAKAGKCBN BLIOCBGHANB([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI)
	{
		return default(CJGOKJPEKOH.AOLAKAGKCBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EDF0", Offset = "0x2A8E1F0", VA = "0x182A8EDF0")]
	public static CJGOKJPEKOH.JCGHPLAGBCL DPAALLEIFLE([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI)
	{
		return default(CJGOKJPEKOH.JCGHPLAGBCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2A90560", Offset = "0x2A8F960", VA = "0x182A90560")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> OJBEDELCNIC(this FLHJJLFPHNI DMFKPMONDPO, int? OHMOEGBKCOB, string HDNPPEBJPAE)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FC10", Offset = "0x2A8F010", VA = "0x182A8FC10")]
	public static CJGOKJPEKOH.GEKPGHLMBEL KEGMIOMHKLP([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI)
	{
		return default(CJGOKJPEKOH.GEKPGHLMBEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A90120", Offset = "0x2A8F520", VA = "0x182A90120")]
	public static CJGOKJPEKOH.INCEEGEJEDK MNMEAHPIDEM([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI)
	{
		return default(CJGOKJPEKOH.INCEEGEJEDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A900C0", Offset = "0x2A8F4C0", VA = "0x182A900C0")]
	public static int? MICLBIDNNDM([In] this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF920", Offset = "0x3AAED20", VA = "0x183AAF920")]
	private static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> FDNNPKEIKKC<TMJoin>(this FLHJJLFPHNI DMFKPMONDPO, int? OHMOEGBKCOB, CJGOKJPEKOH.INCEEGEJEDK OJMMNEBDONA, JGDCCHDHIKG<TMJoin> ABNFADBAGOM) where TMJoin : CJGOKJPEKOH.ADMBPADOONJ
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E960", Offset = "0x2A8DD60", VA = "0x182A8E960")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BGDGOCIHNAC(this FLHJJLFPHNI DMFKPMONDPO, int? OHMOEGBKCOB, JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> JBDOLHBCMGE, int NOEININIMIL)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FCC0", Offset = "0x2A8F0C0", VA = "0x182A8FCC0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KHDJMEOGILI(this FLHJJLFPHNI DMFKPMONDPO, int? OHMOEGBKCOB)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F000", Offset = "0x2A8E400", VA = "0x182A8F000")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> HCKPFNHENNE(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? DLMNMCLDBGI, int? OHMOEGBKCOB)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F370", Offset = "0x2A8E770", VA = "0x182A8F370")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> ILCEHBKODEE(this FLHJJLFPHNI DMFKPMONDPO, int? OHMOEGBKCOB, int NOEININIMIL)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6F0", Offset = "0x2A8EAF0", VA = "0x182A8F6F0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JLNBFDCJBKO(this FLHJJLFPHNI DMFKPMONDPO, int? OHMOEGBKCOB)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FEE0", Offset = "0x2A8F2E0", VA = "0x182A8FEE0")]
	public static void MBAMDJMMDEO(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF, JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> JBDOLHBCMGE, int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A90210", Offset = "0x2A8F610", VA = "0x182A90210")]
	public static void MPDCBCFOPDJ(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF, int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F2B0", Offset = "0x2A8E6B0", VA = "0x182A8F2B0")]
	public static void IJCJEJKKGLL(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FDD0", Offset = "0x2A8F1D0", VA = "0x182A8FDD0")]
	public static void LHNCEMKCNPN(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> NJJNDJLGDNH, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> LFKHCCJJAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F4D0", Offset = "0x2A8E8D0", VA = "0x182A8F4D0")]
	public static void JGJIKCOCCMB(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF, JGDCCHDHIKG<GIBAEBEBPGD<PMCPKFMLHKJ>> HIGLMEJCEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB00B0", Offset = "0x3AAF4B0", VA = "0x183AB00B0")]
	public static void OKJFPMOLNED<M>(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PACELMDFPHF, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<M>>> HIGLMEJCEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ONOBAKPDMEE<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGDCCHDHIKG<MCNDOOFJGPD> KBPJIMLFKID(TStateSys KDHEPJPCEAK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGDCCHDHIKG<MCNDOOFJGPD> ODGBBJOIHNL(TStateSys KDHEPJPCEAK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JGDCCHDHIKG<MCNDOOFJGPD> LPGBDNLBPBO(TStateSys KDHEPJPCEAK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JGDCCHDHIKG<MCNDOOFJGPD> JMELDFHLCME(TStateSys KDHEPJPCEAK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> BEBCINEDNBF(TStateSys KDHEPJPCEAK, FLHJJLFPHNI LFFGLDJBMNF, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> HMAMFOLOBHM(TStateSys KDHEPJPCEAK, FLHJJLFPHNI LFFGLDJBMNF, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AAMLFFHIOFD(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JGDCCHDHIKG<AGHHHMBIGJH> NFBFJJLEODM(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA, int FGCMHIBKGHB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KELHLFBMNPK CLFEBFDMLLD(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LDLLEGGDKPE(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NDENICFKALM(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NGBIHHKOKHH<byte> IOELKJGCJLI(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(NGBIHHKOKHH<byte>, JGDCCHDHIKG<MCNDOOFJGPD>) BBLHPCFANCN(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<KJEBJIOBLPE> OCHOINOFGFA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int ONIDGFBLJBA(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JGDCCHDHIKG<KJEBJIOBLPE> JKOJECPBCFB(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> IGCBOBFNJHB, int COCEEKDJBOA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JGDCCHDHIKG<KJEBJIOBLPE> KAIPLEKPMCD(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<HEGDLLCPNGA> BBEBJBEHHMM, int COCEEKDJBOA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int CJDHCPCIDPJ(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? ACHNOOIIDNO(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int GGMNGAIACPP(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? GJKGCLPBFGA(TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, int NOEININIMIL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LLGGJMNJNFA
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB2D0", Offset = "0x3DCA6D0", VA = "0x183DCB2D0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG?> KIAAHNFNLON<T, TOpInput, TOpOutput>(this FLHJJLFPHNI DMFKPMONDPO, T KEHFCBFJCMA, T KGECIONKOCO, int AKDNAGBHBEB, IntPtr PLBLCFDKDBF)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA120", Offset = "0x3DC9520", VA = "0x183DCA120")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG?> GCIKILJGCOE<T, TOpInput, TOpOutput>(this FLHJJLFPHNI DMFKPMONDPO, T KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO, int AKDNAGBHBEB, IntPtr PLBLCFDKDBF)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA000", Offset = "0x3DC9400", VA = "0x183DCA000")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG?> EPJAFKGKBJJ<TOpInput, TOpOutput>(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO, int AKDNAGBHBEB, IntPtr PLBLCFDKDBF)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2A97080", Offset = "0x2A96480", VA = "0x182A97080")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NADLBFDEHNK(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2A973C0", Offset = "0x2A967C0", VA = "0x182A973C0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NIDAJBDFPBA(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A96E20", Offset = "0x2A96220", VA = "0x182A96E20")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> MGMCOABJGAC(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A928F0", Offset = "0x2A91CF0", VA = "0x182A928F0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> ADOJOCFFCDK(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A93830", Offset = "0x2A92C30", VA = "0x182A93830")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BPGJMNDGKGC(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A936F0", Offset = "0x2A92AF0", VA = "0x182A936F0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BNDIGBINJJH(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A97560", Offset = "0x2A96960", VA = "0x182A97560")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> ODKGCEDDBCG(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A95E30", Offset = "0x2A95230", VA = "0x182A95E30")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JKECBNIPIEE(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A92B30", Offset = "0x2A91F30", VA = "0x182A92B30")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> AGBEEJHOMOA(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A96070", Offset = "0x2A95470", VA = "0x182A96070")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KCBHKHFMMKF(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, int KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A959B0", Offset = "0x2A94DB0", VA = "0x182A959B0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> INMOCEAGNPG(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A97280", Offset = "0x2A96680", VA = "0x182A97280")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NICKELEFDBA(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A93250", Offset = "0x2A92650", VA = "0x182A93250")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BFHFIPJAOOJ(this FLHJJLFPHNI DMFKPMONDPO, float KEHFCBFJCMA, float KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A97760", Offset = "0x2A96B60", VA = "0x182A97760")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PEAAPEMPGEH(this FLHJJLFPHNI DMFKPMONDPO, float KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A93350", Offset = "0x2A92750", VA = "0x182A93350")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BGAECKPMKMA(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A94790", Offset = "0x2A93B90", VA = "0x182A94790")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> FGKGOFKMLKB(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, int KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A93490", Offset = "0x2A92890", VA = "0x182A93490")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BJGLGBIANMP(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A95DB0", Offset = "0x2A951B0", VA = "0x182A95DB0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JIBEMOAGBCI(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A94810", Offset = "0x2A93C10", VA = "0x182A94810")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GBNPAJMLHNI(this FLHJJLFPHNI DMFKPMONDPO, float KEHFCBFJCMA, float KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A967A0", Offset = "0x2A95BA0", VA = "0x182A967A0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> LHIIKOKIOAE(this FLHJJLFPHNI DMFKPMONDPO, float KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A93F90", Offset = "0x2A93390", VA = "0x182A93F90")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DGFIKLLCELL(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A97200", Offset = "0x2A96600", VA = "0x182A97200")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NDLEDBGPNKG(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, int KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A97660", Offset = "0x2A96A60", VA = "0x182A97660")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> OIGBDFHBBFJ(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A96A50", Offset = "0x2A95E50", VA = "0x182A96A50")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> MEBMHAPJBKP(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A974E0", Offset = "0x2A968E0", VA = "0x182A974E0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NOLGJHNPHPC(this FLHJJLFPHNI DMFKPMONDPO, float KEHFCBFJCMA, float KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A976E0", Offset = "0x2A96AE0", VA = "0x182A976E0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> OJBMFKJDFHK(this FLHJJLFPHNI DMFKPMONDPO, float KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A931D0", Offset = "0x2A925D0", VA = "0x182A931D0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BDMGDDNPOJL(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A96370", Offset = "0x2A95770", VA = "0x182A96370")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> KMLGHOIJOND(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A94010", Offset = "0x2A93410", VA = "0x182A94010")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> DJGDFDAOJPG(this FLHJJLFPHNI DMFKPMONDPO, int CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A93DB0", Offset = "0x2A931B0", VA = "0x182A93DB0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> DEECLDIPLJB(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A93510", Offset = "0x2A92910", VA = "0x182A93510")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> BMOEAJBGMNL(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DGNLGBHHJJI)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A92DB0", Offset = "0x2A921B0", VA = "0x182A92DB0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> ANJGBALOLNL(this FLHJJLFPHNI DMFKPMONDPO, int CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A92E30", Offset = "0x2A92230", VA = "0x182A92E30")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> AOOFCCDPNJF(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A95540", Offset = "0x2A94940", VA = "0x182A95540")]
	public static (JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>) IJKODHAPDGA(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HEMEAAEFNEI> JEHLFEEGEOI, [In] ReadOnlySpan<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> NODDCIHHMPD, [In] ReadOnlySpan<int?> CKKDFMDAIAI, [In] Span<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> BDFCBGEOFOL)
	{
		return default((JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A94170", VA = "0x182A94D70")]
	public static (JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>) HECIGBLBCNM(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<LAMDHOIBIPH> KMNGKPPJEMK, [In] ReadOnlySpan<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> NODDCIHHMPD, [In] ReadOnlySpan<int?> CKKDFMDAIAI, [In] Span<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> BDFCBGEOFOL)
	{
		return default((JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB580", Offset = "0x3DCA980", VA = "0x183DCB580")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<MCNDOOFJGPD>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<TMarker>>, JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>) LJMOGLOFAIL<TMarker>(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<MCNDOOFJGPD> OLCOHCOFIBD, [In] ReadOnlySpan<byte> NGIAGNLBILI)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<MCNDOOFJGPD>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<TMarker>>, JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A962B0", Offset = "0x2A956B0", VA = "0x182A962B0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KIDEGAFJMPG(this FLHJJLFPHNI DMFKPMONDPO, int EOHGCIHCMID, [Optional] JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A96960", Offset = "0x2A95D60", VA = "0x182A96960")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> MBPFDINOLKM(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EOHGCIHCMID, [Optional] JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A94290", Offset = "0x2A93690", VA = "0x182A94290")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EAEGBAANCCH(this FLHJJLFPHNI DMFKPMONDPO, [In] ReadOnlySpan<byte> EOHGCIHCMID, [Optional] JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A97A50", Offset = "0x2A96E50", VA = "0x182A97A50")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PMPHMPDMILH(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EOHGCIHCMID, int MPDDFCCPIOM, [Optional] JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A94480", Offset = "0x2A93880", VA = "0x182A94480")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EIHMCIJPJDH(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A93950", Offset = "0x2A92D50", VA = "0x182A93950")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CAMEDPBFNJF(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A96170", Offset = "0x2A95570", VA = "0x182A96170")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KHLAFBEIGND(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A96550", Offset = "0x2A95950", VA = "0x182A96550")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KPAGPAJCHJI(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A95F50", Offset = "0x2A95350", VA = "0x182A95F50")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KAFDMLLKDLK(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A95AD0", Offset = "0x2A94ED0", VA = "0x182A95AD0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> IOAOGLCCGFJ(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A95D30", Offset = "0x2A95130", VA = "0x182A95D30")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JCBICAJIMAE(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, int KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A97890", Offset = "0x2A96C90", VA = "0x182A97890")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PEMHGJADLNM(this FLHJJLFPHNI DMFKPMONDPO, int KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A97180", Offset = "0x2A96580", VA = "0x182A97180")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NCOJFEFNPAF(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KEHFCBFJCMA, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> KGECIONKOCO)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A94090", Offset = "0x2A93490", VA = "0x182A94090")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DKBJLECEEJG(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A96AD0", Offset = "0x2A95ED0", VA = "0x182A96AD0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> MEICALOKKKI(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A97910", Offset = "0x2A96D10", VA = "0x182A97910")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> PJGKGMELBCN(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A96D20", Offset = "0x2A96120", VA = "0x182A96D20")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> MFMBGCLOMCE(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A951E0", Offset = "0x2A945E0", VA = "0x182A951E0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> HEMHNLLOBBB(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A96660", Offset = "0x2A95A60", VA = "0x182A96660")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> LFMCINJLKJF(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A96F60", Offset = "0x2A96360", VA = "0x182A96F60")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>> MMBLFOHIFAG(this FLHJJLFPHNI DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A94190", Offset = "0x2A93590", VA = "0x182A94190")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DNOENPFLNAO(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A95300", Offset = "0x2A94700", VA = "0x182A95300")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> HPOEGNAHKAD(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A929F0", Offset = "0x2A91DF0", VA = "0x182A929F0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> AFKKCGFMFHI(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A94380", Offset = "0x2A93780", VA = "0x182A94380")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EEAOEABAJGK(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A94C50", Offset = "0x2A94050", VA = "0x182A94C50")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> HBOOOKOJGEH(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A927B0", Offset = "0x2A91BB0", VA = "0x182A927B0")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> AAMAMANIJND(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A93B70", Offset = "0x2A92F70", VA = "0x182A93B70")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLCMPLKFKPP(this FLHJJLFPHNI DMFKPMONDPO, int CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A94580", Offset = "0x2A93980", VA = "0x182A94580")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EKPNDPCDLNF(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A96650", Offset = "0x2A95A50", VA = "0x182A96650")]
	public static void LECJPHAAOMF(this FLHJJLFPHNI DMFKPMONDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A96F80", Offset = "0x2A96380", VA = "0x182A96F80")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> NAAFKDGMGLH(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A95420", Offset = "0x2A94820", VA = "0x182A95420")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> IBLJPADFKNG(this FLHJJLFPHNI DMFKPMONDPO, float GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A96820", Offset = "0x2A95C20", VA = "0x182A96820")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> LLAKMHOBIFM(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A93A70", Offset = "0x2A92E70", VA = "0x182A93A70")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CFDDPODGAEI(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A95C10", Offset = "0x2A95010", VA = "0x182A95C10")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> IPEFDGNLDJL(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A93E50", Offset = "0x2A93250", VA = "0x182A93E50")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DEENACJIGNF(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A94890", Offset = "0x2A93C90", VA = "0x182A94890")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> HACCBJAAHOM(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> OGOGOJBDBJB, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> MIKNOCFNDCL)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A94690", Offset = "0x2A93A90", VA = "0x182A94690")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> ELKGLFLLGKB(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2A96C00", Offset = "0x2A96000", VA = "0x182A96C00")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> MFHJCGNLJKF(this FLHJJLFPHNI DMFKPMONDPO, int GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2A92C70", Offset = "0x2A92070", VA = "0x182A92C70")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> AMPKJIAOBLA(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> GKOMMDHCBKC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> JOPKPOCDHNJ)
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA400", Offset = "0x3DC9800", VA = "0x183DCA400")]
	public static void GIBJOLLMMFA<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<HEMEAAEFNEI> JEHLFEEGEOI, [In] ReadOnlySpan<JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>> GJBDEINIAAG, [In] ReadOnlySpan<int?> CKKDFMDAIAI, [In] Span<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> BDFCBGEOFOL, [In] Span<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> LENBHLMNFKH, [In] ReadOnlySpan<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>?> CGLOGJNNBGK) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9AF0", Offset = "0x3DC8EF0", VA = "0x183DC9AF0")]
	public static void ECDHCANKCFH<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<LAMDHOIBIPH> PEHELHMLLIK, [In] ReadOnlySpan<JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>> MBOMMPOMBHK, [In] ReadOnlySpan<int?> CKKDFMDAIAI, [In] Span<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> BDFCBGEOFOL, [In] Span<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>> LENBHLMNFKH, [In] ReadOnlySpan<JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>?> CGLOGJNNBGK) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9140", Offset = "0x3DC8540", VA = "0x183DC9140")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> BMJLBKAEMEL<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DLMNMCLDBGI, [Optional] JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9300", Offset = "0x3DC8700", VA = "0x183DC9300")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DMPOENLCEFA<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> KGFJICNCMDN, [Optional] JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB670", Offset = "0x3DCAA70", VA = "0x183DCB670")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> NKAILPBFDBL<TDeps, TStateSys>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK) where TDeps : notnull, ONOBAKPDMEE<TStateSys> where TStateSys : notnull
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8DF0", Offset = "0x3DC81F0", VA = "0x183DC8DF0")]
	public static JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB> APINGNGIOBI<TDeps, TStateSys>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK) where TDeps : notnull, ONOBAKPDMEE<TStateSys> where TStateSys : notnull
	{
		return default(JGDCCHDHIKG<BLKNBCNGEGI.DBOKPIKPBBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A93C70", Offset = "0x2A93070", VA = "0x182A93C70")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> DDINBJGAALH(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> OOAGLOLFDPN, IntPtr KGGGDJIMFHE, IntPtr EDDHOJEKHGN)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A92ED0", Offset = "0x2A922D0", VA = "0x182A92ED0")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> BCGFLPDGKCL(this FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> OPOGPHAHCDM, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> EOJEDNEDNMD, IntPtr GKPJMIGAKDP, IntPtr CHHBNGCEMPH, IntPtr LMNCLIMGPEF, bool LFPFCJCOIID)
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA910", Offset = "0x3DC9D10", VA = "0x183DCA910")]
	public static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> HICIOGHGLGO<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<HEMEAAEFNEI> IILNNGFFNLG, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> OPOGPHAHCDM, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> EOJEDNEDNMD, int? JPPPDHLIDFK, [Optional] IntPtr FGFLAAEMNAM) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCAAE0", Offset = "0x3DC9EE0", VA = "0x183DCAAE0")]
	private static JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> HICIOGHGLGO<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<HEMEAAEFNEI> IILNNGFFNLG, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> OPOGPHAHCDM, JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA> EOJEDNEDNMD, int? JPPPDHLIDFK) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
		return default(JGDCCHDHIKG<HAGEPAEDCPI.FNKCIADPENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8970", Offset = "0x3DC7D70", VA = "0x183DC8970")]
	public static JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> AMAFIKCDGFE<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> EOHGCIHCMID, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>? BEKKFILOPCK) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
		return default(JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9730", Offset = "0x3DC8B30", VA = "0x183DC9730")]
	public static void DOPKPEBBJEK<TDeps, TState>(this FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TState JPDKKKJJNLC, int EMGDIJCJKMN) where TDeps : notnull, ONOBAKPDMEE<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AKJHAKGDOKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> EOIHKPHNCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> AKPOENKNELB;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
	public AKJHAKGDOKG(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> CPNIJJODJJG, JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> NHLLNODIGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DA00", Offset = "0x2A8CE00", VA = "0x182A8DA00")]
	public static AKJHAKGDOKG EJOLKNBPCJB(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> CPNIJJODJJG)
	{
		return default(AKJHAKGDOKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CJGOKJPEKOH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class GBJELCGNLJB : ADMBPADOONJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FEBMCMOLFPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> FDOEGCHIMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JHGBNCFKBAP;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		public FEBMCMOLFPE(JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> JBDOLHBCMGE, int NOEININIMIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MNHDAODJBGK : ADMBPADOONJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct AOLAKAGKCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JHGBNCFKBAP;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public AOLAKAGKCBN(int NOEININIMIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CGBHCLJGHGE : ADMBPADOONJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct JCGHPLAGBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> FDOEGCHIMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int JHGBNCFKBAP;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		public JCGHPLAGBCL(JGDCCHDHIKG<ILGCHJAGDPO.DEJOJPHDJIN> JBDOLHBCMGE, int NOEININIMIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum INCEEGEJEDK
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
	public sealed class DLCNFMJMNAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class ADMBPADOONJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct APCPGIMNLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? EMOHLDOFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AKJHAKGDOKG NMPEAIBOCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public INCEEGEJEDK HOOGMKCONIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JGDCCHDHIKG<ADMBPADOONJ> AGIOLIEFOGE;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA10", Offset = "0x2A8CE10", VA = "0x182A8DA10")]
		public APCPGIMNLMB(int? OHMOEGBKCOB, [In] AKJHAKGDOKG HGHGBOGHNIL, INCEEGEJEDK OJMMNEBDONA, JGDCCHDHIKG<ADMBPADOONJ> ABNFADBAGOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class FLHFMHBGGBP : ADMBPADOONJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GEKPGHLMBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int JHGBNCFKBAP;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		public GEKPGHLMBEL(int NOEININIMIL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal DNDNOKOJNBD<DLCNFMJMNAG, APCPGIMNLMB> JGHHJDMPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal DNDNOKOJNBD<GBJELCGNLJB, FEBMCMOLFPE> BEIBKHOJHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal DNDNOKOJNBD<CGBHCLJGHGE, JCGHPLAGBCL> JLCLFDEOPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal DNDNOKOJNBD<FLHFMHBGGBP, GEKPGHLMBEL> PBPHHAJHANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal DNDNOKOJNBD<MNHDAODJBGK, AOLAKAGKCBN> GNPACMELOGD;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E530", Offset = "0x2A8D930", VA = "0x182A8E530")]
	private CJGOKJPEKOH([In] DNDNOKOJNBD<DLCNFMJMNAG, APCPGIMNLMB> IEOJJHOFHLO, [In] DNDNOKOJNBD<GBJELCGNLJB, FEBMCMOLFPE> LFMKDGMEPNB, [In] DNDNOKOJNBD<CGBHCLJGHGE, JCGHPLAGBCL> AHADMPHJJHE, [In] DNDNOKOJNBD<FLHFMHBGGBP, GEKPGHLMBEL> JGPAMEOIKBM, [In] DNDNOKOJNBD<MNHDAODJBGK, AOLAKAGKCBN> OBHIDNAADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E340", Offset = "0x2A8D740", VA = "0x182A8E340")]
	public static CJGOKJPEKOH EJOLKNBPCJB()
	{
		return default(CJGOKJPEKOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BILAMPEBKPL
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DD90", Offset = "0x2A8D190", VA = "0x182A8DD90")]
	public static void ONLDIMNIKII(this CJGOKJPEKOH DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NOENDILDPLE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2A97E60", Offset = "0x2A97260", VA = "0x182A97E60")]
	public static void COBMPGJIBLC(FLHJJLFPHNI DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DFPPJEJFOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, OOALEMPJJEK> BAMHDOBDPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int HDMAGDOCCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int CDBMIKCHNDB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2A90D70", Offset = "0x2A90170", VA = "0x182A90D70")]
	private DFPPJEJFOBP([In] NHGMKBGLCBA<ILGCHJAGDPO.BOHFDFELHLP, OOALEMPJJEK> CEENCIBGHBI, int KCDGDHENMEB, int HMNBLJMOHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2A90B30", Offset = "0x2A8FF30", VA = "0x182A90B30")]
	public static DFPPJEJFOBP EJOLKNBPCJB()
	{
		return default(DFPPJEJFOBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2A90BA0", Offset = "0x2A8FFA0", VA = "0x182A90BA0")]
	public void ONLDIMNIKII([In] FLHJJLFPHNI PCEKLOBPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B07B60", Offset = "0x3B06F60", VA = "0x183B07B60")]
	public static void COBMPGJIBLC<TDeps, TStateSys>(FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD) where TDeps : notnull, ONOBAKPDMEE<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class OLLNLMGDFAC
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2A98B30", Offset = "0x2A97F30", VA = "0x182A98B30")]
	public static void COBMPGJIBLC(FLHJJLFPHNI DMFKPMONDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HJPBPCBBCJB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface DDBGFEGLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ACFCIBDJFPJ(JAEBKFJJIPK<byte> ODIIOEFHEAM, int NKOCAONNINB);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PBHAINIBODP : DDBGFEGLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2A98DE0", Offset = "0x2A981E0", VA = "0x182A98DE0", Slot = "4")]
		public void ACFCIBDJFPJ(JAEBKFJJIPK<byte> ODIIOEFHEAM, int NKOCAONNINB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct KGPFKCLOLPD : DDBGFEGLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A92330", Offset = "0x2A91730", VA = "0x182A92330", Slot = "4")]
		public void ACFCIBDJFPJ(JAEBKFJJIPK<byte> ODIIOEFHEAM, int NKOCAONNINB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct EHGEEKIDJID : DDBGFEGLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2A90E20", Offset = "0x2A90220", VA = "0x182A90E20", Slot = "4")]
		public void ACFCIBDJFPJ(JAEBKFJJIPK<byte> ODIIOEFHEAM, int NKOCAONNINB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct CJKMPHCNEJD : DDBGFEGLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E660", Offset = "0x2A8DA60", VA = "0x182A8E660", Slot = "4")]
		public void ACFCIBDJFPJ(JAEBKFJJIPK<byte> ODIIOEFHEAM, int NKOCAONNINB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class MIGCFHHAKEH<TCallProcessorDeps> where TCallProcessorDeps : struct, DDBGFEGLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps MGFGGPPDFIP;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4460350", Offset = "0x445F750", VA = "0x184460350")]
		public static int COBMPGJIBLC<TDeps, TStateSys>(TDeps MOHOCDOOLDA, TStateSys JPDKKKJJNLC, FLHJJLFPHNI PCEKLOBPOGK, [In] JAEBKFJJIPK<byte> DCDMBBHABEB, int OIKKFAGGFEP) where TDeps : ONOBAKPDMEE<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private JAEBKFJJIPK<MNHJJAKPIHP> GENALDHHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>> DEOHEKIJABO;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2A92070", Offset = "0x2A91470", VA = "0x182A92070")]
	private HJPBPCBBCJB([In] JAEBKFJJIPK<MNHJJAKPIHP> HHGHPJGDGBI, Dictionary<JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<ILGCHJAGDPO.BOHFDFELHLP>> ONAGJPMIONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2A91F70", Offset = "0x2A91370", VA = "0x182A91F70")]
	public static HJPBPCBBCJB EJOLKNBPCJB()
	{
		return default(HJPBPCBBCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2A92030", Offset = "0x2A91430", VA = "0x182A92030")]
	public void ONLDIMNIKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6C50", Offset = "0x3CC6050", VA = "0x183CC6C50")]
	public static void COBMPGJIBLC<TDeps, TStateSys>(FLHJJLFPHNI DMFKPMONDPO, TDeps MOHOCDOOLDA, TStateSys KDHEPJPCEAK) where TDeps : ONOBAKPDMEE<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class OEMLBPEEOOC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct KDDOBIDJMNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> DLPABNCBCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int NDEJDANPJLN;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int NBKEFJIDGPC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int FEBAJAPFLAJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A98050", Offset = "0x2A97450", VA = "0x182A98050")]
	public static void COBMPGJIBLC(FLHJJLFPHNI DMFKPMONDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2A985C0", Offset = "0x2A979C0", VA = "0x182A985C0")]
	private static void MHNOMFHPIGD([In] FLHJJLFPHNI DMFKPMONDPO, JGDCCHDHIKG<CJGOKJPEKOH.DLCNFMJMNAG> CLNGGGMIBPI, JAEBKFJJIPK<byte> PHIHKKFFKDG, List<KDDOBIDJMNM> FBIKNFDBJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2A987E0", Offset = "0x2A97BE0", VA = "0x182A987E0")]
	private static void MHNOMFHPIGD(JAEBKFJJIPK<byte> PHIHKKFFKDG, int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2A98920", Offset = "0x2A97D20", VA = "0x182A98920")]
	private static void OAIGPEKOMDC(FLHJJLFPHNI DMFKPMONDPO, List<KDDOBIDJMNM> FBIKNFDBJFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JJOGMEFMDBF<TDeps, TIndex, TValues> where TDeps : struct, JIAIIJIJLEB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps MGFGGPPDFIP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5367E40", Offset = "0x5367240", VA = "0x185367E40")]
	public static void COBMPGJIBLC([In] JAEBKFJJIPK<MNHJJAKPIHP> HHGHPJGDGBI, int DKAGNKJNKMF, TValues EJCCOPPBIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JIAIIJIJLEB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JAEBKFJJIPK<TIndex> JPMIGGHMDHI(int DKAGNKJNKMF, [In] TValues EJCCOPPBIIG);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(TIndex NOEININIMIL, [In] TValues EJCCOPPBIIG);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPOCIDANMGP(TIndex NOEININIMIL, TValues EJCCOPPBIIG, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface IGMPJFJJDAI<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex DEFIPBBNEBB(int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KAMKKHLLJEL(TIndex NOEININIMIL, [In] TValues EJCCOPPBIIG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBBOJCBCBIG(TIndex NOEININIMIL, [In] TValues EJCCOPPBIIG);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JEDEKOOEDHI<TDeps, TIndex, TValues> where TDeps : struct, IGMPJFJJDAI<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps MGFGGPPDFIP;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5307D10", Offset = "0x5307110", VA = "0x185307D10")]
	public static JAEBKFJJIPK<TIndex> COBMPGJIBLC(int DKAGNKJNKMF, [In] TValues EJCCOPPBIIG)
	{
		return default(JAEBKFJJIPK<TIndex>);
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

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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2836C00", Offset = "0x2835A00", VA = "0x182836C00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct FFCDBHLPPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> PCEGEOBOJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int KJACMEPEAID;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
	public FFCDBHLPPDI(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> EMAMFJDABJL, int PPPFIBNDOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HDHIMHFEGFO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BHEDGDOHGHP : NNNKPLMGOOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct PCECPPCDPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly GFHLACIIHGI<byte> IFLDEJOGFIA;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27D0190", Offset = "0x27CEF90", VA = "0x1827D0190")]
		public PCECPPCDPLP(GFHLACIIHGI<byte> HNAKMABCJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x283C030", Offset = "0x283AE30", VA = "0x18283C030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LKOOKDMIJFM : NNNKPLMGOOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CDOFMAJGIEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> ADIDFDKJHNB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public CDOFMAJGIEK(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> GAAPEMAAMCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum NCNJOJCKNFB
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
	public sealed class PNNKJBNJKAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class NNNKPLMGOOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct GPOCOEFGLPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly NCNJOJCKNFB MPNOJFFBNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly BIHBDMOHDCK<NNNKPLMGOOB> LMNKIPEFDDM;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public GPOCOEFGLPN(NCNJOJCKNFB APGBNCJIIBJ, BIHBDMOHDCK<NNNKPLMGOOB> ABCAMPEJDPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class AEOIAADMKOC : NNNKPLMGOOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct KFGBAIGFFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GHBGFECODBE;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public KFGBAIGFFPM(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FDCFDAMDPIH : NNNKPLMGOOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct MEMCIPFGHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly JGAKLEJADPA GKHPKGGNKBG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public MEMCIPFGHJL(JGAKLEJADPA LGMLMALDHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28354B0", Offset = "0x28342B0", VA = "0x1828354B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal FMPNIAJMGEP<PNNKJBNJKAB, GPOCOEFGLPN> AJFGDLMDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal FMPNIAJMGEP<BHEDGDOHGHP, PCECPPCDPLP> EPNGONPFBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal FMPNIAJMGEP<LKOOKDMIJFM, CDOFMAJGIEK> KJJMGBNINPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal FMPNIAJMGEP<AEOIAADMKOC, KFGBAIGFFPM> IBOJLDMGNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal FMPNIAJMGEP<FDCFDAMDPIH, MEMCIPFGHJL> JGEAICIHFPN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2832560", Offset = "0x2831360", VA = "0x182832560")]
	private HDHIMHFEGFO([In] FMPNIAJMGEP<PNNKJBNJKAB, GPOCOEFGLPN> OEFCCPAHHIO, [In] FMPNIAJMGEP<BHEDGDOHGHP, PCECPPCDPLP> DHLFNNDNLCA, [In] FMPNIAJMGEP<LKOOKDMIJFM, CDOFMAJGIEK> DHKPPGFFHNA, [In] FMPNIAJMGEP<AEOIAADMKOC, KFGBAIGFFPM> DDAIMFJBCNF, [In] FMPNIAJMGEP<FDCFDAMDPIH, MEMCIPFGHJL> FCECCECHMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2832420", Offset = "0x2831220", VA = "0x182832420")]
	public static HDHIMHFEGFO NBEICDCLFEE()
	{
		return default(HDHIMHFEGFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GNGGJJCLLPG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2832050", Offset = "0x2830E50", VA = "0x182832050")]
	public static void KCGBACPBOON(this HDHIMHFEGFO FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OKCADJGJJNI
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
public struct HPLPPPOAOOE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class NKGLIPCBMJC : EHHMLNEIGOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct PBLEJONHHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> NFIEEOHMFNF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public PBLEJONHHCL(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> BMEFIEBEDAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum ELPFGLAKFPO
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
	public sealed class IENMPEPLKGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class EHHMLNEIGOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct DILIBIPALPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly ELPFGLAKFPO MPNOJFFBNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly BIHBDMOHDCK<EHHMLNEIGOK> LMNKIPEFDDM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public DILIBIPALPJ(ELPFGLAKFPO APGBNCJIIBJ, BIHBDMOHDCK<EHHMLNEIGOK> ABCAMPEJDPJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FMPNIAJMGEP<IENMPEPLKGP, DILIBIPALPJ> AJFGDLMDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FMPNIAJMGEP<NKGLIPCBMJC, PBLEJONHHCL> HJDGCBDLEBI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2830940", Offset = "0x282F740", VA = "0x182830940")]
	private HPLPPPOAOOE([In] FMPNIAJMGEP<IENMPEPLKGP, DILIBIPALPJ> OEFCCPAHHIO, [In] FMPNIAJMGEP<NKGLIPCBMJC, PBLEJONHHCL> CGEDAKABMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2832970", Offset = "0x2831770", VA = "0x182832970")]
	public static HPLPPPOAOOE NBEICDCLFEE()
	{
		return default(HPLPPPOAOOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FIFMDFCDMMK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2831330", Offset = "0x2830130", VA = "0x182831330")]
	public static void KCGBACPBOON(this HPLPPPOAOOE FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PBMHGHNPFOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public ILLOCPJIIID<int> JCPEABIHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public ILLOCPJIIID<int> JMACHCJOBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NPGMPNNJKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KDPHOOGNEIA;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x283BFD0", Offset = "0x283ADD0", VA = "0x18283BFD0")]
	private PBMHGHNPFOJ([In] ILLOCPJIIID<int> JGCHGJOOCNN, [In] ILLOCPJIIID<int> BMJOMAMJGPL, int ICIOKBHMEKE, int DAEHKEOPJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x283BF30", Offset = "0x283AD30", VA = "0x18283BF30")]
	public static PBMHGHNPFOJ NBEICDCLFEE()
	{
		return default(PBMHGHNPFOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GMLLOKAFKDP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2832000", Offset = "0x2830E00", VA = "0x182832000")]
	public static void KCGBACPBOON(this PBMHGHNPFOJ FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NDDLNHCCKHE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DPNIPFLBAKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class DKBOKKKOJIO : ACPELCAIBID
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct AHHBNKLEAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly BIHBDMOHDCK<GFLMMGLPNAP> OOJEOODPMDF;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public AHHBNKLEAHO(BIHBDMOHDCK<GFLMMGLPNAP> HGGBHBECGAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class OPAOCKAFHIJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ACPELCAIBID
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct JGLMBPNNFPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly DPNIPFLBAKA MPNOJFFBNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly BIHBDMOHDCK<ACPELCAIBID> LMNKIPEFDDM;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		private JGLMBPNNFPC(DPNIPFLBAKA APGBNCJIIBJ, BIHBDMOHDCK<ACPELCAIBID> ABCAMPEJDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2832B70", Offset = "0x2831970", VA = "0x182832B70")]
		public static JGLMBPNNFPC NBEICDCLFEE(DPNIPFLBAKA APGBNCJIIBJ, BIHBDMOHDCK<ACPELCAIBID> ABCAMPEJDPJ)
		{
			return default(JGLMBPNNFPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class OJLINFLHLAM : ACPELCAIBID
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct ACDJDFEEKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly BIHBDMOHDCK<GFLMMGLPNAP> OOJEOODPMDF;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public ACDJDFEEKPH(BIHBDMOHDCK<GFLMMGLPNAP> HGGBHBECGAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class GFLMMGLPNAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct DFNCCCCPNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public ILLOCPJIIID<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> ALBDKLNMPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ILLOCPJIIID<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> BLGALNEDCBD;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2830940", Offset = "0x282F740", VA = "0x182830940")]
		private DFNCCCCPNHK([In] ILLOCPJIIID<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> PECPDCLIACL, [In] ILLOCPJIIID<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> PKODAPEHGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28308C0", Offset = "0x282F6C0", VA = "0x1828308C0")]
		public static DFNCCCCPNHK NBEICDCLFEE()
		{
			return default(DFNCCCCPNHK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal FMPNIAJMGEP<OPAOCKAFHIJ, JGLMBPNNFPC> AJFGDLMDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal FMPNIAJMGEP<OJLINFLHLAM, ACDJDFEEKPH> CHONIIMFGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal FMPNIAJMGEP<DKBOKKKOJIO, AHHBNKLEAHO> DACOOMFOFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal ILLOCPJIIID<(BIHBDMOHDCK<OPAOCKAFHIJ> CallId, BIHBDMOHDCK<GFLMMGLPNAP> IOId)> GLMFLLCIJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FMPNIAJMGEP<GFLMMGLPNAP, DFNCCCCPNHK> ECACADOFDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal PKGDJDPCMOK<GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> JBMAFDAICGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal PKGDJDPCMOK<GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BAAFFIJAHCI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2836760", Offset = "0x2835560", VA = "0x182836760")]
	private NDDLNHCCKHE([In] FMPNIAJMGEP<OPAOCKAFHIJ, JGLMBPNNFPC> OEFCCPAHHIO, [In] FMPNIAJMGEP<OJLINFLHLAM, ACDJDFEEKPH> NGHHFONEOEG, [In] FMPNIAJMGEP<DKBOKKKOJIO, AHHBNKLEAHO> JCBMOKOIOCF, [In] ILLOCPJIIID<(BIHBDMOHDCK<OPAOCKAFHIJ> CallId, BIHBDMOHDCK<GFLMMGLPNAP> IOId)> MODMDOPMNHB, [In] FMPNIAJMGEP<GFLMMGLPNAP, DFNCCCCPNHK> MAHMNKIGHHC, [In] PKGDJDPCMOK<GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> JMEHCDLOHBE, [In] PKGDJDPCMOK<GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> PMKHIOKLPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28365C0", Offset = "0x28353C0", VA = "0x1828365C0")]
	public static NDDLNHCCKHE NBEICDCLFEE()
	{
		return default(NDDLNHCCKHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FCEDFAHELEM
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2830FE0", Offset = "0x282FDE0", VA = "0x182830FE0")]
	private static void KCGBACPBOON(this NDDLNHCCKHE.DFNCCCCPNHK FPFHIDBMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2831030", Offset = "0x282FE30", VA = "0x182831030")]
	public static void KCGBACPBOON(this NDDLNHCCKHE FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct MFCBJDHCPAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public ILLOCPJIIID<byte> AFBENJPLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal NDDLNHCCKHE OHIDCEBGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GPOPFECGMGC ELPBPBAPADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> KKECIPJBOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal HDHIMHFEGFO HCIHKHABGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal HPLPPPOAOOE KJCJMLPPMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal PKGDJDPCMOK<IEDJJDGMFHP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>?> EGCMKHCNBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal ILLOCPJIIID<BIHBDMOHDCK<IEDJJDGMFHP>> KIDODGEAKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> FKIFPBPOPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> HDLHLLAHPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> KMEDPJHIBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal AEBEHOCNCHB PMKHNMIIBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal HFJIAFFHPHC FMEAHDCNKKE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2835E80", Offset = "0x2834C80", VA = "0x182835E80")]
	private MFCBJDHCPAI([In] ILLOCPJIIID<byte> IADIONICCIC, [In] NDDLNHCCKHE EJCJJKAGOIA, [In] GPOPFECGMGC IBDJDECHNEA, [In] HDHIMHFEGFO BFPKBGFEBDJ, [In] HPLPPPOAOOE ALPDJIOGOED, [In] PKGDJDPCMOK<IEDJJDGMFHP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>?> NOCAPCOJKOE, [In] ILLOCPJIIID<BIHBDMOHDCK<IEDJJDGMFHP>> PPHHBOCKGJL, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> EHHICOCGNIM, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> CIHEEPHGNGA, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> ABLHEMAMGBA, [In] AEBEHOCNCHB GJEGGIMIHID, [In] HFJIAFFHPHC DOPFEGJAGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28354D0", Offset = "0x28342D0", VA = "0x1828354D0")]
	public static MFCBJDHCPAI NBEICDCLFEE()
	{
		return default(MFCBJDHCPAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KPMIKJMJJKH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct FDAIJDGIHNA : MHJCEMHJFNF<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>, PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2831280", Offset = "0x2830080", VA = "0x182831280")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2831240", Offset = "0x2830040", VA = "0x182831240", Slot = "4")]
		public BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> JGMMOEAOJHK(int GLAOLHCPLLG)
		{
			return default(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		public bool APFJFLMPAOP(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "5")]
		private bool BIHKICPJADA(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2831270", Offset = "0x2830070", VA = "0x182831270", Slot = "6")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> KDCCGEJNMHO(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct KMGMJALAEJH : PGBAHJBLIMK<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>, PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2832C60", Offset = "0x2831A60", VA = "0x182832C60")]
		public ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>> IGKLBDGHCCP(int ENLNOINJDEG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2832CD0", Offset = "0x2831AD0", VA = "0x182832CD0")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2832BA0", Offset = "0x28319A0", VA = "0x182832BA0", Slot = "6")]
		public void CCEKONHOCJK(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2832C60", Offset = "0x2831A60", VA = "0x182832C60", Slot = "4")]
		private ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>> MONELHGJNPE(int ENLNOINJDEG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2832B90", Offset = "0x2831990", VA = "0x182832B90", Slot = "5")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> AJMPHPNIIMI(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct NOJPKFMHPDC : MHJCEMHJFNF<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>, PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2836B10", Offset = "0x2835910", VA = "0x182836B10")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2836AE0", Offset = "0x28358E0", VA = "0x182836AE0", Slot = "4")]
		public BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> JGMMOEAOJHK(int GLAOLHCPLLG)
		{
			return default(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		public bool APFJFLMPAOP(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "5")]
		private bool HHJFBMCJABL(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2836AD0", Offset = "0x28358D0", VA = "0x182836AD0", Slot = "6")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> GHINOAOKBBE(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct DHPDINPIJPN : PGBAHJBLIMK<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>, PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2830A40", Offset = "0x282F840", VA = "0x182830A40")]
		public ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>> IGKLBDGHCCP(int ENLNOINJDEG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2830AC0", Offset = "0x282F8C0", VA = "0x182830AC0")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2830980", Offset = "0x282F780", VA = "0x182830980", Slot = "6")]
		public void CCEKONHOCJK(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2830A40", Offset = "0x282F840", VA = "0x182830A40", Slot = "4")]
		private ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>> KJGKFOLLCGC(int ENLNOINJDEG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2830AB0", Offset = "0x282F8B0", VA = "0x182830AB0", Slot = "5")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> KGFCMBOCDFL(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> GLAOLHCPLLG, [In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct HEHIEFEDCNJ : MHJCEMHJFNF<BIHBDMOHDCK<KAJIMMHBMBI>, PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28326B0", Offset = "0x28314B0", VA = "0x1828326B0")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2832680", Offset = "0x2831480", VA = "0x182832680", Slot = "4")]
		public BIHBDMOHDCK<KAJIMMHBMBI> JGMMOEAOJHK(int GLAOLHCPLLG)
		{
			return default(BIHBDMOHDCK<KAJIMMHBMBI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28325F0", Offset = "0x28313F0", VA = "0x1828325F0")]
		public bool APFJFLMPAOP(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28325F0", Offset = "0x28313F0", VA = "0x1828325F0", Slot = "5")]
		private bool DFMHCLGBJBK(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2832670", Offset = "0x2831470", VA = "0x182832670", Slot = "6")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> EDFMHOGIOPD(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DMDKEPPBNCI : PGBAHJBLIMK<BIHBDMOHDCK<KAJIMMHBMBI>, PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2830C70", Offset = "0x282FA70", VA = "0x182830C70")]
		public ILLOCPJIIID<BIHBDMOHDCK<KAJIMMHBMBI>> IGKLBDGHCCP(int ENLNOINJDEG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<BIHBDMOHDCK<KAJIMMHBMBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2830CE0", Offset = "0x282FAE0", VA = "0x182830CE0")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2830B90", Offset = "0x282F990", VA = "0x182830B90", Slot = "6")]
		public void CCEKONHOCJK(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2830C70", Offset = "0x282FA70", VA = "0x182830C70", Slot = "4")]
		private ILLOCPJIIID<BIHBDMOHDCK<KAJIMMHBMBI>> CGNDOCNPDCO(int ENLNOINJDEG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<BIHBDMOHDCK<KAJIMMHBMBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2830DB0", Offset = "0x282FBB0", VA = "0x182830DB0", Slot = "5")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OCLLFOJDPBI(BIHBDMOHDCK<KAJIMMHBMBI> GLAOLHCPLLG, [In] PKGDJDPCMOK<KAJIMMHBMBI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>?> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct JGBBGDHLGAI : MHJCEMHJFNF<int, ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2832A20", Offset = "0x2831820", VA = "0x182832A20")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA88B50", Offset = "0xA87950", VA = "0x180A88B50", Slot = "4")]
		public int JGMMOEAOJHK(int GLAOLHCPLLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		public bool APFJFLMPAOP(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "5")]
		private bool EMDDBOAKNII(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2832A10", Offset = "0x2831810", VA = "0x182832A10", Slot = "6")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> BEMCHELHEHD(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct NGNOGNDOKEP : PGBAHJBLIMK<int, ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28369A0", Offset = "0x28357A0", VA = "0x1828369A0")]
		public ILLOCPJIIID<int> IGKLBDGHCCP(int ENLNOINJDEG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2836A10", Offset = "0x2835810", VA = "0x182836A10")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28368A0", Offset = "0x28356A0", VA = "0x1828368A0", Slot = "6")]
		public void CCEKONHOCJK(int GLAOLHCPLLG, ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28369A0", Offset = "0x28357A0", VA = "0x1828369A0", Slot = "4")]
		private ILLOCPJIIID<int> HJJKFCAGFFM(int ENLNOINJDEG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2836AB0", Offset = "0x28358B0", VA = "0x182836AB0", Slot = "5")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OMOGIMFIGKI(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> VariableId, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<KCJNEKDGPOB>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct LNGOCAGFEFH : MHJCEMHJFNF<int, ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2835410", Offset = "0x2834210", VA = "0x182835410")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA88B50", Offset = "0xA87950", VA = "0x180A88B50", Slot = "4")]
		public int JGMMOEAOJHK(int GLAOLHCPLLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		public bool APFJFLMPAOP(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "5")]
		private bool BHAAAJAMMHA(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2835400", Offset = "0x2834200", VA = "0x182835400", Slot = "6")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> FMMGCICKIDN(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct MNLLBKLLJJA : PGBAHJBLIMK<int, ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28362E0", Offset = "0x28350E0", VA = "0x1828362E0")]
		public ILLOCPJIIID<int> IGKLBDGHCCP(int ENLNOINJDEG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2836350", Offset = "0x2835150", VA = "0x182836350")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28361F0", Offset = "0x2834FF0", VA = "0x1828361F0", Slot = "6")]
		public void CCEKONHOCJK(int GLAOLHCPLLG, ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28362E0", Offset = "0x28350E0", VA = "0x1828362E0", Slot = "4")]
		private ILLOCPJIIID<int> OMIHBNCPEIN(int ENLNOINJDEG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28361E0", Offset = "0x2834FE0", VA = "0x1828361E0", Slot = "5")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> BIGPPDPIMJH(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct PJPFBGMMEPN : MHJCEMHJFNF<int, ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x283C0B0", Offset = "0x283AEB0", VA = "0x18283C0B0")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA88B50", Offset = "0xA87950", VA = "0x180A88B50", Slot = "4")]
		public int JGMMOEAOJHK(int GLAOLHCPLLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		public bool APFJFLMPAOP(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "5")]
		private bool BHAAAJAMMHA(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x283C0A0", Offset = "0x283AEA0", VA = "0x18283C0A0", Slot = "6")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> FMMGCICKIDN(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct EBFODEGMBEP : PGBAHJBLIMK<int, ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2830ED0", Offset = "0x282FCD0", VA = "0x182830ED0")]
		public ILLOCPJIIID<int> IGKLBDGHCCP(int ENLNOINJDEG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2830F40", Offset = "0x282FD40", VA = "0x182830F40")]
		public BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2830DD0", Offset = "0x282FBD0", VA = "0x182830DD0", Slot = "6")]
		public void CCEKONHOCJK(int GLAOLHCPLLG, ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2830ED0", Offset = "0x282FCD0", VA = "0x182830ED0", Slot = "4")]
		private ILLOCPJIIID<int> OMIHBNCPEIN(int ENLNOINJDEG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(ILLOCPJIIID<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2830DC0", Offset = "0x282FBC0", VA = "0x182830DC0", Slot = "5")]
		private BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> BIGPPDPIMJH(int GLAOLHCPLLG, [In] ILLOCPJIIID<(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> Target, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ByteCodeWriteLocation)> BGBLHEHBHCD)
		{
			return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct KGJBCJGPKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> PPFGDINLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool BCHGOFPPBIA;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1ECCB00", Offset = "0x1ECB900", VA = "0x181ECCB00")]
		public KGJBCJGPKJO(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK, bool IABHIOCJMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2832B80", Offset = "0x2831980", VA = "0x182832B80")]
		public void GOKNENBJBKI([Out] BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK, [Out] bool IABHIOCJMGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct NOKEHBHHMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly BIHBDMOHDCK<KAJIMMHBMBI> KBHKCCNANLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> PPFGDINLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool BCHGOFPPBIA;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2836BF0", Offset = "0x28359F0", VA = "0x182836BF0")]
		public NOKEHBHHMEH(BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK, bool IABHIOCJMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2836BC0", Offset = "0x28359C0", VA = "0x182836BC0")]
		public void GOKNENBJBKI([Out] BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK, [Out] bool IABHIOCJMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2836BD0", Offset = "0x28359D0", VA = "0x182836BD0")]
		public void GOKNENBJBKI([Out] BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK, [Out] BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP, [Out] bool IABHIOCJMGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NKEJMCIEBDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly BIHBDMOHDCK<KAJIMMHBMBI> KBHKCCNANLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> PPFGDINLENL;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public NKEJMCIEBDK(BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2836AC0", Offset = "0x28358C0", VA = "0x182836AC0")]
		public void GOKNENBJBKI([Out] BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK, [Out] BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2833B50", Offset = "0x2832950", VA = "0x182833B50")]
	public static void KCGBACPBOON(this MFCBJDHCPAI FPFHIDBMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2832DE0", Offset = "0x2831BE0", VA = "0x182832DE0")]
	public static void BIPGJCEHEEA(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> AOCJIABLDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2835330", Offset = "0x2834130", VA = "0x182835330")]
	public static void PPJEFPINANB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> AOCJIABLDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28338E0", Offset = "0x28326E0", VA = "0x1828338E0")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>? ILDLFEPFNLC([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2832E70", Offset = "0x2831C70", VA = "0x182832E70")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> BMPDFPCMNMG([In] this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2834D60", Offset = "0x2833B60", VA = "0x182834D60")]
	private static void PEBNFLENADD(this MFCBJDHCPAI FPFHIDBMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2833820", Offset = "0x2832620", VA = "0x182833820")]
	private static BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>? IFKIBAFDPDD([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x28339A0", Offset = "0x28327A0", VA = "0x1828339A0")]
	public static void JIJPJNJLIIJ(this MFCBJDHCPAI FPFHIDBMBMI, [In] ILLOCPJIIID<FFCDBHLPPDI> HBGACPFMIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2834710", Offset = "0x2833510", VA = "0x182834710")]
	public static HDHIMHFEGFO.NCNJOJCKNFB NKIJHJAENFP([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
	{
		return default(HDHIMHFEGFO.NCNJOJCKNFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2833320", Offset = "0x2832120", VA = "0x182833320")]
	public static GFHLACIIHGI<byte> FBIAHCFKIDK([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
	{
		return default(GFHLACIIHGI<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x28344E0", Offset = "0x28332E0", VA = "0x1828344E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NBLCACMAPAI([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28345D0", Offset = "0x28333D0", VA = "0x1828345D0")]
	public static JGAKLEJADPA NHAFDKJMAKI([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39E30E0", Offset = "0x39E1EE0", VA = "0x1839E30E0")]
	private static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> KLDMPCALDBO<TMJoin>(this MFCBJDHCPAI FPFHIDBMBMI, HDHIMHFEGFO.NCNJOJCKNFB APGBNCJIIBJ, BIHBDMOHDCK<TMJoin> ABCAMPEJDPJ) where TMJoin : HDHIMHFEGFO.NNNKPLMGOOB
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2833FD0", Offset = "0x2832DD0", VA = "0x182833FD0")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> KDELGCCEKMJ(this MFCBJDHCPAI FPFHIDBMBMI, bool NAPLFCKHPOA)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2833140", Offset = "0x2831F40", VA = "0x182833140")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> EDFGJFBANBJ(this MFCBJDHCPAI FPFHIDBMBMI, GFHLACIIHGI<byte> HNAKMABCJKP)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28332A0", Offset = "0x28320A0", VA = "0x1828332A0")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> EOLGEKEFJNB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> GAAPEMAAMCK)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2834460", Offset = "0x2833260", VA = "0x182834460")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> NBDLMPIAGBN(this MFCBJDHCPAI FPFHIDBMBMI, int LAFDPDDBBCC)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28330C0", Offset = "0x2831EC0", VA = "0x1828330C0")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DOLDFCOOADL(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x39E2990", Offset = "0x39E1790", VA = "0x1839E2990")]
	private static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> CKDDJKNIFDK<TMJoin>(this MFCBJDHCPAI FPFHIDBMBMI, HPLPPPOAOOE.ELPFGLAKFPO APGBNCJIIBJ, BIHBDMOHDCK<TMJoin> ABCAMPEJDPJ) where TMJoin : HPLPPPOAOOE.EHHMLNEIGOK
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2833B10", Offset = "0x2832910", VA = "0x182833B10")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> KCBBJOAEMPM(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2833500", Offset = "0x2832300", VA = "0x182833500")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> FPACNKBCCEE(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2834190", Offset = "0x2832F90", VA = "0x182834190")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> KLHHIFPHBID(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> BMEFIEBEDAH)
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28346C0", Offset = "0x28334C0", VA = "0x1828346C0")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> NIOHECIJHKA(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2834210", Offset = "0x2833010", VA = "0x182834210")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> KPANCCBKIMO(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28350D0", Offset = "0x2833ED0", VA = "0x1828350D0")]
	public static NDDLNHCCKHE.DPNIPFLBAKA PJAOLPACFFH([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> PMPBJNCHCLF)
	{
		return default(NDDLNHCCKHE.DPNIPFLBAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2833550", Offset = "0x2832350", VA = "0x182833550")]
	public static BFALJONNEBA<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>, GPJHFGEJFOP<NDDLNHCCKHE.GFLMMGLPNAP>> HJFAMIBJMIO([In] this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BFALJONNEBA<BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>, GPJHFGEJFOP<NDDLNHCCKHE.GFLMMGLPNAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2835150", Offset = "0x2833F50", VA = "0x182835150")]
	public static BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> PNNFKDBEEKI([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> PMPBJNCHCLF)
	{
		return default(BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2834790", Offset = "0x2833590", VA = "0x182834790")]
	public static NDDLNHCCKHE.DFNCCCCPNHK NKOJPAADBKE([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> HGGBHBECGAF)
	{
		return default(NDDLNHCCKHE.DFNCCCCPNHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2834B30", Offset = "0x2833930", VA = "0x182834B30")]
	public static NDDLNHCCKHE.DFNCCCCPNHK OCOAFBOJNHL(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> HGGBHBECGAF)
	{
		return default(NDDLNHCCKHE.DFNCCCCPNHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39E4500", Offset = "0x39E3300", VA = "0x1839E4500")]
	private static BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> NBNGKGKNOAP<TMJoin>(this MFCBJDHCPAI FPFHIDBMBMI, NDDLNHCCKHE.DPNIPFLBAKA APGBNCJIIBJ, BIHBDMOHDCK<TMJoin> ABCAMPEJDPJ) where TMJoin : NDDLNHCCKHE.ACPELCAIBID
	{
		return default(BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2833E20", Offset = "0x2832C20", VA = "0x182833E20")]
	public static (BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>) KCNNMLELHIF(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default((BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2834BB0", Offset = "0x28339B0", VA = "0x182834BB0")]
	public static (BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>) OPKEEMMGEOD(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default((BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2834810", Offset = "0x2833610", VA = "0x182834810")]
	public static BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> NNIAJHLGBHB(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2832F40", Offset = "0x2831D40", VA = "0x182832F40")]
	public static void CDJCGHECCPJ(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP> HGGBHBECGAF, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> CLIGMJPPHPI, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>> IAKOKAHCEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39E36D0", Offset = "0x39E24D0", VA = "0x1839E36D0")]
	public static KGJBCJGPKJO MPPABHCLNPP<TDeps, TStateSys>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP) where TDeps : OKFGPKEGCFO<TStateSys>
	{
		return default(KGJBCJGPKJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39E45A0", Offset = "0x39E33A0", VA = "0x1839E45A0")]
	public static NOKEHBHHMEH NIOADBJEJMO<TDeps, TStateSys>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, int NDLHLMPDBHK) where TDeps : OKFGPKEGCFO<TStateSys>
	{
		return default(NOKEHBHHMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39E3290", Offset = "0x39E2090", VA = "0x1839E3290")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>? MPHFDEFFMFC<TDeps, TStateSys>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, [In] ReadOnlySpan<int> GEADJBNHBCC, [In] Span<NKEJMCIEBDK> NLHHKNFBEDD) where TDeps : OKFGPKEGCFO<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39E2A40", Offset = "0x39E1840", VA = "0x1839E2A40")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> EMKENEEDBLH<TDeps, TStateSys>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH) where TDeps : OKFGPKEGCFO<TStateSys>
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2834860", Offset = "0x2833660", VA = "0x182834860")]
	public static GPOPFECGMGC.BOMBIHDDGDM NOCLGAIGHOO([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO)
	{
		return default(GPOPFECGMGC.BOMBIHDDGDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2833410", Offset = "0x2832210", VA = "0x182833410")]
	public static GPOPFECGMGC.JOEKDKLDHOP FHCKOHFAPLL([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO)
	{
		return default(GPOPFECGMGC.JOEKDKLDHOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2833590", Offset = "0x2832390", VA = "0x182833590")]
	public static GPOPFECGMGC.APMNNHOLCHC HKOFPJEADNG([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO)
	{
		return default(GPOPFECGMGC.APMNNHOLCHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2834F40", Offset = "0x2833D40", VA = "0x182834F40")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PIEGHEDMNLA(this MFCBJDHCPAI FPFHIDBMBMI, int? JEOJCKBFAJI, string IHGFMOMOADA)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2833730", Offset = "0x2832530", VA = "0x182833730")]
	public static GPOPFECGMGC.DLMMNGECMJG IFADNMDMGLD([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO)
	{
		return default(GPOPFECGMGC.DLMMNGECMJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2834ED0", Offset = "0x2833CD0", VA = "0x182834ED0")]
	public static GPOPFECGMGC.EKAJFJJMCDN PGEADJMMFBB([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO)
	{
		return default(GPOPFECGMGC.EKAJFJJMCDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2832ED0", Offset = "0x2831CD0", VA = "0x182832ED0")]
	public static int? CCMDBMJNDKE([In] this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x39E3190", Offset = "0x39E1F90", VA = "0x1839E3190")]
	private static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LAEIJPNAEJG<TMJoin>(this MFCBJDHCPAI FPFHIDBMBMI, int? JEOJCKBFAJI, GPOPFECGMGC.EKAJFJJMCDN APGBNCJIIBJ, BIHBDMOHDCK<TMJoin> ABCAMPEJDPJ) where TMJoin : GPOPFECGMGC.ENDPMMDDLME
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2833680", Offset = "0x2832480", VA = "0x182833680")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> IBCEINEKJKN(this MFCBJDHCPAI FPFHIDBMBMI, int? JEOJCKBFAJI, BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> PMPBJNCHCLF, int GLAOLHCPLLG)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2833060", Offset = "0x2831E60", VA = "0x182833060")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> DLOHIDGIBGH(this MFCBJDHCPAI FPFHIDBMBMI, int? JEOJCKBFAJI)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2834950", Offset = "0x2833750", VA = "0x182834950")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NOHHNBCMFEI(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? MKFOCDPPMCE, int? JEOJCKBFAJI)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2834AA0", Offset = "0x28338A0", VA = "0x182834AA0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NOMJJDIMLLF(this MFCBJDHCPAI FPFHIDBMBMI, int? JEOJCKBFAJI, int GLAOLHCPLLG)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2832D80", Offset = "0x2831B80", VA = "0x182832D80")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> AJCLMFFKEKF(this MFCBJDHCPAI FPFHIDBMBMI, int? JEOJCKBFAJI)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2834050", Offset = "0x2832E50", VA = "0x182834050")]
	public static void KGBBPEJGHCM(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC, BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> PMPBJNCHCLF, int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2834260", Offset = "0x2833060", VA = "0x182834260")]
	public static void LNOEHHKMCBJ(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC, int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2834390", Offset = "0x2833190", VA = "0x182834390")]
	public static void MCAPAOLNCNB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2832FD0", Offset = "0x2831DD0", VA = "0x182832FD0")]
	public static void CGFGACAAJGG(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> GDCDKMJLKDH, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> PCCOCMOJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28331D0", Offset = "0x2831FD0", VA = "0x1828331D0")]
	public static void EJEGJEMKGDK(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC, BIHBDMOHDCK<ADGOJNBMGKF<BJLBLNDMAOC>> JIKCAFCOPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x39E3010", Offset = "0x39E1E10", VA = "0x1839E3010")]
	public static void KCJLBLJAMMB<M>(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHHEHCAHNJC, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<M>>> JIKCAFCOPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OKFGPKEGCFO<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIHBDMOHDCK<COMGLGJNOJA> FBLALJKEDNB(TStateSys PDOJEMMACGM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BIHBDMOHDCK<COMGLGJNOJA> CMEDFLHNCBB(TStateSys PDOJEMMACGM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BIHBDMOHDCK<COMGLGJNOJA> EOJGAKJOCIH(TStateSys PDOJEMMACGM);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BIHBDMOHDCK<COMGLGJNOJA> HACEFCIMHDG(TStateSys PDOJEMMACGM);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> DBNADHHEPPB(TStateSys PDOJEMMACGM, MFCBJDHCPAI KLOOJMLFHKG, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> BKJDALMOPMB(TStateSys PDOJEMMACGM, MFCBJDHCPAI KLOOJMLFHKG, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FLNHBDEEDEG(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BIHBDMOHDCK<IEDJJDGMFHP> NDHGDBACJHN(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP, int DLHBKKAFANL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OKCADJGJJNI KBAFOEPJBDA(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AAMBGHEIIGK(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int AMDPMDHNKIA(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GFHLACIIHGI<byte> KLNAMIAODBE(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(GFHLACIIHGI<byte>, BIHBDMOHDCK<COMGLGJNOJA>) BKDEILKKJDJ(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int NDEODMPEAHO(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BIHBDMOHDCK<KAJIMMHBMBI> BMNOBIKBBEJ(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH, int NDLHLMPDBHK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BIHBDMOHDCK<KAJIMMHBMBI> EDDMJCPINCK(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, int NDLHLMPDBHK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int FHJEFOFLHFC(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? KLOOPLLPBEI(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int ENOHIFMLBKO(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? CINMMACGNKG(TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, int GLAOLHCPLLG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OLIDAELDDCF
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B099F0", Offset = "0x3B087F0", VA = "0x183B099F0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK?> BOOHOOPKFOD<T, TOpInput, TOpOutput>(this MFCBJDHCPAI FPFHIDBMBMI, T ALCLKCHJGII, T GFJPONDOIDH, int DLCLEEKMKJH, IntPtr AFMCKLODPDE)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B1E0", Offset = "0x3B09FE0", VA = "0x183B0B1E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK?> JNIOKAHKOFP<T, TOpInput, TOpOutput>(this MFCBJDHCPAI FPFHIDBMBMI, T ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH, int DLCLEEKMKJH, IntPtr AFMCKLODPDE)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B09DF0", Offset = "0x3B08BF0", VA = "0x183B09DF0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK?> IAJLBBAJHNL<TOpInput, TOpOutput>(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH, int DLCLEEKMKJH, IntPtr AFMCKLODPDE)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x283B130", Offset = "0x2839F30", VA = "0x18283B130")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NOEEJOEAKHG(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2838E30", Offset = "0x2837C30", VA = "0x182838E30")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> IKAAPNHJLIP(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2837E80", Offset = "0x2836C80", VA = "0x182837E80")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> EIINMKDGOBB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2839920", Offset = "0x2838720", VA = "0x182839920")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LFNKKKGOFBD(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2837B60", Offset = "0x2836960", VA = "0x182837B60")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> DEDDKKOKMKG(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x28374C0", Offset = "0x28362C0", VA = "0x1828374C0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> CEDKJOMHDPF(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2837600", Offset = "0x2836400", VA = "0x182837600")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> CHHLHGPCOJO(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x28373A0", Offset = "0x28361A0", VA = "0x1828373A0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> BMBFLBGHLHL(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x28385E0", Offset = "0x28373E0", VA = "0x1828385E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GJAEKLOMPGB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x283B230", Offset = "0x283A030", VA = "0x18283B230")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OBJKOEJEDEL(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, int GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2837140", Offset = "0x2835F40", VA = "0x182837140")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> BCPIDCIAPAI(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2839760", Offset = "0x2838560", VA = "0x182839760")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LFFOBPFDKBF(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2837700", Offset = "0x2836500", VA = "0x182837700")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> CLPIDPAKLHO(this MFCBJDHCPAI FPFHIDBMBMI, float ALCLKCHJGII, float GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x283BA00", Offset = "0x283A800", VA = "0x18283BA00")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PGLKOMLKFHJ(this MFCBJDHCPAI FPFHIDBMBMI, float ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x28391B0", Offset = "0x2837FB0", VA = "0x1828391B0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> JANEDHLKBEK(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x283B440", Offset = "0x283A240", VA = "0x18283B440")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OGMFNININII(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, int GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x283AA10", Offset = "0x2839810", VA = "0x18283AA10")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MOMEPLELECO(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x283BB30", Offset = "0x283A930", VA = "0x18283BB30")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PLNGIDJFPJB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2838350", Offset = "0x2837150", VA = "0x182838350")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FBPHKHOGIHD(this MFCBJDHCPAI FPFHIDBMBMI, float ALCLKCHJGII, float GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x283AC90", Offset = "0x2839A90", VA = "0x18283AC90")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NHDGOHEPBKD(this MFCBJDHCPAI FPFHIDBMBMI, float ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2838940", Offset = "0x2837740", VA = "0x182838940")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> HEACHBIABJJ(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2838840", Offset = "0x2837640", VA = "0x182838840")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GJNODDMJAIP(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, int GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x28388C0", Offset = "0x28376C0", VA = "0x1828388C0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GLFPLPLAKPM(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2839A20", Offset = "0x2838820", VA = "0x182839A20")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LHKCJNCMIHL(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x28370C0", Offset = "0x2835EC0", VA = "0x1828370C0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> BBMLEODMOAG(this MFCBJDHCPAI FPFHIDBMBMI, float ALCLKCHJGII, float GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x28396E0", Offset = "0x28384E0", VA = "0x1828396E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LACIPCFKFFK(this MFCBJDHCPAI FPFHIDBMBMI, float ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2839660", Offset = "0x2838460", VA = "0x182839660")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> KNOILEJEOMB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x283A320", Offset = "0x2839120", VA = "0x18283A320")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> MFMBPKADKLN(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2838BF0", Offset = "0x28379F0", VA = "0x182838BF0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ICHNFDNPGKK(this MFCBJDHCPAI FPFHIDBMBMI, int OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x283B5C0", Offset = "0x283A3C0", VA = "0x18283B5C0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> OJOOCOEKFAM(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2836E90", Offset = "0x2835C90", VA = "0x182836E90")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> ANDJJGFDDPC(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DCPMIEMJNIK)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2838DB0", Offset = "0x2837BB0", VA = "0x182838DB0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> IEHPOCMDGNO(this MFCBJDHCPAI FPFHIDBMBMI, int OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x283AD10", Offset = "0x2839B10", VA = "0x18283AD10")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> NHGJCJBFAPI(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2839EE0", Offset = "0x2838CE0", VA = "0x182839EE0")]
	public static (BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>) MCONMEPDIHK(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<INPOHEFJEKC> NCIPEHGKLBM, [In] ReadOnlySpan<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> PECPDCLIACL, [In] ReadOnlySpan<int?> AHPINIJEKOD, [In] Span<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> AOEIIGPDHKK)
	{
		return default((BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x283A5D0", Offset = "0x28393D0", VA = "0x18283A5D0")]
	public static (BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>) MNCEALEACNC(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<MMOKPEAHMGL> BHAJIJJDLDE, [In] ReadOnlySpan<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> PECPDCLIACL, [In] ReadOnlySpan<int?> AHPINIJEKOD, [In] Span<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> AOEIIGPDHKK)
	{
		return default((BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B09CF0", Offset = "0x3B08AF0", VA = "0x183B09CF0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<COMGLGJNOJA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<TMarker>>, BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>) GODNMJJCKNI<TMarker>(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<COMGLGJNOJA> OEJHNGOKIIK, [In] ReadOnlySpan<byte> FFEMKICJPKP)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<COMGLGJNOJA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<TMarker>>, BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x283ABD0", Offset = "0x28399D0", VA = "0x18283ABD0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NGJCAGHELKH(this MFCBJDHCPAI FPFHIDBMBMI, int HLHNGKLKCFJ, [Optional] BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2836C80", Offset = "0x2835A80", VA = "0x182836C80")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ACCJPJFEOGM(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> HLHNGKLKCFJ, [Optional] BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28384F0", Offset = "0x28372F0", VA = "0x1828384F0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FMGNKJACFDL(this MFCBJDHCPAI FPFHIDBMBMI, [In] ReadOnlySpan<byte> HLHNGKLKCFJ, [Optional] BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28383D0", Offset = "0x28371D0", VA = "0x1828383D0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FGJOJOJPMMG(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> HLHNGKLKCFJ, int ACINDEOBNPO, [Optional] BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x283B660", Offset = "0x283A460", VA = "0x18283B660")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OLBKFBIADHI(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2836D70", Offset = "0x2835B70", VA = "0x182836D70")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> AMDKFHJHAIE(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x283BBB0", Offset = "0x283A9B0", VA = "0x18283BBB0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PNMDMIJCDEM(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2837D80", Offset = "0x2836B80", VA = "0x182837D80")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> DNCBDLECKBC(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2839540", Offset = "0x2838340", VA = "0x182839540")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> KMHNCPOFOEG(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2838C70", Offset = "0x2837A70", VA = "0x182838C70")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> IDDJEIEGNKH(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x28398A0", Offset = "0x28386A0", VA = "0x1828398A0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LFGMKHLDFOH(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, int GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x283B760", Offset = "0x283A560", VA = "0x18283B760")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PCEOEJNPBDF(this MFCBJDHCPAI FPFHIDBMBMI, int ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2837040", Offset = "0x2835E40", VA = "0x182837040")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> APLMEMAOBED(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ALCLKCHJGII, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GFJPONDOIDH)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x283B340", Offset = "0x283A140", VA = "0x18283B340")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OGKGGDMKCLN(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2838220", Offset = "0x2837020", VA = "0x182838220")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FAPMPCFFAML(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2837A20", Offset = "0x2836820", VA = "0x182837A20")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> DBBIBHAOGAO(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x283BE30", Offset = "0x283AC30", VA = "0x18283BE30")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> POLNOOCKKHB(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2837FC0", Offset = "0x2836DC0", VA = "0x182837FC0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> ELIJLAFKBCE(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x28380E0", Offset = "0x2836EE0", VA = "0x1828380E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> EPFNJNAGLFH(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2838BD0", Offset = "0x28379D0", VA = "0x182838BD0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>> HNMKJOFPOLD(this MFCBJDHCPAI FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x283A4D0", Offset = "0x28392D0", VA = "0x18283A4D0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MJMPMDGGPNJ(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2838720", Offset = "0x2837520", VA = "0x182838720")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> GJMFIBONKAO(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2837260", Offset = "0x2836060", VA = "0x182837260")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> BIFOJOIGAII(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x283B4C0", Offset = "0x283A2C0", VA = "0x18283B4C0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OJKGKEHKHJA(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2839420", Offset = "0x2838220", VA = "0x182839420")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> KJBICCIMHMH(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x283AA90", Offset = "0x2839890", VA = "0x18283AA90")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NCOLPPHJJNG(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2837800", Offset = "0x2836600", VA = "0x182837800")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> CMDOHMAONLN(this MFCBJDHCPAI FPFHIDBMBMI, int OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2838AC0", Offset = "0x28378C0", VA = "0x182838AC0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> HLKHPCMKNII(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x283B330", Offset = "0x283A130", VA = "0x18283B330")]
	public static void OFHBEAOIOJD(this MFCBJDHCPAI FPFHIDBMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x283B7E0", Offset = "0x283A5E0", VA = "0x18283B7E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PFDNHIOLODA(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2837900", Offset = "0x2836700", VA = "0x182837900")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> DAFHJEIBCHI(this MFCBJDHCPAI FPFHIDBMBMI, float MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2839AA0", Offset = "0x28388A0", VA = "0x182839AA0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MBDNMLHDCAI(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2837C80", Offset = "0x2836A80", VA = "0x182837C80")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> DLANHGIFEKH(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x283B8E0", Offset = "0x283A6E0", VA = "0x18283B8E0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PFINEDDFKAO(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x283BCF0", Offset = "0x283AAF0", VA = "0x18283BCF0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> POBKBEGAMCF(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x283ADB0", Offset = "0x2839BB0", VA = "0x18283ADB0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> NIPDLJNHHDO(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> IOEBKDDPEKB, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> HDJHMEJFAOB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x28389C0", Offset = "0x28377C0", VA = "0x1828389C0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> HICCNJJNINJ(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2839090", Offset = "0x2837E90", VA = "0x182839090")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> JAIJIDIJOIA(this MFCBJDHCPAI FPFHIDBMBMI, int MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2838F50", Offset = "0x2837D50", VA = "0x182838F50")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INEIKIKGOFK(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MIKFBKFKEIN, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> INLNMLHPBKB)
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3B09F60", Offset = "0x3B08D60", VA = "0x183B09F60")]
	public static void JCPGPDHKACL<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<INPOHEFJEKC> NCIPEHGKLBM, [In] ReadOnlySpan<BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>> DOAFNJMDMDJ, [In] ReadOnlySpan<int?> AHPINIJEKOD, [In] Span<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> AOEIIGPDHKK, [In] Span<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> EHFBDBIMIIN, [In] ReadOnlySpan<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>?> BICEAFOOGDE) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3B0BD70", Offset = "0x3B0AB70", VA = "0x183B0BD70")]
	public static void LMANFOPJJHM<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<MMOKPEAHMGL> HPCIBKDHMEA, [In] ReadOnlySpan<BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>> HIBIEIAFJEO, [In] ReadOnlySpan<int?> AHPINIJEKOD, [In] Span<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> AOEIIGPDHKK, [In] Span<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>> EHFBDBIMIIN, [In] ReadOnlySpan<BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>?> BICEAFOOGDE) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C310", Offset = "0x3B0B110", VA = "0x183B0C310")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MBIOMICPKNP<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> MKFOCDPPMCE, [Optional] BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C4F0", Offset = "0x3B0B2F0", VA = "0x183B0C4F0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> PPMAPHEJEPK<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> BMEFIEBEDAH, [Optional] BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B580", Offset = "0x3B0A380", VA = "0x183B0B580")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> KACGBEHFNMN<TDeps, TStateSys>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM) where TDeps : notnull, OKFGPKEGCFO<TStateSys> where TStateSys : notnull
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B7B0", Offset = "0x3B0A5B0", VA = "0x183B0B7B0")]
	public static BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP> KFNOHAPEFFK<TDeps, TStateSys>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM) where TDeps : notnull, OKFGPKEGCFO<TStateSys> where TStateSys : notnull
	{
		return default(BIHBDMOHDCK<HPLPPPOAOOE.IENMPEPLKGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x28392F0", Offset = "0x28380F0", VA = "0x1828392F0")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> JEJFNHMJAFO(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> DIKDIOEGGBO, IntPtr MAJEOOCOAMI, IntPtr MMJEDNOCGOD)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2839BE0", Offset = "0x28389E0", VA = "0x182839BE0")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> MBFKFEGHDBB(this MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> CFIHIHPNHLP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> PBDGHGGNIBC, IntPtr BMKIBBCKAOF, IntPtr ANOGPBIDKAO, IntPtr IFPGFGLMCNF, bool FBDGHLEDJLI)
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A500", Offset = "0x3B09300", VA = "0x183B0A500")]
	public static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> JFIKCCKPNAB<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<INPOHEFJEKC> NHIMGPCFIAG, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> CFIHIHPNHLP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> PBDGHGGNIBC, int? ENLINBGGIGB, [Optional] IntPtr JJOELOFJBHF) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A710", Offset = "0x3B09510", VA = "0x183B0A710")]
	private static BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> JFIKCCKPNAB<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<INPOHEFJEKC> NHIMGPCFIAG, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> CFIHIHPNHLP, BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB> PBDGHGGNIBC, int? ENLINBGGIGB) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
		return default(BIHBDMOHDCK<HDHIMHFEGFO.PNNKJBNJKAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B9C0", Offset = "0x3B0A7C0", VA = "0x183B0B9C0")]
	public static BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> LFEBHABCOEC<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> HLHNGKLKCFJ, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>? GJCHJCHAFHC) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
		return default(BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AF50", Offset = "0x3B09D50", VA = "0x183B0AF50")]
	public static void JMCMEKPEEMD<TDeps, TState>(this MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TState JNOIIIFBOLM, int JNNPEAGGIMA) where TDeps : notnull, OKFGPKEGCFO<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct ICBEELOJIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> JFJLDMDPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> LJIKIPFDPKE;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
	public ICBEELOJIGL(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> JHLFJDHGBHG, BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> JHDNFPFFGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2832A00", Offset = "0x2831800", VA = "0x182832A00")]
	public static ICBEELOJIGL NBEICDCLFEE(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> JHLFJDHGBHG)
	{
		return default(ICBEELOJIGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GPOPFECGMGC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class POEJGEGBAFI : ENDPMMDDLME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct BOMBIHDDGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> MMNKJDFFAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int KBDABDGGLJF;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public BOMBIHDDGDM(BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> PMPBJNCHCLF, int GLAOLHCPLLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class EEFBAKFKLGD : ENDPMMDDLME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct JOEKDKLDHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int KBDABDGGLJF;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public JOEKDKLDHOP(int GLAOLHCPLLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class ADIFBDJCBNE : ENDPMMDDLME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct APMNNHOLCHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> MMNKJDFFAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int KBDABDGGLJF;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public APMNNHOLCHC(BIHBDMOHDCK<NDDLNHCCKHE.OPAOCKAFHIJ> PMPBJNCHCLF, int GLAOLHCPLLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum EKAJFJJMCDN
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
	public sealed class IMDDFJBDBFK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class ENDPMMDDLME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DKDKLDPENIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? KBBFJICKGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ICBEELOJIGL ODKFDLJEPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public EKAJFJJMCDN MPNOJFFBNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public BIHBDMOHDCK<ENDPMMDDLME> LMNKIPEFDDM;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2830B70", Offset = "0x282F970", VA = "0x182830B70")]
		public DKDKLDPENIC(int? JEOJCKBFAJI, [In] ICBEELOJIGL KLPMGADIAHB, EKAJFJJMCDN APGBNCJIIBJ, BIHBDMOHDCK<ENDPMMDDLME> ABCAMPEJDPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class DGHIBIHCKNN : ENDPMMDDLME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DLMMNGECMJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int KBDABDGGLJF;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		public DLMMNGECMJG(int GLAOLHCPLLG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal HAIPMHAADMB<IMDDFJBDBFK, DKDKLDPENIC> AJFGDLMDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal HAIPMHAADMB<POEJGEGBAFI, BOMBIHDDGDM> EEKCGJAAFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal HAIPMHAADMB<ADIFBDJCBNE, APMNNHOLCHC> GJHNKEJHJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal HAIPMHAADMB<DGHIBIHCKNN, DLMMNGECMJG> DDEACMJPOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal HAIPMHAADMB<EEFBAKFKLGD, JOEKDKLDHOP> JHBOHILLFOG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x28322F0", Offset = "0x28310F0", VA = "0x1828322F0")]
	private GPOPFECGMGC([In] HAIPMHAADMB<IMDDFJBDBFK, DKDKLDPENIC> OEFCCPAHHIO, [In] HAIPMHAADMB<POEJGEGBAFI, BOMBIHDDGDM> MIJLOHAAPGM, [In] HAIPMHAADMB<ADIFBDJCBNE, APMNNHOLCHC> FNMABGOFMJF, [In] HAIPMHAADMB<DGHIBIHCKNN, DLMMNGECMJG> BPPEGGKCNPP, [In] HAIPMHAADMB<EEFBAKFKLGD, JOEKDKLDHOP> DKLOLDPJECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2832100", Offset = "0x2830F00", VA = "0x182832100")]
	public static GPOPFECGMGC NBEICDCLFEE()
	{
		return default(GPOPFECGMGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class JGEELCPIFLL
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2832AC0", Offset = "0x28318C0", VA = "0x182832AC0")]
	public static void KCGBACPBOON(this GPOPFECGMGC FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FKOPCAHMFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2831390", Offset = "0x2830190", VA = "0x182831390")]
	public static void LECHDFIDIED(MFCBJDHCPAI FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct AEBEHOCNCHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, PBMHGHNPFOJ> CHPNJGAONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int ECIJLJMAFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int LNLHILOEAHC;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2830800", Offset = "0x282F600", VA = "0x182830800")]
	private AEBEHOCNCHB([In] PKGDJDPCMOK<NDDLNHCCKHE.GFLMMGLPNAP, PBMHGHNPFOJ> NMAMDJDDGBD, int ADCOAFDDMIK, int AFLPBHMLMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2830790", Offset = "0x282F590", VA = "0x182830790")]
	public static AEBEHOCNCHB NBEICDCLFEE()
	{
		return default(AEBEHOCNCHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x28305A0", Offset = "0x282F3A0", VA = "0x1828305A0")]
	public void KCGBACPBOON([In] MFCBJDHCPAI OHIGDHLLFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4145D70", Offset = "0x4144B70", VA = "0x184145D70")]
	public static void LECHDFIDIED<TDeps, TStateSys>(MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC) where TDeps : notnull, OKFGPKEGCFO<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NCMAIFJMMMO
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x28363F0", Offset = "0x28351F0", VA = "0x1828363F0")]
	public static void LECHDFIDIED(MFCBJDHCPAI FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HFJIAFFHPHC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface IHDFEOKGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EOADIFBLNKF(ILLOCPJIIID<byte> IADIONICCIC, int CDFCIFCLEBB);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct NFJCEGLDMLG : IHDFEOKGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2836820", Offset = "0x2835620", VA = "0x182836820", Slot = "4")]
		public void EOADIFBLNKF(ILLOCPJIIID<byte> IADIONICCIC, int CDFCIFCLEBB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct ADOGCOBDKDP : IHDFEOKGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28304F0", Offset = "0x282F2F0", VA = "0x1828304F0", Slot = "4")]
		public void EOADIFBLNKF(ILLOCPJIIID<byte> IADIONICCIC, int CDFCIFCLEBB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct CMNEILIOKOJ : IHDFEOKGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2830840", Offset = "0x282F640", VA = "0x182830840", Slot = "4")]
		public void EOADIFBLNKF(ILLOCPJIIID<byte> IADIONICCIC, int CDFCIFCLEBB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct HHHOAIJAFEG : IHDFEOKGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x28328C0", Offset = "0x28316C0", VA = "0x1828328C0", Slot = "4")]
		public void EOADIFBLNKF(ILLOCPJIIID<byte> IADIONICCIC, int CDFCIFCLEBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class GGBNFGNCKIA<TCallProcessorDeps> where TCallProcessorDeps : struct, IHDFEOKGGON
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps JLPOGPHFPCB;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3A76BC0", Offset = "0x3A759C0", VA = "0x183A76BC0")]
		public static int LECHDFIDIED<TDeps, TStateSys>(TDeps JCFBNAHPHAO, TStateSys JNOIIIFBOLM, MFCBJDHCPAI OHIGDHLLFPD, [In] ILLOCPJIIID<byte> AJPCHHOEFMB, int IGIBHMMKJBK) where TDeps : OKFGPKEGCFO<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private ILLOCPJIIID<FFCDBHLPPDI> KEOLINHEMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>> GGNLAMHPIOB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2832880", Offset = "0x2831680", VA = "0x182832880")]
	private HFJIAFFHPHC([In] ILLOCPJIIID<FFCDBHLPPDI> HBGACPFMIKO, Dictionary<BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<NDDLNHCCKHE.GFLMMGLPNAP>> CMGDGIBAEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x28327C0", Offset = "0x28315C0", VA = "0x1828327C0")]
	public static HFJIAFFHPHC NBEICDCLFEE()
	{
		return default(HFJIAFFHPHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2832780", Offset = "0x2831580", VA = "0x182832780")]
	public void KCGBACPBOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x391AFF0", Offset = "0x3919DF0", VA = "0x18391AFF0")]
	public static void LECHDFIDIED<TDeps, TStateSys>(MFCBJDHCPAI FPFHIDBMBMI, TDeps JCFBNAHPHAO, TStateSys PDOJEMMACGM) where TDeps : OKFGPKEGCFO<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FMFOFEFCKMG
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct IEELMDCGGBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> KKIFHGJBLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int GIKAHOHKMAM;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int HAOFAGNIFCP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int KAEDMFDOLLG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28318F0", Offset = "0x28306F0", VA = "0x1828318F0")]
	public static void LECHDFIDIED(MFCBJDHCPAI FPFHIDBMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2831630", Offset = "0x2830430", VA = "0x182831630")]
	private static void DILFMFJMHFM([In] MFCBJDHCPAI FPFHIDBMBMI, BIHBDMOHDCK<GPOPFECGMGC.IMDDFJBDBFK> FONJFDCCINO, ILLOCPJIIID<byte> HMPBGAIBLHN, List<IEELMDCGGBG> BFOIMPFDPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x28314F0", Offset = "0x28302F0", VA = "0x1828314F0")]
	private static void DILFMFJMHFM(ILLOCPJIIID<byte> HMPBGAIBLHN, int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x28317C0", Offset = "0x28305C0", VA = "0x1828317C0")]
	private static void KMKMIJEOIEF(MFCBJDHCPAI FPFHIDBMBMI, List<IEELMDCGGBG> BFOIMPFDPDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OEHGHIADBJJ<TDeps, TIndex, TValues> where TDeps : struct, PGBAHJBLIMK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps JLPOGPHFPCB;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x565E370", Offset = "0x565D170", VA = "0x18565E370")]
	public static void LECHDFIDIED([In] ILLOCPJIIID<FFCDBHLPPDI> HBGACPFMIKO, int ENLNOINJDEG, TValues BGBLHEHBHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface PGBAHJBLIMK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILLOCPJIIID<TIndex> IGKLBDGHCCP(int ENLNOINJDEG, [In] TValues BGBLHEHBHCD);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(TIndex GLAOLHCPLLG, [In] TValues BGBLHEHBHCD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCEKONHOCJK(TIndex GLAOLHCPLLG, TValues BGBLHEHBHCD, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface MHJCEMHJFNF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex JGMMOEAOJHK(int GLAOLHCPLLG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APFJFLMPAOP(TIndex GLAOLHCPLLG, [In] TValues BGBLHEHBHCD);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> MPMPMDDEOBJ(TIndex GLAOLHCPLLG, [In] TValues BGBLHEHBHCD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LBIAKHINBOE<TDeps, TIndex, TValues> where TDeps : struct, MHJCEMHJFNF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps JLPOGPHFPCB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5152790", Offset = "0x5151590", VA = "0x185152790")]
	public static ILLOCPJIIID<TIndex> LECHDFIDIED(int ENLNOINJDEG, [In] TValues BGBLHEHBHCD)
	{
		return default(ILLOCPJIIID<TIndex>);
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

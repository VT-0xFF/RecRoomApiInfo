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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2242F40", Offset = "0x2242340", VA = "0x182242F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JIIHHGBDKAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> ECNOFNNNAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int BLOODECNJKF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
	public JIIHHGBDKAG(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> FIGDNNLIGBB, int GMCJIJBLJPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JKJJMPLCJNA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class MIFDGBKLLPO : EPEGDGFJHAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct GEKHLNCLIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly IAPBPCHLGCB<byte> BEBEHBMFBEL;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21EA310", Offset = "0x21E9710", VA = "0x1821EA310")]
		public GEKHLNCLIAF(IAPBPCHLGCB<byte> HFHEELJJDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x223CC40", Offset = "0x223C040", VA = "0x18223CC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PKBFMIEILAE : EPEGDGFJHAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct NGLFLNHAKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> HOHIHJAEABD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public NGLFLNHAKGG(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> GEALFJGGJPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DDJOKINFPDO
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
	public sealed class CLIPNBCPPCB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class EPEGDGFJHAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OCGPMGDNDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DDJOKINFPDO KKFCEJBOMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly FGLBFCBPBCD<EPEGDGFJHAP> BLMBOAFPIHP;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		public OCGPMGDNDKK(DDJOKINFPDO LCAGNMGCPNA, FGLBFCBPBCD<EPEGDGFJHAP> HDKNKOIDEOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class JDEENHFEGHG : EPEGDGFJHAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct FFFOMAIAHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LGGEPJGCALJ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public FFFOMAIAHON(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class NNFOCBNCAKD : EPEGDGFJHAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct HFKEADGHLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KCFDAINDPGI KOEGJBPJILK;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public HFKEADGHLHG(KCFDAINDPGI OOILILNIBGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2241F60", Offset = "0x2241360", VA = "0x182241F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal AEOBADCBKBC<CLIPNBCPPCB, OCGPMGDNDKK> JGBPJMOFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal AEOBADCBKBC<MIFDGBKLLPO, GEKHLNCLIAF> OMMHBMLHPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal AEOBADCBKBC<PKBFMIEILAE, NGLFLNHAKGG> KHKJPLCMPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal AEOBADCBKBC<JDEENHFEGHG, FFFOMAIAHON> PKIIDMNGCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal AEOBADCBKBC<NNFOCBNCAKD, HFKEADGHLHG> CAHOGPICEIL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2242560", Offset = "0x2241960", VA = "0x182242560")]
	private JKJJMPLCJNA([In] AEOBADCBKBC<CLIPNBCPPCB, OCGPMGDNDKK> JHCGPAODEGN, [In] AEOBADCBKBC<MIFDGBKLLPO, GEKHLNCLIAF> DPJBOJBNIAG, [In] AEOBADCBKBC<PKBFMIEILAE, NGLFLNHAKGG> NAAGDCBDOJG, [In] AEOBADCBKBC<JDEENHFEGHG, FFFOMAIAHON> CHOEDJOJABP, [In] AEOBADCBKBC<NNFOCBNCAKD, HFKEADGHLHG> DGGHAKBAJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2242420", Offset = "0x2241820", VA = "0x182242420")]
	public static JKJJMPLCJNA AALKPJMFIHM()
	{
		return default(JKJJMPLCJNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MGMGGHNDNCL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2242900", Offset = "0x2241D00", VA = "0x182242900")]
	public static void LBHGGLOEOHI(this JKJJMPLCJNA MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum ALMIABIILEN
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
public struct DIDBDODMHOI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class FLAKLMKNENO : DCJHJFOFOFM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct PMIOJPFDLEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> AMEIOPGIPKM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public PMIOJPFDLEE(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> OLIJGIMGKCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HFJMFIKIBFM
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
	public sealed class ECHOMNBCDPB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class DCJHJFOFOFM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct JJLKBBACAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HFJMFIKIBFM KKFCEJBOMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly FGLBFCBPBCD<DCJHJFOFOFM> BLMBOAFPIHP;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		public JJLKBBACAOM(HFJMFIKIBFM LCAGNMGCPNA, FGLBFCBPBCD<DCJHJFOFOFM> HDKNKOIDEOI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal AEOBADCBKBC<ECHOMNBCDPB, JJLKBBACAOM> JGBPJMOFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal AEOBADCBKBC<FLAKLMKNENO, PMIOJPFDLEE> IGBAPOLHHGB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2239EA0", Offset = "0x22392A0", VA = "0x182239EA0")]
	private DIDBDODMHOI([In] AEOBADCBKBC<ECHOMNBCDPB, JJLKBBACAOM> JHCGPAODEGN, [In] AEOBADCBKBC<FLAKLMKNENO, PMIOJPFDLEE> KLIBKPDEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2239E10", Offset = "0x2239210", VA = "0x182239E10")]
	public static DIDBDODMHOI AALKPJMFIHM()
	{
		return default(DIDBDODMHOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BKGJEDFAKGK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2239990", Offset = "0x2238D90", VA = "0x182239990")]
	public static void LBHGGLOEOHI(this DIDBDODMHOI MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FDJDHJNBKJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public GCECACNENLC<int> HFAPAJNJDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public GCECACNENLC<int> PDMIPJJGBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int COEMLEACMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int HBBNKBHAECL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x223A250", Offset = "0x2239650", VA = "0x18223A250")]
	private FDJDHJNBKJJ([In] GCECACNENLC<int> LAMLIJBHMDM, [In] GCECACNENLC<int> ELPNAKNBJKN, int MKPCNBBECLN, int GKGAAEJNGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x223A1B0", Offset = "0x22395B0", VA = "0x18223A1B0")]
	public static FDJDHJNBKJJ AALKPJMFIHM()
	{
		return default(FDJDHJNBKJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IPAIFFBDNKO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22423D0", Offset = "0x22417D0", VA = "0x1822423D0")]
	public static void LBHGGLOEOHI(this FDJDHJNBKJJ MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BODAOMHCKMN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum IKMEAILIJGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class JMNNJAILABF : PHFCGHKLJHH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct MAFAMFEMMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly FGLBFCBPBCD<NDOOLALGJGO> HEHCBGNAHCI;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public MAFAMFEMMPM(FGLBFCBPBCD<NDOOLALGJGO> GKIBHMDFALE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class NEOGCEDPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class PHFCGHKLJHH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct MODPCPLILFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly IKMEAILIJGM KKFCEJBOMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly FGLBFCBPBCD<PHFCGHKLJHH> BLMBOAFPIHP;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		private MODPCPLILFH(IKMEAILIJGM LCAGNMGCPNA, FGLBFCBPBCD<PHFCGHKLJHH> HDKNKOIDEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x22429B0", Offset = "0x2241DB0", VA = "0x1822429B0")]
		public static MODPCPLILFH AALKPJMFIHM(IKMEAILIJGM LCAGNMGCPNA, FGLBFCBPBCD<PHFCGHKLJHH> HDKNKOIDEOI)
		{
			return default(MODPCPLILFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class JNAGNBLELPB : PHFCGHKLJHH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct BICMJACFMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly FGLBFCBPBCD<NDOOLALGJGO> HEHCBGNAHCI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public BICMJACFMKP(FGLBFCBPBCD<NDOOLALGJGO> GKIBHMDFALE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class NDOOLALGJGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct IIIPFNDNGIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public GCECACNENLC<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> NJACGBIPHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GCECACNENLC<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> JBDKFAIEPBM;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2239EA0", Offset = "0x22392A0", VA = "0x182239EA0")]
		private IIIPFNDNGIM([In] GCECACNENLC<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> IAGJCBIIDIO, [In] GCECACNENLC<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> EKCJOINJJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x22421F0", Offset = "0x22415F0", VA = "0x1822421F0")]
		public static IIIPFNDNGIM AALKPJMFIHM()
		{
			return default(IIIPFNDNGIM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal AEOBADCBKBC<NEOGCEDPDHC, MODPCPLILFH> JGBPJMOFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal AEOBADCBKBC<JNAGNBLELPB, BICMJACFMKP> EAHBFPBIFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal AEOBADCBKBC<JMNNJAILABF, MAFAMFEMMPM> AMOIFKNKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal GCECACNENLC<(FGLBFCBPBCD<NEOGCEDPDHC> CallId, FGLBFCBPBCD<NDOOLALGJGO> IOId)> CLEEHIFANPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal AEOBADCBKBC<NDOOLALGJGO, IIIPFNDNGIM> HAFHOFEBHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal GHFPPIONGBI<NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> IHFCKOKGFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal GHFPPIONGBI<NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> GNFEMKIDOFC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2239B90", Offset = "0x2238F90", VA = "0x182239B90")]
	private BODAOMHCKMN([In] AEOBADCBKBC<NEOGCEDPDHC, MODPCPLILFH> JHCGPAODEGN, [In] AEOBADCBKBC<JNAGNBLELPB, BICMJACFMKP> GMFABNOAGIC, [In] AEOBADCBKBC<JMNNJAILABF, MAFAMFEMMPM> GBFJCJJGPEA, [In] GCECACNENLC<(FGLBFCBPBCD<NEOGCEDPDHC> CallId, FGLBFCBPBCD<NDOOLALGJGO> IOId)> GFMNCGFLEGP, [In] AEOBADCBKBC<NDOOLALGJGO, IIIPFNDNGIM> OGGKOMEKEPE, [In] GHFPPIONGBI<NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> GNPMLHBBLOE, [In] GHFPPIONGBI<NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> AFEIANNGEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22399F0", Offset = "0x2238DF0", VA = "0x1822399F0")]
	public static BODAOMHCKMN AALKPJMFIHM()
	{
		return default(BODAOMHCKMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KBCIMHMOHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2242800", Offset = "0x2241C00", VA = "0x182242800")]
	private static void LBHGGLOEOHI(this BODAOMHCKMN.IIIPFNDNGIM MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x22425F0", Offset = "0x22419F0", VA = "0x1822425F0")]
	public static void LBHGGLOEOHI(this BODAOMHCKMN MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BGPCPMDEAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public GCECACNENLC<byte> DFLBLOIEJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal BODAOMHCKMN EPLLEMGOPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NABKALKHCAF HJBLJAGMFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> BKMFHIAHLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JKJJMPLCJNA DGNKOLCEJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal DIDBDODMHOI KPLPONHGJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal GHFPPIONGBI<MPANLLKONFK, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>?> IKJGNDPOLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GCECACNENLC<FGLBFCBPBCD<MPANLLKONFK>> CNJDAJFBGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> GOPFMOLJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> DHICNEAHOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> MCNCPAAEGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal BADMNADNDGG NFLMICGBELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal BHLDDOIKELI KIGOGKFAIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x22394F0", Offset = "0x22388F0", VA = "0x1822394F0")]
	private BGPCPMDEAHA([In] GCECACNENLC<byte> KMHKFAONMGN, [In] BODAOMHCKMN HHFFNIGKKGP, [In] NABKALKHCAF CMAIANAFLFA, [In] JKJJMPLCJNA JFOHNAOIFHI, [In] DIDBDODMHOI BCDKJKFHEGL, [In] GHFPPIONGBI<MPANLLKONFK, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>?> OGLOLOLPMBE, [In] GCECACNENLC<FGLBFCBPBCD<MPANLLKONFK>> GNNMHAEPNAL, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> AJCKKIMBBAG, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> MCNLENDCIOH, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> EPAJFBADNNP, [In] BADMNADNDGG AHMALGBIPHE, [In] BHLDDOIKELI DPNJLMNKLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2238B40", Offset = "0x2237F40", VA = "0x182238B40")]
	public static BGPCPMDEAHA AALKPJMFIHM()
	{
		return default(BGPCPMDEAHA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FJLEMEAGKBC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct BAOHKNCBAFL : PFOOICIHKKA<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>, GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2238800", Offset = "0x2237C00", VA = "0x182238800")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x22387D0", Offset = "0x2237BD0", VA = "0x1822387D0", Slot = "4")]
		public FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> DOIPILAGMCM(int AEAHMAMPNLO)
		{
			return default(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		public bool FACIAGEELIB(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "5")]
		private bool CODCGNAMDJL(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x22388B0", Offset = "0x2237CB0", VA = "0x1822388B0", Slot = "6")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> ONAGBIEGHBO(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct PIMAFIMOEDM : NNBBNCHKLMN<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>, GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x22432D0", Offset = "0x22426D0", VA = "0x1822432D0")]
		public GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>> PFBIJGADJDD(int OEJMADFLOHD, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2243340", Offset = "0x2242740", VA = "0x182243340")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2243210", Offset = "0x2242610", VA = "0x182243210", Slot = "6")]
		public void FNLDGCAAKGI(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x22432D0", Offset = "0x22426D0", VA = "0x1822432D0", Slot = "4")]
		private GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>> HOKEMDHKJAN(int OEJMADFLOHD, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2243200", Offset = "0x2242600", VA = "0x182243200", Slot = "5")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> DIMJBHIAMFD(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct GBGJADICIAN : PFOOICIHKKA<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>, GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x223CB90", Offset = "0x223BF90", VA = "0x18223CB90")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x223CB50", Offset = "0x223BF50", VA = "0x18223CB50", Slot = "4")]
		public FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> DOIPILAGMCM(int AEAHMAMPNLO)
		{
			return default(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		public bool FACIAGEELIB(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "5")]
		private bool OLECJABFGFE(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x223CB80", Offset = "0x223BF80", VA = "0x18223CB80", Slot = "6")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> IONOPBBNEIK(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct HLOEHMPOFDI : NNBBNCHKLMN<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>, GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x22420D0", Offset = "0x22414D0", VA = "0x1822420D0")]
		public GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>> PFBIJGADJDD(int OEJMADFLOHD, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2242140", Offset = "0x2241540", VA = "0x182242140")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2242010", Offset = "0x2241410", VA = "0x182242010", Slot = "6")]
		public void FNLDGCAAKGI(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22420D0", Offset = "0x22414D0", VA = "0x1822420D0", Slot = "4")]
		private GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>> LGFAOCEPOHN(int OEJMADFLOHD, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(GCECACNENLC<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2242000", Offset = "0x2241400", VA = "0x182242000", Slot = "5")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> CJMJHLKFHHL(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> AEAHMAMPNLO, [In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct OHLPODBAPBC : PFOOICIHKKA<FGLBFCBPBCD<GAMDJBJJMEG>, GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2243080", Offset = "0x2242480", VA = "0x182243080")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2242FC0", Offset = "0x22423C0", VA = "0x182242FC0", Slot = "4")]
		public FGLBFCBPBCD<GAMDJBJJMEG> DOIPILAGMCM(int AEAHMAMPNLO)
		{
			return default(FGLBFCBPBCD<GAMDJBJJMEG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2242FF0", Offset = "0x22423F0", VA = "0x182242FF0")]
		public bool FACIAGEELIB(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2242FF0", Offset = "0x22423F0", VA = "0x182242FF0", Slot = "5")]
		private bool PABDHNKMLDC(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2243070", Offset = "0x2242470", VA = "0x182243070", Slot = "6")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> HLLBIEPMGHA(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct NAHCCFPEIGP : NNBBNCHKLMN<FGLBFCBPBCD<GAMDJBJJMEG>, GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2242DD0", Offset = "0x22421D0", VA = "0x182242DD0")]
		public GCECACNENLC<FGLBFCBPBCD<GAMDJBJJMEG>> PFBIJGADJDD(int OEJMADFLOHD, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(GCECACNENLC<FGLBFCBPBCD<GAMDJBJJMEG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2242E40", Offset = "0x2242240", VA = "0x182242E40")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2242CE0", Offset = "0x22420E0", VA = "0x182242CE0", Slot = "6")]
		public void FNLDGCAAKGI(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2242DD0", Offset = "0x22421D0", VA = "0x182242DD0", Slot = "4")]
		private GCECACNENLC<FGLBFCBPBCD<GAMDJBJJMEG>> IDLOFCFKJIC(int OEJMADFLOHD, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(GCECACNENLC<FGLBFCBPBCD<GAMDJBJJMEG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2242DC0", Offset = "0x22421C0", VA = "0x182242DC0", Slot = "5")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> HDGMDPLCFCB(FGLBFCBPBCD<GAMDJBJJMEG> AEAHMAMPNLO, [In] GHFPPIONGBI<GAMDJBJJMEG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>?> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct IKFHOFNDLNJ : PFOOICIHKKA<int, GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2242330", Offset = "0x2241730", VA = "0x182242330")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x950BC0", Offset = "0x94FFC0", VA = "0x180950BC0", Slot = "4")]
		public int DOIPILAGMCM(int AEAHMAMPNLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		public bool FACIAGEELIB(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "5")]
		private bool ODILAINPPMC(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2242320", Offset = "0x2241720", VA = "0x182242320", Slot = "6")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LLEAFJLIAFH(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct DLGCILOCGEC : NNBBNCHKLMN<int, GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2239FF0", Offset = "0x22393F0", VA = "0x182239FF0")]
		public GCECACNENLC<int> PFBIJGADJDD(int OEJMADFLOHD, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(GCECACNENLC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x223A060", Offset = "0x2239460", VA = "0x18223A060")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2239EE0", Offset = "0x22392E0", VA = "0x182239EE0", Slot = "6")]
		public void FNLDGCAAKGI(int AEAHMAMPNLO, GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2239FF0", Offset = "0x22393F0", VA = "0x182239FF0", Slot = "4")]
		private GCECACNENLC<int> MNIDMOBMBNG(int OEJMADFLOHD, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(GCECACNENLC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2239FE0", Offset = "0x22393E0", VA = "0x182239FE0", Slot = "5")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> GPINFMHCEPB(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> VariableId, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<OIGPANGPEIL>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct FAMEOIPAMEG : PFOOICIHKKA<int, GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x223A110", Offset = "0x2239510", VA = "0x18223A110")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x950BC0", Offset = "0x94FFC0", VA = "0x180950BC0", Slot = "4")]
		public int DOIPILAGMCM(int AEAHMAMPNLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		public bool FACIAGEELIB(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "5")]
		private bool KDEGBAPIKFC(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x223A100", Offset = "0x2239500", VA = "0x18223A100", Slot = "6")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> JGHELKPJLKL(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct AGNLFLOPEAI : NNBBNCHKLMN<int, GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2238320", Offset = "0x2237720", VA = "0x182238320")]
		public GCECACNENLC<int> PFBIJGADJDD(int OEJMADFLOHD, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(GCECACNENLC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2238490", Offset = "0x2237890", VA = "0x182238490")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2238390", Offset = "0x2237790", VA = "0x182238390", Slot = "6")]
		public void FNLDGCAAKGI(int AEAHMAMPNLO, GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2238320", Offset = "0x2237720", VA = "0x182238320", Slot = "4")]
		private GCECACNENLC<int> EBKGOBKBHHF(int OEJMADFLOHD, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(GCECACNENLC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2238480", Offset = "0x2237880", VA = "0x182238480", Slot = "5")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> MFJDNEMLJLE(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct IIMFKKGHPKJ : PFOOICIHKKA<int, GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2242280", Offset = "0x2241680", VA = "0x182242280")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x950BC0", Offset = "0x94FFC0", VA = "0x180950BC0", Slot = "4")]
		public int DOIPILAGMCM(int AEAHMAMPNLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		public bool FACIAGEELIB(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "5")]
		private bool KDEGBAPIKFC(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2242270", Offset = "0x2241670", VA = "0x182242270", Slot = "6")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> JGHELKPJLKL(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct FGOLBLDCBHI : NNBBNCHKLMN<int, GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x223A2B0", Offset = "0x22396B0", VA = "0x18223A2B0")]
		public GCECACNENLC<int> PFBIJGADJDD(int OEJMADFLOHD, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(GCECACNENLC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x223A430", Offset = "0x2239830", VA = "0x18223A430")]
		public FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x223A320", Offset = "0x2239720", VA = "0x18223A320", Slot = "6")]
		public void FNLDGCAAKGI(int AEAHMAMPNLO, GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x223A2B0", Offset = "0x22396B0", VA = "0x18223A2B0", Slot = "4")]
		private GCECACNENLC<int> EBKGOBKBHHF(int OEJMADFLOHD, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(GCECACNENLC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x223A420", Offset = "0x2239820", VA = "0x18223A420", Slot = "5")]
		private FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> MFJDNEMLJLE(int AEAHMAMPNLO, [In] GCECACNENLC<(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> Target, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> ByteCodeWriteLocation)> BIHDACIMKFK)
		{
			return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct DBLIPNEJNMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> MCKADFGEJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool LBCGJIJAACJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x17CF710", Offset = "0x17CEB10", VA = "0x1817CF710")]
		public DBLIPNEJNMJ(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA, bool EKKILNCJDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2239DF0", Offset = "0x22391F0", VA = "0x182239DF0")]
		public void CPFOJCEKBFH([Out] FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA, [Out] bool EKKILNCJDOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct BOKHKHEGCBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly FGLBFCBPBCD<GAMDJBJJMEG> AEPJLHJPBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> MCKADFGEJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool LBCGJIJAACJ;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2239C80", Offset = "0x2239080", VA = "0x182239C80")]
		public BOKHKHEGCBG(FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA, bool EKKILNCJDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2239C70", Offset = "0x2239070", VA = "0x182239C70")]
		public void CPFOJCEKBFH([Out] FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA, [Out] bool EKKILNCJDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2239C50", Offset = "0x2239050", VA = "0x182239C50")]
		public void CPFOJCEKBFH([Out] FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA, [Out] FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF, [Out] bool EKKILNCJDOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NKJHDPDDHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly FGLBFCBPBCD<GAMDJBJJMEG> AEPJLHJPBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> MCKADFGEJJE;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		public NKJHDPDDHMF(FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2242F30", Offset = "0x2242330", VA = "0x182242F30")]
		public void CPFOJCEKBFH([Out] FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA, [Out] FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x223BA20", Offset = "0x223AE20", VA = "0x18223BA20")]
	public static void LBHGGLOEOHI(this BGPCPMDEAHA MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x223B900", Offset = "0x223AD00", VA = "0x18223B900")]
	public static void KAPGFFFPJPI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> GLJHJHEKCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x223C290", Offset = "0x223B690", VA = "0x18223C290")]
	public static void NLFMJDMNKCG(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> GLJHJHEKCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x223C460", Offset = "0x223B860", VA = "0x18223C460")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>? OILKNNKLCEC([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x223ABD0", Offset = "0x2239FD0", VA = "0x18223ABD0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> COODFFOEPPA([In] this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x223C650", Offset = "0x223BA50", VA = "0x18223C650")]
	private static void PCAMDCFCKNN(this BGPCPMDEAHA MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x223AEB0", Offset = "0x223A2B0", VA = "0x18223AEB0")]
	private static FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>? EEOANCAIAOL([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x223B110", Offset = "0x223A510", VA = "0x18223B110")]
	public static void FEJCFFHJJNA(this BGPCPMDEAHA MBGHIKEGJAA, [In] GCECACNENLC<JIIHHGBDKAG> PAPILHDGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x223A620", Offset = "0x2239A20", VA = "0x18223A620")]
	public static JKJJMPLCJNA.DDJOKINFPDO ANBIIMGNNDN([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
	{
		return default(JKJJMPLCJNA.DDJOKINFPDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x223B4E0", Offset = "0x223A8E0", VA = "0x18223B4E0")]
	public static IAPBPCHLGCB<byte> HMAIGACCJJA([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
	{
		return default(IAPBPCHLGCB<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x223BCF0", Offset = "0x223B0F0", VA = "0x18223BCF0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LCKPFAEOGLC([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x223A6F0", Offset = "0x2239AF0", VA = "0x18223A6F0")]
	public static KCFDAINDPGI BGJPCFMNCND([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2E52D70", Offset = "0x2E52170", VA = "0x182E52D70")]
	private static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> OLGPKFJAKHM<TMJoin>(this BGPCPMDEAHA MBGHIKEGJAA, JKJJMPLCJNA.DDJOKINFPDO LCAGNMGCPNA, FGLBFCBPBCD<TMJoin> HDKNKOIDEOI) where TMJoin : JKJJMPLCJNA.EPEGDGFJHAP
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x223B280", Offset = "0x223A680", VA = "0x18223B280")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> FJNEGCIDNHE(this BGPCPMDEAHA MBGHIKEGJAA, bool HNHJJCGDJIC)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x223CAC0", Offset = "0x223BEC0", VA = "0x18223CAC0")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> PNLHCMCDJNA(this BGPCPMDEAHA MBGHIKEGJAA, IAPBPCHLGCB<byte> HFHEELJJDFM)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x223AF70", Offset = "0x223A370", VA = "0x18223AF70")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> EJKJFFDGAFD(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> GEALFJGGJPO)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x223C5D0", Offset = "0x223B9D0", VA = "0x18223C5D0")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> OOHKJAHHEKM(this BGPCPMDEAHA MBGHIKEGJAA, int GMMDNCGPFHF)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x223B880", Offset = "0x223AC80", VA = "0x18223B880")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> JLHBPGJHHIG(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E51EA0", Offset = "0x2E512A0", VA = "0x182E51EA0")]
	private static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> KGLBIKBCKIN<TMJoin>(this BGPCPMDEAHA MBGHIKEGJAA, DIDBDODMHOI.HFJMFIKIBFM LCAGNMGCPNA, FGLBFCBPBCD<TMJoin> HDKNKOIDEOI) where TMJoin : DIDBDODMHOI.DCJHJFOFOFM
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x223B710", Offset = "0x223AB10", VA = "0x18223B710")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> ILGAFLIBNJM(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x223B6C0", Offset = "0x223AAC0", VA = "0x18223B6C0")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> IDPAFINLGEF(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x223C3E0", Offset = "0x223B7E0", VA = "0x18223C3E0")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> NODINMDPALP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> OLIJGIMGKCJ)
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x223B0C0", Offset = "0x223A4C0", VA = "0x18223B0C0")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> FBAPBJMBGEE(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x223C060", Offset = "0x223B460", VA = "0x18223C060")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> NFNGICDPENB(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x223A5A0", Offset = "0x22399A0", VA = "0x18223A5A0")]
	public static BODAOMHCKMN.IKMEAILIJGM AFIMANKHPLI([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> LODPAMOBBEH)
	{
		return default(BODAOMHCKMN.IKMEAILIJGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x223AE70", Offset = "0x223A270", VA = "0x18223AE70")]
	public static MLMOHINLGGP<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>, AKJDNBPCFOH<BODAOMHCKMN.NDOOLALGJGO>> EDPNGKJGFMF([In] this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(MLMOHINLGGP<FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>, AKJDNBPCFOH<BODAOMHCKMN.NDOOLALGJGO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x223C0B0", Offset = "0x223B4B0", VA = "0x18223C0B0")]
	public static FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> NJNPNKPOAPN([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> LODPAMOBBEH)
	{
		return default(FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x223C360", Offset = "0x223B760", VA = "0x18223C360")]
	public static BODAOMHCKMN.IIIPFNDNGIM NMMELDMADLF([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> GKIBHMDFALE)
	{
		return default(BODAOMHCKMN.IIIPFNDNGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x223BFE0", Offset = "0x223B3E0", VA = "0x18223BFE0")]
	public static BODAOMHCKMN.IIIPFNDNGIM NFDOGILKLBO(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> GKIBHMDFALE)
	{
		return default(BODAOMHCKMN.IIIPFNDNGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2E512F0", Offset = "0x2E506F0", VA = "0x182E512F0")]
	private static FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> EPLDBCCMCEA<TMJoin>(this BGPCPMDEAHA MBGHIKEGJAA, BODAOMHCKMN.IKMEAILIJGM LCAGNMGCPNA, FGLBFCBPBCD<TMJoin> HDKNKOIDEOI) where TMJoin : BODAOMHCKMN.PHFCGHKLJHH
	{
		return default(FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x223A990", Offset = "0x2239D90", VA = "0x18223A990")]
	public static (FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>) CGPFNEDOOFI(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default((FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x223A7E0", Offset = "0x2239BE0", VA = "0x18223A7E0")]
	public static (FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>) BPIILJJEKKK(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default((FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x223A6A0", Offset = "0x2239AA0", VA = "0x18223A6A0")]
	public static FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> BAFLNAEMDJM(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x223B300", Offset = "0x223A700", VA = "0x18223B300")]
	public static void GBKCPBIJPCP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO> GKIBHMDFALE, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> JLCCEJPPDNK, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>> OFEFLECGFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E51F50", Offset = "0x2E51350", VA = "0x182E51F50")]
	public static DBLIPNEJNMJ LECEBOALDMK<TDeps, TStateSys>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF) where TDeps : EPKAGCODFMF<TStateSys>
	{
		return default(DBLIPNEJNMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E51050", Offset = "0x2E50450", VA = "0x182E51050")]
	public static BOKHKHEGCBG EMFKPAKFACC<TDeps, TStateSys>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<EPJMFNGLNNN> IEIONDBAINP, int MMFIDABOADB) where TDeps : EPKAGCODFMF<TStateSys>
	{
		return default(BOKHKHEGCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2E51390", Offset = "0x2E50790", VA = "0x182E51390")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>? GCLDOOOEGKD<TDeps, TStateSys>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<EPJMFNGLNNN> IEIONDBAINP, [In] ReadOnlySpan<int> DEDHMJPHJEK, [In] Span<NKJHDPDDHMF> LLDAIABJNGJ) where TDeps : EPKAGCODFMF<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E518D0", Offset = "0x2E50CD0", VA = "0x182E518D0")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> GPONHMJICOL<TDeps, TStateSys>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ) where TDeps : EPKAGCODFMF<TStateSys>
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x223B5D0", Offset = "0x223A9D0", VA = "0x18223B5D0")]
	public static NABKALKHCAF.KLMAGFHKMEM IAALKAPBLCB([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IHELCOHOCAM)
	{
		return default(NABKALKHCAF.KLMAGFHKMEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x223AC30", Offset = "0x223A030", VA = "0x18223AC30")]
	public static NABKALKHCAF.AGJFAAKKFKD DJNKDLLHKEH([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IHELCOHOCAM)
	{
		return default(NABKALKHCAF.AGJFAAKKFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x223C9D0", Offset = "0x223BDD0", VA = "0x18223C9D0")]
	public static NABKALKHCAF.FBKNMLEGHOH PMELPNMCIMF([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IHELCOHOCAM)
	{
		return default(NABKALKHCAF.FBKNMLEGHOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x223BE50", Offset = "0x223B250", VA = "0x18223BE50")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> MECNGINEGHN(this BGPCPMDEAHA MBGHIKEGJAA, int? EOCIGJMKBPH, string ADANIHOIEKJ)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x223AD80", Offset = "0x223A180", VA = "0x18223AD80")]
	public static NABKALKHCAF.FIIBCCPGKDP DLEOJEJILOI([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IHELCOHOCAM)
	{
		return default(NABKALKHCAF.FIIBCCPGKDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x223A4D0", Offset = "0x22398D0", VA = "0x18223A4D0")]
	public static NABKALKHCAF.MLHANHBCPEH ABJANOOKFCH([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IHELCOHOCAM)
	{
		return default(NABKALKHCAF.MLHANHBCPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x223BDE0", Offset = "0x223B1E0", VA = "0x18223BDE0")]
	public static int? MDKOIJKNFPM([In] this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IHELCOHOCAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E517D0", Offset = "0x2E50BD0", VA = "0x182E517D0")]
	private static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GGEFFJLJCCJ<TMJoin>(this BGPCPMDEAHA MBGHIKEGJAA, int? EOCIGJMKBPH, NABKALKHCAF.MLHANHBCPEH LCAGNMGCPNA, FGLBFCBPBCD<TMJoin> HDKNKOIDEOI) where TMJoin : NABKALKHCAF.CPILEJGAIAF
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x223C520", Offset = "0x223B920", VA = "0x18223C520")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OMPOBLNABFA(this BGPCPMDEAHA MBGHIKEGJAA, int? EOCIGJMKBPH, FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> LODPAMOBBEH, int AEAHMAMPNLO)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x223AD20", Offset = "0x223A120", VA = "0x18223AD20")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DLEEOCCGEDN(this BGPCPMDEAHA MBGHIKEGJAA, int? EOCIGJMKBPH)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x223B390", Offset = "0x223A790", VA = "0x18223B390")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GPNDOPNKCFA(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? BPCLIKIOPCG, int? EOCIGJMKBPH)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x223AB40", Offset = "0x2239F40", VA = "0x18223AB40")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> CIFFDFNPECO(this BGPCPMDEAHA MBGHIKEGJAA, int? EOCIGJMKBPH, int AEAHMAMPNLO)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x223A540", Offset = "0x2239940", VA = "0x18223A540")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> AFHNMAPGAEG(this BGPCPMDEAHA MBGHIKEGJAA, int? EOCIGJMKBPH)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x223C7C0", Offset = "0x223BBC0", VA = "0x18223C7C0")]
	public static void PDPEHLPKFAM(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI, FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> LODPAMOBBEH, int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x223B750", Offset = "0x223AB50", VA = "0x18223B750")]
	public static void JHAOFCOGLNI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI, int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x223C900", Offset = "0x223BD00", VA = "0x18223C900")]
	public static void PECIKKCKECI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x223B990", Offset = "0x223AD90", VA = "0x18223B990")]
	public static void KEIKMOBEGLK(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> ANHPPPBDANF, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> BMJGGMFJCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x223AFF0", Offset = "0x223A3F0", VA = "0x18223AFF0")]
	public static void EMAMIINDAMF(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI, FGLBFCBPBCD<MFKEBFFAIOJ<CADHKIKCJMC>> NNJJDJELGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E52E20", Offset = "0x2E52220", VA = "0x182E52E20")]
	public static void PLLOCAGIEEH<M>(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OLMKHNFMDAI, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<M>>> NNJJDJELGKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EPKAGCODFMF<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGLBFCBPBCD<KNHPKNCFPBE> MPFJCFMBKBA(TStateSys EAKDHOEILGP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGLBFCBPBCD<KNHPKNCFPBE> CCPLCNFFAOL(TStateSys EAKDHOEILGP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGLBFCBPBCD<KNHPKNCFPBE> AJLNACMHOFJ(TStateSys EAKDHOEILGP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGLBFCBPBCD<KNHPKNCFPBE> CIPNGOOKCJH(TStateSys EAKDHOEILGP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> LHNGDOCLCAE(TStateSys EAKDHOEILGP, BGPCPMDEAHA GOBLAKEDFJJ, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> BNJDKPFNMLD(TStateSys EAKDHOEILGP, BGPCPMDEAHA GOBLAKEDFJJ, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EDLFLGCJGDP(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGLBFCBPBCD<MPANLLKONFK> CFIAKHHNBCC(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF, int HLBMMAHCHAM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ALMIABIILEN EBENDJGBFDE(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MBFBNPOIKDJ(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int DFAJPDAPDKL(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IAPBPCHLGCB<byte> GEEFFNLGDCP(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(IAPBPCHLGCB<byte>, FGLBFCBPBCD<KNHPKNCFPBE>) OGJHCPFGCPK(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<GAMDJBJJMEG> MMFEJGDOBPF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int HHLIMGKBAEA(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FGLBFCBPBCD<GAMDJBJJMEG> GHAHLKGIFLM(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<MPANLLKONFK> EHCJDFNAANJ, int MMFIDABOADB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FGLBFCBPBCD<GAMDJBJJMEG> JKGJGPMADLI(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, FGLBFCBPBCD<EPJMFNGLNNN> IEIONDBAINP, int MMFIDABOADB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int GLHIEDPNNBE(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? CGJEHIFMJMH(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, int AEAHMAMPNLO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int DPEONLLAPHM(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? NNHMEKAJJAK(TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI, int AEAHMAMPNLO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HDHAMGDMGEB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C970", Offset = "0x2E7BD70", VA = "0x182E7C970")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE?> COONHMOGIDP<T, TOpInput, TOpOutput>(this BGPCPMDEAHA MBGHIKEGJAA, T GIDMNJLJNOH, T OONEKAPAHLL, int MLEHEAHGIFJ, IntPtr KGBHBFABAOH)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DBE0", Offset = "0x2E7CFE0", VA = "0x182E7DBE0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE?> JBCLKGFPFMN<T, TOpInput, TOpOutput>(this BGPCPMDEAHA MBGHIKEGJAA, T GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL, int MLEHEAHGIFJ, IntPtr KGBHBFABAOH)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D020", Offset = "0x2E7C420", VA = "0x182E7D020")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE?> FBDCCBLGJNP<TOpInput, TOpOutput>(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL, int MLEHEAHGIFJ, IntPtr KGBHBFABAOH)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x223E240", Offset = "0x223D640", VA = "0x18223E240")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> ECCHPJDAHPF(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x22405C0", Offset = "0x223F9C0", VA = "0x1822405C0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> KKNNFMEIKIC(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2240F90", Offset = "0x2240390", VA = "0x182240F90")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> NFODHIIFAPP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x223F2B0", Offset = "0x223E6B0", VA = "0x18223F2B0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIODBDIIDIN(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22414E0", Offset = "0x22408E0", VA = "0x1822414E0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OEPHJGBPHJJ(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x223F780", Offset = "0x223EB80", VA = "0x18223F780")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HJJKJMAOIPI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x223F8C0", Offset = "0x223ECC0", VA = "0x18223F8C0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IFPNOCAFDFJ(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2240020", Offset = "0x223F420", VA = "0x182240020")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> JMGLBLMJEFD(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22407E0", Offset = "0x223FBE0", VA = "0x1822407E0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LAAHAOBFNBD(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x22418C0", Offset = "0x2240CC0", VA = "0x1822418C0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PDMFBBBEPIN(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, int OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22404A0", Offset = "0x223F8A0", VA = "0x1822404A0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> KIBMLMKPKNI(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x223DC80", Offset = "0x223D080", VA = "0x18223DC80")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DEAEDEAELIG(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x223FF20", Offset = "0x223F320", VA = "0x18223FF20")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> JEJKNLANPJE(this BGPCPMDEAHA MBGHIKEGJAA, float GIDMNJLJNOH, float OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2240DC0", Offset = "0x22401C0", VA = "0x182240DC0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> MLGCOBFLHLH(this BGPCPMDEAHA MBGHIKEGJAA, float GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x223F170", Offset = "0x223E570", VA = "0x18223F170")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GINPALDBNGF(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x223E340", Offset = "0x223D740", VA = "0x18223E340")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> EHCCECKJKAB(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, int OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2240BC0", Offset = "0x223FFC0", VA = "0x182240BC0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> MEINEILBHPB(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2240C40", Offset = "0x2240040", VA = "0x182240C40")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> MFIHADMOKPD(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x223F700", Offset = "0x223EB00", VA = "0x18223F700")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HJDOOGHHKPK(this BGPCPMDEAHA MBGHIKEGJAA, float GIDMNJLJNOH, float OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2240920", Offset = "0x223FD20", VA = "0x182240920")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LAHFAIJPCDD(this BGPCPMDEAHA MBGHIKEGJAA, float GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x223ED00", Offset = "0x223E100", VA = "0x18223ED00")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> FEHKPHNDOFO(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2241840", Offset = "0x2240C40", VA = "0x182241840")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OOIPDFHFKEK(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, int OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x223F590", Offset = "0x223E990", VA = "0x18223F590")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HIBFCOKNEGK(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x223CDD0", Offset = "0x223C1D0", VA = "0x18223CDD0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> AFFJCDLGAIA(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x223EC80", Offset = "0x223E080", VA = "0x18223EC80")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> FAOIENMAINF(this BGPCPMDEAHA MBGHIKEGJAA, float GIDMNJLJNOH, float OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2240D40", Offset = "0x2240140", VA = "0x182240D40")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> MJHPKONEALB(this BGPCPMDEAHA MBGHIKEGJAA, float GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2240760", Offset = "0x223FB60", VA = "0x182240760")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> KOOLFGMCFBG(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22410D0", Offset = "0x22404D0", VA = "0x1822410D0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> NGCIAGCFCLP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x22406E0", Offset = "0x223FAE0", VA = "0x1822406E0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> KNKAEJGGFCB(this BGPCPMDEAHA MBGHIKEGJAA, int LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2240EF0", Offset = "0x22402F0", VA = "0x182240EF0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> NCLIKHPNAPJ(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x223EFC0", Offset = "0x223E3C0", VA = "0x18223EFC0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> GGKCODPJEPJ(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> ALPOHONBNKA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2241680", Offset = "0x2240A80", VA = "0x182241680")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> OKAGBLEEBJH(this BGPCPMDEAHA MBGHIKEGJAA, int LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x223F4F0", Offset = "0x223E8F0", VA = "0x18223F4F0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> GPGJKKPFDLP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x223D5F0", Offset = "0x223C9F0", VA = "0x18223D5F0")]
	public static (FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>) BNPKOBDNCMB(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<AJCNMBKOFNE> HNPIMPBNHBA, [In] ReadOnlySpan<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> IAGJCBIIDIO, [In] ReadOnlySpan<int?> BHJBBKGGBKC, [In] Span<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> LBEKIDPCDDO)
	{
		return default((FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x223E740", Offset = "0x223DB40", VA = "0x18223E740")]
	public static (FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>) EKFLNKAODMI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<HMLIDFJANJN> JNPDNCCNOPP, [In] ReadOnlySpan<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> IAGJCBIIDIO, [In] ReadOnlySpan<int?> BHJBBKGGBKC, [In] Span<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> LBEKIDPCDDO)
	{
		return default((FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E7EBB0", Offset = "0x2E7DFB0", VA = "0x182E7EBB0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<KNHPKNCFPBE>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<TMarker>>, FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>) NLJNKNHHIIL<TMarker>(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<KNHPKNCFPBE> BGNNMLBCMBH, [In] ReadOnlySpan<byte> MPMEGOKIEPF)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<KNHPKNCFPBE>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<TMarker>>, FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x223DE40", Offset = "0x223D240", VA = "0x18223DE40")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DFKIKMLDGBL(this BGPCPMDEAHA MBGHIKEGJAA, int NCNPDGLPGME, [Optional] FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x223DF00", Offset = "0x223D300", VA = "0x18223DF00")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DHAEEHOPMGM(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> NCNPDGLPGME, [Optional] FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x223F610", Offset = "0x223EA10", VA = "0x18223F610")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HIEPLNNGGEE(this BGPCPMDEAHA MBGHIKEGJAA, [In] ReadOnlySpan<byte> NCNPDGLPGME, [Optional] FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x223EEA0", Offset = "0x223E2A0", VA = "0x18223EEA0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GDMDGDOJGFK(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> NCNPDGLPGME, int MFKKELONDCC, [Optional] FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2241D60", Offset = "0x2241160", VA = "0x182241D60")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PMDELCIGNBJ(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x223D4D0", Offset = "0x223C8D0", VA = "0x18223D4D0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> BDKDJLDHKAB(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x223DA40", Offset = "0x223CE40", VA = "0x18223DA40")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> CLKLKGFHNCP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22413E0", Offset = "0x22407E0", VA = "0x1822413E0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> ODLIFGJLNMI(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x223FAF0", Offset = "0x223EEF0", VA = "0x18223FAF0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IMDNJOKBEPN(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2241700", Offset = "0x2240B00", VA = "0x182241700")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OOBONFKFOBM(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2241600", Offset = "0x2240A00", VA = "0x182241600")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OFCCJOCLCOE(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, int OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x223DDC0", Offset = "0x223D1C0", VA = "0x18223DDC0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DEAMABFACKM(this BGPCPMDEAHA MBGHIKEGJAA, int GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2240CC0", Offset = "0x22400C0", VA = "0x182240CC0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> MHOBCGCHNDG(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GIDMNJLJNOH, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> OONEKAPAHLL)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x223EB80", Offset = "0x223DF80", VA = "0x18223EB80")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> EOEGMNEIOBJ(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x223F9C0", Offset = "0x223EDC0", VA = "0x18223F9C0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IGCCPJJKEJE(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x223D090", Offset = "0x223C490", VA = "0x18223D090")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> ALFDCGECKAI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2241E60", Offset = "0x2241260", VA = "0x182241E60")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PNPFMHKLGHE(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x223DFF0", Offset = "0x223D3F0", VA = "0x18223DFF0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DINLEAEIPBL(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x223CF50", Offset = "0x223C350", VA = "0x18223CF50")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> ALAJIAIGKKH(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x22413C0", Offset = "0x22407C0", VA = "0x1822413C0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>> OCEEOLJDPON(this BGPCPMDEAHA MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x22403A0", Offset = "0x223F7A0", VA = "0x1822403A0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> KHHAHBHGKND(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2240AA0", Offset = "0x223FEA0", VA = "0x182240AA0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LNIHGBEFBJJ(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2241280", Offset = "0x2240680", VA = "0x182241280")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> NLDICDDPKLP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x223CE50", Offset = "0x223C250", VA = "0x18223CE50")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> AJEGOIHNKGG(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x223CCB0", Offset = "0x223C0B0", VA = "0x18223CCB0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> AEKGPGEFGII(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2240140", Offset = "0x223F540", VA = "0x182240140")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> KCJODEAFCDM(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22409A0", Offset = "0x223FDA0", VA = "0x1822409A0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LCFOPLBIHHC(this BGPCPMDEAHA MBGHIKEGJAA, int LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x223FC10", Offset = "0x223F010", VA = "0x18223FC10")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> IPNLHNOAMDP(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x223DA30", Offset = "0x223CE30", VA = "0x18223DA30")]
	public static void CFGFJMNNIIA(this BGPCPMDEAHA MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x223DB80", Offset = "0x223CF80", VA = "0x18223DB80")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DDJNAPIBIOB(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2240280", Offset = "0x223F680", VA = "0x182240280")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> KGLNBMMOBIO(this BGPCPMDEAHA MBGHIKEGJAA, float HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2241AE0", Offset = "0x2240EE0", VA = "0x182241AE0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PHDNEBKEECI(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x223FD20", Offset = "0x223F120", VA = "0x18223FD20")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> JBAMBDDECPI(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x223ED80", Offset = "0x223E180", VA = "0x18223ED80")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> FFNDAFCPLFN(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2241C20", Offset = "0x2241020", VA = "0x182241C20")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PLHDIHMPOBO(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x223E3C0", Offset = "0x223D7C0", VA = "0x18223E3C0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> EHFCEACCCHJ(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> DPMHJJEIFAC, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> JPBNBPKADDP)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x223FE20", Offset = "0x223F220", VA = "0x18223FE20")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> JEJIFAALKIJ(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x22419C0", Offset = "0x2240DC0", VA = "0x1822419C0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PEFGAGNALJO(this BGPCPMDEAHA MBGHIKEGJAA, int HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x223F3B0", Offset = "0x223E7B0", VA = "0x18223F3B0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> GOMNLHJBMBA(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> HCFNCMBKLPD, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LMLEOKOHLPN)
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E7EF40", Offset = "0x2E7E340", VA = "0x182E7EF40")]
	public static void PBFEGPIJOAD<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<AJCNMBKOFNE> HNPIMPBNHBA, [In] ReadOnlySpan<FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>> FFMAOFJOBLN, [In] ReadOnlySpan<int?> BHJBBKGGBKC, [In] Span<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> LBEKIDPCDDO, [In] Span<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> JJKPCAKFOPP, [In] ReadOnlySpan<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>?> KLBNPBDMCJH) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DF80", Offset = "0x2E7D380", VA = "0x182E7DF80")]
	public static void JKJFDNDNEPP<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<HMLIDFJANJN> HGNEAAOPDDM, [In] ReadOnlySpan<FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>> EJCKHCPDIHG, [In] ReadOnlySpan<int?> BHJBBKGGBKC, [In] Span<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> LBEKIDPCDDO, [In] Span<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>> JJKPCAKFOPP, [In] ReadOnlySpan<FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>?> KLBNPBDMCJH) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E7F6F0", Offset = "0x2E7EAF0", VA = "0x182E7F6F0")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> PPBMDIDAPHK<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> BPCLIKIOPCG, [Optional] FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E750", Offset = "0x2E7DB50", VA = "0x182E7E750")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> LHGAGDGJONN<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> OLIJGIMGKCJ, [Optional] FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E520", Offset = "0x2E7D920", VA = "0x182E7E520")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> KCLFONDHDKJ<TDeps, TStateSys>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP) where TDeps : notnull, EPKAGCODFMF<TStateSys> where TStateSys : notnull
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E7F4E0", Offset = "0x2E7E8E0", VA = "0x182E7F4E0")]
	public static FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB> PKAKMJOFILP<TDeps, TStateSys>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP) where TDeps : notnull, EPKAGCODFMF<TStateSys> where TStateSys : notnull
	{
		return default(FGLBFCBPBCD<DIDBDODMHOI.ECHOMNBCDPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x223E110", Offset = "0x223D510", VA = "0x18223E110")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> DMEMNMKJNDM(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> JLKLLDHIFNB, IntPtr CNHEOEMAJIK, IntPtr EOCLIGPAMDM)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x223D1D0", Offset = "0x223C5D0", VA = "0x18223D1D0")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> BCPLGNKLAOL(this BGPCPMDEAHA MBGHIKEGJAA, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> CAHDEKHKMFG, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> EAEKHAKBMLC, IntPtr EGPOFAOFPKG, IntPtr INOHENDAJIH, IntPtr GIILKIIMBPD, bool KMBEDJHHJFI)
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D190", Offset = "0x2E7C590", VA = "0x182E7D190")]
	public static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> GOMLGDEGACA<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<AJCNMBKOFNE> KKODMBKHHBM, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> CAHDEKHKMFG, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> EAEKHAKBMLC, int? JBPIKNCHFNM, [Optional] IntPtr DDIOJAIKMNI) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D3A0", Offset = "0x2E7C7A0", VA = "0x182E7D3A0")]
	private static FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> GOMLGDEGACA<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<AJCNMBKOFNE> KKODMBKHHBM, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> CAHDEKHKMFG, FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB> EAEKHAKBMLC, int? JBPIKNCHFNM) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
		return default(FGLBFCBPBCD<JKJJMPLCJNA.CLIPNBCPPCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E7CC70", Offset = "0x2E7C070", VA = "0x182E7CC70")]
	public static FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> DHHOBOEMPCG<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE> NCNPDGLPGME, FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>? CAPKHGDIEMA) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
		return default(FGLBFCBPBCD<NABKALKHCAF.JMLOIKDGGNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E7ECB0", Offset = "0x2E7E0B0", VA = "0x182E7ECB0")]
	public static void OEBDOCGAPOG<TDeps, TState>(this BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TState NOGEMBGGBHJ, int FMAGNPLPPGB) where TDeps : notnull, EPKAGCODFMF<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct DDMMKGOOEMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> LKAGMIFFHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> FJBFIBKAPBM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
	public DDMMKGOOEMB(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> FKIOEOLLGLG, FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> KDLHJCKNILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2239E00", Offset = "0x2239200", VA = "0x182239E00")]
	public static DDMMKGOOEMB AALKPJMFIHM(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> FKIOEOLLGLG)
	{
		return default(DDMMKGOOEMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NABKALKHCAF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class JAFPLGEKPGF : CPILEJGAIAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct KLMAGFHKMEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> PLLFLKJFDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LGPOLAJNCMC;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		public KLMAGFHKMEM(FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> LODPAMOBBEH, int AEAHMAMPNLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class CGPGGJCCOKB : CPILEJGAIAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct AGJFAAKKFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int LGPOLAJNCMC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public AGJFAAKKFKD(int AEAHMAMPNLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class IEPGAFNJOFH : CPILEJGAIAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FBKNMLEGHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> PLLFLKJFDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int LGPOLAJNCMC;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		public FBKNMLEGHOH(FGLBFCBPBCD<BODAOMHCKMN.NEOGCEDPDHC> LODPAMOBBEH, int AEAHMAMPNLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum MLHANHBCPEH
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
	public sealed class JMLOIKDGGNE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class CPILEJGAIAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NELCKJBANPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? CNEKFOPHIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DDMMKGOOEMB NBBGGNKNIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MLHANHBCPEH KKFCEJBOMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FGLBFCBPBCD<CPILEJGAIAF> BLMBOAFPIHP;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2242F10", Offset = "0x2242310", VA = "0x182242F10")]
		public NELCKJBANPG(int? EOCIGJMKBPH, [In] DDMMKGOOEMB PJCBBJMFEHJ, MLHANHBCPEH LCAGNMGCPNA, FGLBFCBPBCD<CPILEJGAIAF> HDKNKOIDEOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class OBKHFODKIMP : CPILEJGAIAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct FIIBCCPGKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int LGPOLAJNCMC;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		public FIIBCCPGKDP(int AEAHMAMPNLO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal NFEPLIBACNN<JMLOIKDGGNE, NELCKJBANPG> JGBPJMOFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal NFEPLIBACNN<JAFPLGEKPGF, KLMAGFHKMEM> DPPFOHBDELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal NFEPLIBACNN<IEPGAFNJOFH, FBKNMLEGHOH> LMLPODJMLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal NFEPLIBACNN<OBKHFODKIMP, FIIBCCPGKDP> OAJIHFNEDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal NFEPLIBACNN<CGPGGJCCOKB, AGJFAAKKFKD> IPEKIGGGGPE;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2242BB0", Offset = "0x2241FB0", VA = "0x182242BB0")]
	private NABKALKHCAF([In] NFEPLIBACNN<JMLOIKDGGNE, NELCKJBANPG> JHCGPAODEGN, [In] NFEPLIBACNN<JAFPLGEKPGF, KLMAGFHKMEM> PLJKGFHCGBE, [In] NFEPLIBACNN<IEPGAFNJOFH, FBKNMLEGHOH> GIENGCNJPKJ, [In] NFEPLIBACNN<OBKHFODKIMP, FIIBCCPGKDP> PLDJLNFDADG, [In] NFEPLIBACNN<CGPGGJCCOKB, AGJFAAKKFKD> GMCHIMKHKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x22429C0", Offset = "0x2241DC0", VA = "0x1822429C0")]
	public static NABKALKHCAF AALKPJMFIHM()
	{
		return default(NABKALKHCAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LACPJDKLIGA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2242850", Offset = "0x2241C50", VA = "0x182242850")]
	public static void LBHGGLOEOHI(this NABKALKHCAF MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CHFKMBLKLCB
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2239C90", Offset = "0x2239090", VA = "0x182239C90")]
	public static void EHNFAJDFHCN(BGPCPMDEAHA MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BADMNADNDGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FDJDHJNBKJJ> CIFJIBCMCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int FFBPEAAAPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int FOFAIMNPCOO;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2238790", Offset = "0x2237B90", VA = "0x182238790")]
	private BADMNADNDGG([In] GHFPPIONGBI<BODAOMHCKMN.NDOOLALGJGO, FDJDHJNBKJJ> OKHFGJPMNOF, int EEBIBIENBDC, int APEGELPKFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2238530", Offset = "0x2237930", VA = "0x182238530")]
	public static BADMNADNDGG AALKPJMFIHM()
	{
		return default(BADMNADNDGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x22385A0", Offset = "0x22379A0", VA = "0x1822385A0")]
	public void LBHGGLOEOHI([In] BGPCPMDEAHA NGJELCHDMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD74B0", Offset = "0x2BD68B0", VA = "0x182BD74B0")]
	public static void EHNFAJDFHCN<TDeps, TStateSys>(BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP, FGLBFCBPBCD<PKMIDGFKCAI> DAOIPHJHGNI) where TDeps : notnull, EPKAGCODFMF<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class BFFDFAEDNMB
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2238970", Offset = "0x2237D70", VA = "0x182238970")]
	public static void EHNFAJDFHCN(BGPCPMDEAHA MBGHIKEGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct BHLDDOIKELI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface ONBAOGOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JDKHJBAOOLH(GCECACNENLC<byte> KMHKFAONMGN, int OLLCPDJOJJB);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct ABDOKCMLOLP : ONBAOGOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x22382A0", Offset = "0x22376A0", VA = "0x1822382A0", Slot = "4")]
		public void JDKHJBAOOLH(GCECACNENLC<byte> KMHKFAONMGN, int OLLCPDJOJJB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct BECLOHPNHEI : ONBAOGOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x22388C0", Offset = "0x2237CC0", VA = "0x1822388C0", Slot = "4")]
		public void JDKHJBAOOLH(GCECACNENLC<byte> KMHKFAONMGN, int OLLCPDJOJJB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct HHNFKKNEFJA : ONBAOGOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2241F80", Offset = "0x2241380", VA = "0x182241F80", Slot = "4")]
		public void JDKHJBAOOLH(GCECACNENLC<byte> KMHKFAONMGN, int OLLCPDJOJJB)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct PFDEABBOIHO : ONBAOGOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2243150", Offset = "0x2242550", VA = "0x182243150", Slot = "4")]
		public void JDKHJBAOOLH(GCECACNENLC<byte> KMHKFAONMGN, int OLLCPDJOJJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class EDOGCJLHKII<TCallProcessorDeps> where TCallProcessorDeps : struct, ONBAOGOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps DILMOBAKENH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E750", Offset = "0x2F1DB50", VA = "0x182F1E750")]
		public static int EHNFAJDFHCN<TDeps, TStateSys>(TDeps ICFGLKCGHOG, TStateSys NOGEMBGGBHJ, BGPCPMDEAHA NGJELCHDMKO, [In] GCECACNENLC<byte> KFOBMMPNFED, int NNFDHNAHEAO) where TDeps : EPKAGCODFMF<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private GCECACNENLC<JIIHHGBDKAG> LHHMNOILOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>> MOKKAMNLGBE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2239950", Offset = "0x2238D50", VA = "0x182239950")]
	private BHLDDOIKELI([In] GCECACNENLC<JIIHHGBDKAG> PAPILHDGEOG, Dictionary<FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<BODAOMHCKMN.NDOOLALGJGO>> FBKAEPFBLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2239850", Offset = "0x2238C50", VA = "0x182239850")]
	public static BHLDDOIKELI AALKPJMFIHM()
	{
		return default(BHLDDOIKELI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2239910", Offset = "0x2238D10", VA = "0x182239910")]
	public void LBHGGLOEOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB0B0", Offset = "0x2BEA4B0", VA = "0x182BEB0B0")]
	public static void EHNFAJDFHCN<TDeps, TStateSys>(BGPCPMDEAHA MBGHIKEGJAA, TDeps ICFGLKCGHOG, TStateSys EAKDHOEILGP) where TDeps : EPKAGCODFMF<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DJICMPGDOIH<TDeps, TIndex, TValues> where TDeps : struct, NNBBNCHKLMN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps DILMOBAKENH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5C325B0", Offset = "0x5C319B0", VA = "0x185C325B0")]
	public static void EHNFAJDFHCN([In] GCECACNENLC<JIIHHGBDKAG> PAPILHDGEOG, int OEJMADFLOHD, TValues BIHDACIMKFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NNBBNCHKLMN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCECACNENLC<TIndex> PFBIJGADJDD(int OEJMADFLOHD, [In] TValues BIHDACIMKFK);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(TIndex AEAHMAMPNLO, [In] TValues BIHDACIMKFK);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNLDGCAAKGI(TIndex AEAHMAMPNLO, TValues BIHDACIMKFK, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface PFOOICIHKKA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex DOIPILAGMCM(int AEAHMAMPNLO);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FACIAGEELIB(TIndex AEAHMAMPNLO, [In] TValues BIHDACIMKFK);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> NFGGHBAECDF(TIndex AEAHMAMPNLO, [In] TValues BIHDACIMKFK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PMEHFLMOAHO<TDeps, TIndex, TValues> where TDeps : struct, PFOOICIHKKA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps DILMOBAKENH;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4B75730", Offset = "0x4B74B30", VA = "0x184B75730")]
	public static GCECACNENLC<TIndex> EHNFAJDFHCN(int OEJMADFLOHD, [In] TValues BIHDACIMKFK)
	{
		return default(GCECACNENLC<TIndex>);
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

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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x21773E0", Offset = "0x2175FE0", VA = "0x1821773E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct HODNHMOJEOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> LNKFACDADEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int FDEMFMNLEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
	public HODNHMOJEOG(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> OALBDPMKPJG, int APMEPKJBNGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AOIIIOJNEJI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class KKAAMLKKOEA : CILNGGPFALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct GEKGAPAEGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly OPFCIIADDEC<byte> FJKHNJNJGID;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x212B2C0", Offset = "0x2129EC0", VA = "0x18212B2C0")]
		public GEKGAPAEGCJ(OPFCIIADDEC<byte> NDKFLGEBABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21702D0", Offset = "0x216EED0", VA = "0x1821702D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IKLCKMDHLIB : CILNGGPFALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct BNPBNEPDMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> KHOKHIFJADN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public BNPBNEPDMKO(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> KAJEJOAEMFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum OHIHIPKPBNO
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
	public sealed class FPMPDGEBDFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class CILNGGPFALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct IKBINFPGMME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly OHIHIPKPBNO KEKMPMKLEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly FANMFDLLPNO<CILNGGPFALL> ODLCKGKCBMJ;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		public IKBINFPGMME(OHIHIPKPBNO ELBPNABFKDE, FANMFDLLPNO<CILNGGPFALL> HBHOCAGLOON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class BBHACNFAFEJ : CILNGGPFALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MOPOAADPFBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> AEEJCALBKDH;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public MOPOAADPFBO(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class EEHEOGNHNNI : CILNGGPFALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct BDOOKEMIHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly NHEPEOIIHBM BBLGCBOFDFK;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public BDOOKEMIHFD(NHEPEOIIHBM JBHMPCOBAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x216F250", Offset = "0x216DE50", VA = "0x18216F250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal OGDNMAHNAJD<FPMPDGEBDFH, IKBINFPGMME> JKKHONCGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal OGDNMAHNAJD<KKAAMLKKOEA, GEKGAPAEGCJ> ANBCDCMHBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal OGDNMAHNAJD<IKLCKMDHLIB, BNPBNEPDMKO> BCHIMCGDBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal OGDNMAHNAJD<BBHACNFAFEJ, MOPOAADPFBO> CDOGDAJEOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal OGDNMAHNAJD<EEHEOGNHNNI, BDOOKEMIHFD> DHGKABGGJIG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x216F1C0", Offset = "0x216DDC0", VA = "0x18216F1C0")]
	private AOIIIOJNEJI([In] OGDNMAHNAJD<FPMPDGEBDFH, IKBINFPGMME> FAKBEHJOGBG, [In] OGDNMAHNAJD<KKAAMLKKOEA, GEKGAPAEGCJ> HBAIDCJANOD, [In] OGDNMAHNAJD<IKLCKMDHLIB, BNPBNEPDMKO> DFPMMDOFBBC, [In] OGDNMAHNAJD<BBHACNFAFEJ, MOPOAADPFBO> JMLBGCPIEHN, [In] OGDNMAHNAJD<EEHEOGNHNNI, BDOOKEMIHFD> DKLLAAAFPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x216F080", Offset = "0x216DC80", VA = "0x18216F080")]
	public static AOIIIOJNEJI LMDPPDEOAIA()
	{
		return default(AOIIIOJNEJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MKPAEIDEEHJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2171C20", Offset = "0x2170820", VA = "0x182171C20")]
	public static void PAMNEBLPMKL(this AOIIIOJNEJI GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum BIOEMKJANDE
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
public struct IAEOLPPFPAC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class PDHINEPFHHI : BEHDENJEJHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct OHFIPIELJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> DFILKPPMCCN;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public OHFIPIELJIB(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> AKEIDPGBIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum ICOAFBHBJHK
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
	public sealed class GFJADCLCFIK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BEHDENJEJHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct GINHJDGBDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly ICOAFBHBJHK KEKMPMKLEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly FANMFDLLPNO<BEHDENJEJHN> ODLCKGKCBMJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		public GINHJDGBDHN(ICOAFBHBJHK ELBPNABFKDE, FANMFDLLPNO<BEHDENJEJHN> HBHOCAGLOON)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal OGDNMAHNAJD<GFJADCLCFIK, GINHJDGBDHN> JKKHONCGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OGDNMAHNAJD<PDHINEPFHHI, OHFIPIELJIB> JFPMHKEDEIF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2171280", Offset = "0x216FE80", VA = "0x182171280")]
	private IAEOLPPFPAC([In] OGDNMAHNAJD<GFJADCLCFIK, GINHJDGBDHN> FAKBEHJOGBG, [In] OGDNMAHNAJD<PDHINEPFHHI, OHFIPIELJIB> NMAOOIGHKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21711F0", Offset = "0x216FDF0", VA = "0x1821711F0")]
	public static IAEOLPPFPAC LMDPPDEOAIA()
	{
		return default(IAEOLPPFPAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HEPEMDCANDB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2171190", Offset = "0x216FD90", VA = "0x182171190")]
	public static void PAMNEBLPMKL(this IAEOLPPFPAC GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PHJNOGFFECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public FNPOPJLMFPF<int> LJKDHELFHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public FNPOPJLMFPF<int> NONNIJELCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JKPKNCGNGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int JFMOJJKPNLG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x217A030", Offset = "0x2178C30", VA = "0x18217A030")]
	private PHJNOGFFECL([In] FNPOPJLMFPF<int> MLMPDMEOCKG, [In] FNPOPJLMFPF<int> KMAPPGFOONN, int BJNFBPFENFP, int GDFDFANICJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2179F90", Offset = "0x2178B90", VA = "0x182179F90")]
	public static PHJNOGFFECL LMDPPDEOAIA()
	{
		return default(PHJNOGFFECL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NNBKMNGPOII
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21771A0", Offset = "0x2175DA0", VA = "0x1821771A0")]
	public static void PAMNEBLPMKL(this PHJNOGFFECL GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DJLBEPGMJGF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum GAICOAGKOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class GAOJOBCIMDN : HKBKDPAEJFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct MJEKAKGIGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly FANMFDLLPNO<BODBLHBKEEF> MHKMCEJALJG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public MJEKAKGIGNK(FANMFDLLPNO<BODBLHBKEEF> BLAPMJCDEJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class NFIDBIAJKFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HKBKDPAEJFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct AKBEDHAKFFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly GAICOAGKOHJ KEKMPMKLEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly FANMFDLLPNO<HKBKDPAEJFP> ODLCKGKCBMJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		private AKBEDHAKFFM(GAICOAGKOHJ ELBPNABFKDE, FANMFDLLPNO<HKBKDPAEJFP> HBHOCAGLOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x216EF40", Offset = "0x216DB40", VA = "0x18216EF40")]
		public static AKBEDHAKFFM LMDPPDEOAIA(GAICOAGKOHJ ELBPNABFKDE, FANMFDLLPNO<HKBKDPAEJFP> HBHOCAGLOON)
		{
			return default(AKBEDHAKFFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PGBHDOMCJAA : HKBKDPAEJFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct ICPNFCAEIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly FANMFDLLPNO<BODBLHBKEEF> MHKMCEJALJG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public ICPNFCAEIKL(FANMFDLLPNO<BODBLHBKEEF> BLAPMJCDEJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BODBLHBKEEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct MDKPFHELGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FNPOPJLMFPF<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> JEKFCBBGMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FNPOPJLMFPF<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> PLNJCJFIKAN;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2171280", Offset = "0x216FE80", VA = "0x182171280")]
		private MDKPFHELGHJ([In] FNPOPJLMFPF<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> BKJCCPIMCJE, [In] FNPOPJLMFPF<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> NPFOOMPGLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2171720", Offset = "0x2170320", VA = "0x182171720")]
		public static MDKPFHELGHJ LMDPPDEOAIA()
		{
			return default(MDKPFHELGHJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal OGDNMAHNAJD<NFIDBIAJKFA, AKBEDHAKFFM> JKKHONCGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal OGDNMAHNAJD<PGBHDOMCJAA, ICPNFCAEIKL> HIJEGODNGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal OGDNMAHNAJD<GAOJOBCIMDN, MJEKAKGIGNK> JLACKODMNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FNPOPJLMFPF<(FANMFDLLPNO<NFIDBIAJKFA> CallId, FANMFDLLPNO<BODBLHBKEEF> IOId)> FIKEBOLDPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal OGDNMAHNAJD<BODBLHBKEEF, MDKPFHELGHJ> GAHCGPLCJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal BJHMGMAGBFB<BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> BKBHAFKCNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal BJHMGMAGBFB<BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> BALOBJHKFCE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x216FC60", Offset = "0x216E860", VA = "0x18216FC60")]
	private DJLBEPGMJGF([In] OGDNMAHNAJD<NFIDBIAJKFA, AKBEDHAKFFM> FAKBEHJOGBG, [In] OGDNMAHNAJD<PGBHDOMCJAA, ICPNFCAEIKL> HHFPEINJEDC, [In] OGDNMAHNAJD<GAOJOBCIMDN, MJEKAKGIGNK> NMMBIHOKHOB, [In] FNPOPJLMFPF<(FANMFDLLPNO<NFIDBIAJKFA> CallId, FANMFDLLPNO<BODBLHBKEEF> IOId)> DHAEPMFJFLE, [In] OGDNMAHNAJD<BODBLHBKEEF, MDKPFHELGHJ> GFMBAOBBACF, [In] BJHMGMAGBFB<BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> BPEOLFBBGOE, [In] BJHMGMAGBFB<BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> JLMLCEHEGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x216FAC0", Offset = "0x216E6C0", VA = "0x18216FAC0")]
	public static DJLBEPGMJGF LMDPPDEOAIA()
	{
		return default(DJLBEPGMJGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class OCHIBALDGHB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2177670", Offset = "0x2176270", VA = "0x182177670")]
	private static void PAMNEBLPMKL(this DJLBEPGMJGF.MDKPFHELGHJ GMNCELIMKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2177460", Offset = "0x2176060", VA = "0x182177460")]
	public static void PAMNEBLPMKL(this DJLBEPGMJGF GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GJOFHKBNPFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public FNPOPJLMFPF<byte> NGNKHCAJMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal DJLBEPGMJGF NCNNEHEHFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal MIJEANECKMI JIIMLOLPALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> FJPGKHHFCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal AOIIIOJNEJI GNAKEAMNPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IAEOLPPFPAC GACCJDFCHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal BJHMGMAGBFB<MKNPBKPFDPA, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>?> FGOPBEKEOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FNPOPJLMFPF<FANMFDLLPNO<MKNPBKPFDPA>> MBMCEBLJFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> CMJDPIIFEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> NIPMNKNLGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> MJNEDBLMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal KCDGKLHFONM BMOBFEGIPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal GOEPGOOGCKH LKEDNDLMBDA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2170CF0", Offset = "0x216F8F0", VA = "0x182170CF0")]
	private GJOFHKBNPFF([In] FNPOPJLMFPF<byte> CNMPCJPKIAJ, [In] DJLBEPGMJGF HAANEJBMGKE, [In] MIJEANECKMI NJHJIMIEMEE, [In] AOIIIOJNEJI BKONCHCBBDL, [In] IAEOLPPFPAC APBNGJMMFBC, [In] BJHMGMAGBFB<MKNPBKPFDPA, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>?> HDMDHPCELAA, [In] FNPOPJLMFPF<FANMFDLLPNO<MKNPBKPFDPA>> HOONIKONPDB, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> IANABMGPLOE, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> BLLMKBCNOEK, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> PFNOKCMDBBL, [In] KCDGKLHFONM JJGCFKEBALE, [In] GOEPGOOGCKH NJHMJIPDBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2170340", Offset = "0x216EF40", VA = "0x182170340")]
	public static GJOFHKBNPFF LMDPPDEOAIA()
	{
		return default(GJOFHKBNPFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OGFPHDDHOIP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct ANFNIIHGNNP : GHGHFIPPIDL<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>, BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x216EFA0", Offset = "0x216DBA0", VA = "0x18216EFA0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x216F050", Offset = "0x216DC50", VA = "0x18216F050", Slot = "4")]
		public FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> NHKKBOFOHDB(int MFJLAMOCOBC)
		{
			return default(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
		public bool KKJCLOCFFGI(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "5")]
		private bool CMPJAIHFMEL(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x216EF90", Offset = "0x216DB90", VA = "0x18216EF90", Slot = "6")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> FHMDNDJFAHD(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct NOOLGHOBFFM : LOPKOMNMNHG<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>, BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x21771F0", Offset = "0x2175DF0", VA = "0x1821771F0")]
		public FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>> AJFHBIKABPC(int INNPMCHMCMC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2177260", Offset = "0x2175E60", VA = "0x182177260")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2177320", Offset = "0x2175F20", VA = "0x182177320", Slot = "6")]
		public void PGODFBICDIJ(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x21771F0", Offset = "0x2175DF0", VA = "0x1821771F0", Slot = "4")]
		private FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>> HJMELCGIBLI(int INNPMCHMCMC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2177310", Offset = "0x2175F10", VA = "0x182177310", Slot = "5")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> OJBLGPMKLLA(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct JGGILCFNJFK : GHGHFIPPIDL<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>, BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x21712D0", Offset = "0x216FED0", VA = "0x1821712D0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2171380", Offset = "0x216FF80", VA = "0x182171380", Slot = "4")]
		public FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> NHKKBOFOHDB(int MFJLAMOCOBC)
		{
			return default(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
		public bool KKJCLOCFFGI(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "5")]
		private bool AIHDGGHDPBL(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x21712C0", Offset = "0x216FEC0", VA = "0x1821712C0", Slot = "6")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> DKABCGNKPIL(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct CJADLNFBJDM : LOPKOMNMNHG<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>, BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x216F820", Offset = "0x216E420", VA = "0x18216F820")]
		public FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>> AJFHBIKABPC(int INNPMCHMCMC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x216F8A0", Offset = "0x216E4A0", VA = "0x18216F8A0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x216F950", Offset = "0x216E550", VA = "0x18216F950", Slot = "6")]
		public void PGODFBICDIJ(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x216F820", Offset = "0x216E420", VA = "0x18216F820", Slot = "4")]
		private FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>> PHNCHMFODEK(int INNPMCHMCMC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x216F890", Offset = "0x216E490", VA = "0x18216F890", Slot = "5")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> GPIDIOAIODD(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> MFJLAMOCOBC, [In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct OOPIMBEPCDC : GHGHFIPPIDL<FANMFDLLPNO<NGAFIAGIONI>, BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2179E00", Offset = "0x2178A00", VA = "0x182179E00")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2179F50", Offset = "0x2178B50", VA = "0x182179F50", Slot = "4")]
		public FANMFDLLPNO<NGAFIAGIONI> NHKKBOFOHDB(int MFJLAMOCOBC)
		{
			return default(FANMFDLLPNO<NGAFIAGIONI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2179ED0", Offset = "0x2178AD0", VA = "0x182179ED0")]
		public bool KKJCLOCFFGI(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2179ED0", Offset = "0x2178AD0", VA = "0x182179ED0", Slot = "5")]
		private bool KLHDDBNEOEL(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2179DF0", Offset = "0x21789F0", VA = "0x182179DF0", Slot = "6")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> DJGFBIGLHDH(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BNGOEBIFCBN : LOPKOMNMNHG<FANMFDLLPNO<NGAFIAGIONI>, BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x216F270", Offset = "0x216DE70", VA = "0x18216F270")]
		public FNPOPJLMFPF<FANMFDLLPNO<NGAFIAGIONI>> AJFHBIKABPC(int INNPMCHMCMC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<FANMFDLLPNO<NGAFIAGIONI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x216F2E0", Offset = "0x216DEE0", VA = "0x18216F2E0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x216F3C0", Offset = "0x216DFC0", VA = "0x18216F3C0", Slot = "6")]
		public void PGODFBICDIJ(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x216F270", Offset = "0x216DE70", VA = "0x18216F270", Slot = "4")]
		private FNPOPJLMFPF<FANMFDLLPNO<NGAFIAGIONI>> FBIPNDCMOFL(int INNPMCHMCMC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<FANMFDLLPNO<NGAFIAGIONI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x216F3B0", Offset = "0x216DFB0", VA = "0x18216F3B0", Slot = "5")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> KCBLJEHLNFB(FANMFDLLPNO<NGAFIAGIONI> MFJLAMOCOBC, [In] BJHMGMAGBFB<NGAFIAGIONI, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>?> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct CEHIPNCLEDO : GHGHFIPPIDL<int, FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x216F560", Offset = "0x216E160", VA = "0x18216F560")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x908830", Offset = "0x907430", VA = "0x180908830", Slot = "4")]
		public int NHKKBOFOHDB(int MFJLAMOCOBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
		public bool KKJCLOCFFGI(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "5")]
		private bool CLNHGPJNPHP(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x216F550", Offset = "0x216E150", VA = "0x18216F550", Slot = "6")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> GEDDAOOBDAO(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct NKAAABDHKEO : LOPKOMNMNHG<int, FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2176F80", Offset = "0x2175B80", VA = "0x182176F80")]
		public FNPOPJLMFPF<int> AJFHBIKABPC(int INNPMCHMCMC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2176FF0", Offset = "0x2175BF0", VA = "0x182176FF0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x21770A0", Offset = "0x2175CA0", VA = "0x1821770A0", Slot = "6")]
		public void PGODFBICDIJ(int MFJLAMOCOBC, FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2176F80", Offset = "0x2175B80", VA = "0x182176F80", Slot = "4")]
		private FNPOPJLMFPF<int> MDMBHHELDEN(int INNPMCHMCMC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2177090", Offset = "0x2175C90", VA = "0x182177090", Slot = "5")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> JJGDHDCDLEB(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> VariableId, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<NCGEEMOKEJE>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct CDPNPINAKBE : GHGHFIPPIDL<int, FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x216F4B0", Offset = "0x216E0B0", VA = "0x18216F4B0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x908830", Offset = "0x907430", VA = "0x180908830", Slot = "4")]
		public int NHKKBOFOHDB(int MFJLAMOCOBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
		public bool KKJCLOCFFGI(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "5")]
		private bool DGLJIEJMPFH(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x216F4A0", Offset = "0x216E0A0", VA = "0x18216F4A0", Slot = "6")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> DFICONHBAEI(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct EJJJFBLBALN : LOPKOMNMNHG<int, FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x216FDD0", Offset = "0x216E9D0", VA = "0x18216FDD0")]
		public FNPOPJLMFPF<int> AJFHBIKABPC(int INNPMCHMCMC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x216FE50", Offset = "0x216EA50", VA = "0x18216FE50")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x216FEF0", Offset = "0x216EAF0", VA = "0x18216FEF0", Slot = "6")]
		public void PGODFBICDIJ(int MFJLAMOCOBC, FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x216FDD0", Offset = "0x216E9D0", VA = "0x18216FDD0", Slot = "4")]
		private FNPOPJLMFPF<int> AGAOEDMMLHD(int INNPMCHMCMC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x216FE40", Offset = "0x216EA40", VA = "0x18216FE40", Slot = "5")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> FBBBFEJHPME(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct JPHKHIEAGAJ : GHGHFIPPIDL<int, FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x21713C0", Offset = "0x216FFC0", VA = "0x1821713C0")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x908830", Offset = "0x907430", VA = "0x180908830", Slot = "4")]
		public int NHKKBOFOHDB(int MFJLAMOCOBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
		public bool KKJCLOCFFGI(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "5")]
		private bool DGLJIEJMPFH(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x21713B0", Offset = "0x216FFB0", VA = "0x1821713B0", Slot = "6")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> DFICONHBAEI(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct CGNCCDGBBKH : LOPKOMNMNHG<int, FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x216F600", Offset = "0x216E200", VA = "0x18216F600")]
		public FNPOPJLMFPF<int> AJFHBIKABPC(int INNPMCHMCMC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x216F680", Offset = "0x216E280", VA = "0x18216F680")]
		public FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x216F720", Offset = "0x216E320", VA = "0x18216F720", Slot = "6")]
		public void PGODFBICDIJ(int MFJLAMOCOBC, FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x216F600", Offset = "0x216E200", VA = "0x18216F600", Slot = "4")]
		private FNPOPJLMFPF<int> AGAOEDMMLHD(int INNPMCHMCMC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FNPOPJLMFPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x216F670", Offset = "0x216E270", VA = "0x18216F670", Slot = "5")]
		private FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> FBBBFEJHPME(int MFJLAMOCOBC, [In] FNPOPJLMFPF<(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> Target, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> ByteCodeWriteLocation)> ILAABJMNJPL)
		{
			return default(FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LJHCMCFBHMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> EHHBOPJIPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool NPDKPDCIGKP;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1551EB0", Offset = "0x1550AB0", VA = "0x181551EB0")]
		public LJHCMCFBHMG(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG, bool DMDFNNAAKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2171710", Offset = "0x2170310", VA = "0x182171710")]
		public void KHJFAIMOGKG([Out] FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG, [Out] bool DMDFNNAAKGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct ALFHAJLBOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly FANMFDLLPNO<NGAFIAGIONI> KBOEEDPMDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> EHHBOPJIPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool NPDKPDCIGKP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x216EF80", Offset = "0x216DB80", VA = "0x18216EF80")]
		public ALFHAJLBOMK(FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG, bool DMDFNNAAKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x216EF50", Offset = "0x216DB50", VA = "0x18216EF50")]
		public void KHJFAIMOGKG([Out] FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG, [Out] bool DMDFNNAAKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x216EF60", Offset = "0x216DB60", VA = "0x18216EF60")]
		public void KHJFAIMOGKG([Out] FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG, [Out] FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI, [Out] bool DMDFNNAAKGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct PDAANGEACOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly FANMFDLLPNO<NGAFIAGIONI> KBOEEDPMDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> EHHBOPJIPIB;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		public PDAANGEACOH(FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2179F80", Offset = "0x2178B80", VA = "0x182179F80")]
		public void KHJFAIMOGKG([Out] FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG, [Out] FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2179840", Offset = "0x2178440", VA = "0x182179840")]
	public static void PAMNEBLPMKL(this GJOFHKBNPFF GMNCELIMKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x21777F0", Offset = "0x21763F0", VA = "0x1821777F0")]
	public static void AGDECHJNFGB(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> FJCADAFACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2177BA0", Offset = "0x21767A0", VA = "0x182177BA0")]
	public static void BMIIKCIKEHM(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> FJCADAFACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2178410", Offset = "0x2177010", VA = "0x182178410")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>? GHAHFKNKEOJ([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2177970", Offset = "0x2176570", VA = "0x182177970")]
	public static FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> ALMHCOPBDNM([In] this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2178E80", Offset = "0x2177A80", VA = "0x182178E80")]
	private static void LEBBFKALGCB(this GJOFHKBNPFF GMNCELIMKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2179650", Offset = "0x2178250", VA = "0x182179650")]
	private static FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>? OAJHFPICINK([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2177D00", Offset = "0x2176900", VA = "0x182177D00")]
	public static void CLJHDACDNEO(this GJOFHKBNPFF GMNCELIMKIF, [In] FNPOPJLMFPF<HODNHMOJEOG> DENNFIDPJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2179510", Offset = "0x2178110", VA = "0x182179510")]
	public static AOIIIOJNEJI.OHIHIPKPBNO NJHNGJCFDLB([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
	{
		return default(AOIIIOJNEJI.OHIHIPKPBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2179C50", Offset = "0x2178850", VA = "0x182179C50")]
	public static OPFCIIADDEC<byte> POACIHEMFIC([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
	{
		return default(OPFCIIADDEC<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2179750", Offset = "0x2178350", VA = "0x182179750")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OILMFAENEGL([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2178530", Offset = "0x2177130", VA = "0x182178530")]
	public static NHEPEOIIHBM HHNGEHEPCIM([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
	{
		return default(NHEPEOIIHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7850", Offset = "0x2FC6450", VA = "0x182FC7850")]
	private static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> JBDHNLLPOCL<TMJoin>(this GJOFHKBNPFF GMNCELIMKIF, AOIIIOJNEJI.OHIHIPKPBNO ELBPNABFKDE, FANMFDLLPNO<TMJoin> HBHOCAGLOON) where TMJoin : AOIIIOJNEJI.CILNGGPFALL
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2179490", Offset = "0x2178090", VA = "0x182179490")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> NGMCIHLOCGA(this GJOFHKBNPFF GMNCELIMKIF, bool EONJNGIIJFD)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2177B10", Offset = "0x2176710", VA = "0x182177B10")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> BLMOLKDDLIF(this GJOFHKBNPFF GMNCELIMKIF, OPFCIIADDEC<byte> NDKFLGEBABO)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2178D80", Offset = "0x2177980", VA = "0x182178D80")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> KEKBJOFBNHJ(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> KAJEJOAEMFB)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2177880", Offset = "0x2176480", VA = "0x182177880")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> AHHEIOIDCJH(this GJOFHKBNPFF GMNCELIMKIF, int HLMEDAOGNBG)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x21787C0", Offset = "0x21773C0", VA = "0x1821787C0")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> IHNLHMHNNIH(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FC77A0", Offset = "0x2FC63A0", VA = "0x182FC77A0")]
	private static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> IJBIKGHGBPC<TMJoin>(this GJOFHKBNPFF GMNCELIMKIF, IAEOLPPFPAC.ICOAFBHBJHK ELBPNABFKDE, FANMFDLLPNO<TMJoin> HBHOCAGLOON) where TMJoin : IAEOLPPFPAC.BEHDENJEJHN
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2179710", Offset = "0x2178310", VA = "0x182179710")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> OBDGLJNDALK(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2177AC0", Offset = "0x21766C0", VA = "0x182177AC0")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> BJJMOIEBCEE(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2178E00", Offset = "0x2177A00", VA = "0x182178E00")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> KKDAAAGHAHL(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> AKEIDPGBIPF)
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2178200", Offset = "0x2176E00", VA = "0x182178200")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> FBBAAIECPJJ(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2178D30", Offset = "0x2177930", VA = "0x182178D30")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> KDADPPJGGLN(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2179590", Offset = "0x2178190", VA = "0x182179590")]
	public static DJLBEPGMJGF.GAICOAGKOHJ NKPHOCMJKBD([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> CNGCFDKHAMM)
	{
		return default(DJLBEPGMJGF.GAICOAGKOHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2179610", Offset = "0x2178210", VA = "0x182179610")]
	public static JNNAAELBDFB<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>, JLIAMHHAACK<DJLBEPGMJGF.BODBLHBKEEF>> NLAAHPIKCML([In] this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(JNNAAELBDFB<FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>, JLIAMHHAACK<DJLBEPGMJGF.BODBLHBKEEF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2178840", Offset = "0x2177440", VA = "0x182178840")]
	public static FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> IKPIFGCNOOH([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> CNGCFDKHAMM)
	{
		return default(FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2178030", Offset = "0x2176C30", VA = "0x182178030")]
	public static DJLBEPGMJGF.MDKPFHELGHJ EBMJCDEEGJD([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> BLAPMJCDEJP)
	{
		return default(DJLBEPGMJGF.MDKPFHELGHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2178C20", Offset = "0x2177820", VA = "0x182178C20")]
	public static DJLBEPGMJGF.MDKPFHELGHJ JMLPCKCIHEB(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> BLAPMJCDEJP)
	{
		return default(DJLBEPGMJGF.MDKPFHELGHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6CC0", Offset = "0x2FC58C0", VA = "0x182FC6CC0")]
	private static FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> EDHEIPEGLJP<TMJoin>(this GJOFHKBNPFF GMNCELIMKIF, DJLBEPGMJGF.GAICOAGKOHJ ELBPNABFKDE, FANMFDLLPNO<TMJoin> HBHOCAGLOON) where TMJoin : DJLBEPGMJGF.HKBKDPAEJFP
	{
		return default(FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2179250", Offset = "0x2177E50", VA = "0x182179250")]
	public static (FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>) NAADPKHNBNL(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default((FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2178A70", Offset = "0x2177670", VA = "0x182178A70")]
	public static (FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>) IPAALFBCAGC(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default((FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2178A20", Offset = "0x2177620", VA = "0x182178A20")]
	public static FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> ILOFNCPIEMF(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2179400", Offset = "0x2178000", VA = "0x182179400")]
	public static void NAHFDDHHBAB(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF> BLAPMJCDEJP, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> IGDJMFINIMG, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>> DDPPKOKGODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6450", Offset = "0x2FC5050", VA = "0x182FC6450")]
	public static LJHCMCFBHMG APHLHKNAKDI<TDeps, TStateSys>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI) where TDeps : PNEKCDHBCAB<TStateSys>
	{
		return default(LJHCMCFBHMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6F60", Offset = "0x2FC5B60", VA = "0x182FC6F60")]
	public static ALFHAJLBOMK EPLKCEDHGKM<TDeps, TStateSys>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, int IJLIHPPNNDK) where TDeps : PNEKCDHBCAB<TStateSys>
	{
		return default(ALFHAJLBOMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7B20", Offset = "0x2FC6720", VA = "0x182FC7B20")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>? NAGGKPOKKKL<TDeps, TStateSys>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, [In] ReadOnlySpan<int> IBJGGDDIMJM, [In] Span<PDAANGEACOH> KNNOAADPBBM) where TDeps : PNEKCDHBCAB<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7400", Offset = "0x2FC6000", VA = "0x182FC7400")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> IEHGHEOLDLF<TDeps, TStateSys>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK) where TDeps : PNEKCDHBCAB<TStateSys>
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2178320", Offset = "0x2176F20", VA = "0x182178320")]
	public static MIJEANECKMI.AGMBLJKAHLD GDJDIEFLJPE([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MJDOIIBKEKN)
	{
		return default(MIJEANECKMI.AGMBLJKAHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2177E70", Offset = "0x2176A70", VA = "0x182177E70")]
	public static MIJEANECKMI.KDPDOELBDDC DHBDNMIDEJM([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MJDOIIBKEKN)
	{
		return default(MIJEANECKMI.KDPDOELBDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x21786D0", Offset = "0x21772D0", VA = "0x1821786D0")]
	public static MIJEANECKMI.GGJNGJCDIFN HLGCLKIHFAI([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MJDOIIBKEKN)
	{
		return default(MIJEANECKMI.GGJNGJCDIFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x21790C0", Offset = "0x2177CC0", VA = "0x1821790C0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MMHBIEFBJDE(this GJOFHKBNPFF GMNCELIMKIF, int? BCKJLIAECEH, string GMBAACDNNFI)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x21779D0", Offset = "0x21765D0", VA = "0x1821779D0")]
	public static MIJEANECKMI.OELAPDPHDEH ANMFBGLEAHJ([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MJDOIIBKEKN)
	{
		return default(MIJEANECKMI.OELAPDPHDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2177900", Offset = "0x2176500", VA = "0x182177900")]
	public static MIJEANECKMI.FIJMABPNDHI AKAHNBIJOAP([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MJDOIIBKEKN)
	{
		return default(MIJEANECKMI.FIJMABPNDHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2179050", Offset = "0x2177C50", VA = "0x182179050")]
	public static int? MLLAHEANIGA([In] this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MJDOIIBKEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6D60", Offset = "0x2FC5960", VA = "0x182FC6D60")]
	private static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EEJNFIFAMEE<TMJoin>(this GJOFHKBNPFF GMNCELIMKIF, int? BCKJLIAECEH, MIJEANECKMI.FIJMABPNDHI ELBPNABFKDE, FANMFDLLPNO<TMJoin> HBHOCAGLOON) where TMJoin : MIJEANECKMI.NHDOLFODKJM
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2178620", Offset = "0x2177220", VA = "0x182178620")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HKOPKMFDCCI(this GJOFHKBNPFF GMNCELIMKIF, int? BCKJLIAECEH, FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> CNGCFDKHAMM, int MFJLAMOCOBC)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2178FF0", Offset = "0x2177BF0", VA = "0x182178FF0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LPLCNEPNJHB(this GJOFHKBNPFF GMNCELIMKIF, int? BCKJLIAECEH)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x21780B0", Offset = "0x2176CB0", VA = "0x1821780B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHDAPOEMIFG(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? OAIAEEEEELG, int? BCKJLIAECEH)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2177C70", Offset = "0x2176870", VA = "0x182177C70")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CHFPKPGKPPP(this GJOFHKBNPFF GMNCELIMKIF, int? BCKJLIAECEH, int MFJLAMOCOBC)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x21784D0", Offset = "0x21770D0", VA = "0x1821784D0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GLCOAKPPHNO(this GJOFHKBNPFF GMNCELIMKIF, int? BCKJLIAECEH)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2179B10", Offset = "0x2178710", VA = "0x182179B10")]
	public static void PIGCFBGBGGB(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE, FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> CNGCFDKHAMM, int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21776C0", Offset = "0x21762C0", VA = "0x1821776C0")]
	public static void AAGIODBABIP(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE, int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2177F60", Offset = "0x2176B60", VA = "0x182177F60")]
	public static void DHFDAIONKNN(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2178CA0", Offset = "0x21778A0", VA = "0x182178CA0")]
	public static void JNGPDOJAJLM(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> CGJNNJHBPPG, FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> LKMIFPPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2178250", Offset = "0x2176E50", VA = "0x182178250")]
	public static void FNJKIPBPAPL(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE, FANMFDLLPNO<LNECMHMAHEC<NJCKLCGHEEC>> MOPCAPJCDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7100", Offset = "0x2FC5D00", VA = "0x182FC7100")]
	public static void HHJNBOKNMBG<M>(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NMOKMOAPCOE, FANMFDLLPNO<LNECMHMAHEC<LIKJHIGJMNN<M>>> MOPCAPJCDKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PNEKCDHBCAB<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FANMFDLLPNO<LBMHHPBEDFJ> BGEODKHPMGG(TStateSys NDHHEKIDGIN);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FANMFDLLPNO<LBMHHPBEDFJ> PBBCMBMCMAM(TStateSys NDHHEKIDGIN);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FANMFDLLPNO<LBMHHPBEDFJ> EJNFELJEFCE(TStateSys NDHHEKIDGIN);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FANMFDLLPNO<LBMHHPBEDFJ> HHLDGLMPEDF(TStateSys NDHHEKIDGIN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> IKNFPCCOBMM(TStateSys NDHHEKIDGIN, GJOFHKBNPFF IKPJMPHBLIL, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> AABMHPAPPNA(TStateSys NDHHEKIDGIN, GJOFHKBNPFF IKPJMPHBLIL, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PNBEMMIAOIF(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FANMFDLLPNO<MKNPBKPFDPA> CKEMLNIFJEF(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI, int FJMEADGFOCN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BIOEMKJANDE JNAAKOIKBJA(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EGGJNMKDKIK(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OJFIMNMFPLA(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OPFCIIADDEC<byte> OGCAKJOJFAF(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(OPFCIIADDEC<byte>, FANMFDLLPNO<LBMHHPBEDFJ>) CJIHMAIHJCH(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<NGAFIAGIONI> DMAAAHKLEEI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int PJHCCINABCN(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FANMFDLLPNO<NGAFIAGIONI> MBCJLPOOILE(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<MKNPBKPFDPA> LIBLJKEMGBK, int IJLIHPPNNDK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FANMFDLLPNO<NGAFIAGIONI> COFHFDJBCCK(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, FANMFDLLPNO<LOCKFIIFIFD> KPGLKHEJBED, int IJLIHPPNNDK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int NAFHILNLJCC(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? NGEPDHKOHKN(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, int MFJLAMOCOBC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int FKLBGHOAAIF(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? DDPFMLACJFE(TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN, int MFJLAMOCOBC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MPMHLFPOEGA
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F02AE0", Offset = "0x2F016E0", VA = "0x182F02AE0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO?> EKAMNCDNJJK<T, TOpInput, TOpOutput>(this GJOFHKBNPFF GMNCELIMKIF, T CKONCFGMELN, T GAAMPOEMOPE, int DPFKGBHNJML, IntPtr NFNEEOBGPJE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F04580", Offset = "0x2F03180", VA = "0x182F04580")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO?> PHBHDJFAPFP<T, TOpInput, TOpOutput>(this GJOFHKBNPFF GMNCELIMKIF, T CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE, int DPFKGBHNJML, IntPtr NFNEEOBGPJE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F01E20", Offset = "0x2F00A20", VA = "0x182F01E20")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO?> AMHIHMNAJOE<TOpInput, TOpOutput>(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE, int DPFKGBHNJML, IntPtr NFNEEOBGPJE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2173FB0", Offset = "0x2172BB0", VA = "0x182173FB0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HFBAGMBJMJJ(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, float EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x21755A0", Offset = "0x21741A0", VA = "0x1821755A0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LLNDKHMDBFF(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x21739B0", Offset = "0x21725B0", VA = "0x1821739B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GNDMFCPIDDK(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2173DB0", Offset = "0x21729B0", VA = "0x182173DB0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GPIEGAJJODA(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2176D20", Offset = "0x2175920", VA = "0x182176D20")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PNMNCFADJJM(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2175A00", Offset = "0x2174600", VA = "0x182175A00")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NDLNPCDCDHB(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2171FB0", Offset = "0x2170BB0", VA = "0x182171FB0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> BOBLCNJONGC(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2172EA0", Offset = "0x2171AA0", VA = "0x182172EA0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EKLPJPACPIJ(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2174E30", Offset = "0x2173A30", VA = "0x182174E30")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> KLOBMAAICKI(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2176460", Offset = "0x2175060", VA = "0x182176460")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OJHNECPDCOA(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, int GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2172C60", Offset = "0x2171860", VA = "0x182172C60")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EDEPCKLENMD(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2172FC0", Offset = "0x2171BC0", VA = "0x182172FC0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> FCFAADOCIFF(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2174730", Offset = "0x2173330", VA = "0x182174730")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> JMKACNLDMJC(this GJOFHKBNPFF GMNCELIMKIF, float CKONCFGMELN, float GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2174380", Offset = "0x2172F80", VA = "0x182174380")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> JDFHBNIDPEH(this GJOFHKBNPFF GMNCELIMKIF, float CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x21720B0", Offset = "0x2170CB0", VA = "0x1821720B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> BPAPKDHEBDN(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2171F30", Offset = "0x2170B30", VA = "0x182171F30")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> BMMMMAHHFGL(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, int GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x21768C0", Offset = "0x21754C0", VA = "0x1821768C0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PAJBFPGBCJG(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x21721F0", Offset = "0x2170DF0", VA = "0x1821721F0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CCEIOCHFENF(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x21735C0", Offset = "0x21721C0", VA = "0x1821735C0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> FIALCEPGFIA(this GJOFHKBNPFF GMNCELIMKIF, float CKONCFGMELN, float GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2172AC0", Offset = "0x21716C0", VA = "0x182172AC0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> DLKKNPCAPBN(this GJOFHKBNPFF GMNCELIMKIF, float CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2176B80", Offset = "0x2175780", VA = "0x182176B80")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PLJBFAJFMGG(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2176950", Offset = "0x2175550", VA = "0x182176950")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PGBHNKHHKFG(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, int GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2173AF0", Offset = "0x21726F0", VA = "0x182173AF0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GNFCPFFDAGD(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x21756C0", Offset = "0x21742C0", VA = "0x1821756C0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LMDGODIMIOK(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2173640", Offset = "0x2172240", VA = "0x182173640")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> FKJCOFDPOKL(this GJOFHKBNPFF GMNCELIMKIF, float CKONCFGMELN, float GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21737F0", Offset = "0x21723F0", VA = "0x1821737F0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GIGEGNMOOLE(this GJOFHKBNPFF GMNCELIMKIF, float CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2173540", Offset = "0x2172140", VA = "0x182173540")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> FGLPKKBGHNJ(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x21741D0", Offset = "0x2172DD0", VA = "0x1821741D0")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> IGMJEHHGOGO(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2173D30", Offset = "0x2172930", VA = "0x182173D30")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> GOHEMBIEGPM(this GJOFHKBNPFF GMNCELIMKIF, int CABLCDOIFFL)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2173C90", Offset = "0x2172890", VA = "0x182173C90")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> GOEFDNBMNOK(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CABLCDOIFFL)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2172910", Offset = "0x2171510", VA = "0x182172910")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> DIOJMBIFAJL(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> HCNLNACOEIG)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x21769D0", Offset = "0x21755D0", VA = "0x1821769D0")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> PKMIDMNJHDC(this GJOFHKBNPFF GMNCELIMKIF, int CABLCDOIFFL)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2171CD0", Offset = "0x21708D0", VA = "0x182171CD0")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> AIEDOOLGNKG(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CABLCDOIFFL)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2173100", Offset = "0x2171D00", VA = "0x182173100")]
	public static (FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>) FFMKCECDFKC(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<ENAGOLEEKBG> BCGPCJAGDKA, [In] ReadOnlySpan<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> BKJCCPIMCJE, [In] ReadOnlySpan<int?> GJPNEAFHEKK, [In] Span<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> GDDJPMKAMDM)
	{
		return default((FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x21749F0", Offset = "0x21735F0", VA = "0x1821749F0")]
	public static (FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>) KJJDJFCOCOB(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<FMHNIDCJDLK> IBFLHHJJCNB, [In] ReadOnlySpan<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> BKJCCPIMCJE, [In] ReadOnlySpan<int?> GJPNEAFHEKK, [In] Span<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> GDDJPMKAMDM)
	{
		return default((FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F01F90", Offset = "0x2F00B90", VA = "0x182F01F90")]
	public static (FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<LNECMHMAHEC<LBMHHPBEDFJ>>, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>, FANMFDLLPNO<LNECMHMAHEC<TMarker>>, FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>) DDFKOKKPAME<TMarker>(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<LBMHHPBEDFJ> KCOPCPIMMHC, [In] ReadOnlySpan<byte> BFLLAIFBMAJ)
	{
		return default((FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<LNECMHMAHEC<LBMHHPBEDFJ>>, FANMFDLLPNO<LNECMHMAHEC<OPKHCAMJNKP>>, FANMFDLLPNO<LNECMHMAHEC<TMarker>>, FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2174930", Offset = "0x2173530", VA = "0x182174930")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> KELPEPELPCD(this GJOFHKBNPFF GMNCELIMKIF, int HLJPFAJADEK, [Optional] FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x21751A0", Offset = "0x2173DA0", VA = "0x1821751A0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LBJADDDPIGK(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HLJPFAJADEK, [Optional] FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x21753B0", Offset = "0x2173FB0", VA = "0x1821753B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LEOJGBFJEMM(this GJOFHKBNPFF GMNCELIMKIF, [In] ReadOnlySpan<byte> HLJPFAJADEK, [Optional] FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x21725F0", Offset = "0x21711F0", VA = "0x1821725F0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CPPKDIEPPOP(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HLJPFAJADEK, int OLKJNOHMJPI, [Optional] FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x21724F0", Offset = "0x21710F0", VA = "0x1821724F0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CGLIBOKDMIG(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, float EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2172B40", Offset = "0x2171740", VA = "0x182172B40")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> DOAMFNOLNHP(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2176560", Offset = "0x2175160", VA = "0x182176560")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OMKLAEBCEFD(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2173EB0", Offset = "0x2172AB0", VA = "0x182173EB0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HDNHMACEGHD(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2173B70", Offset = "0x2172770", VA = "0x182173B70")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GOECNICMKJB(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x21723B0", Offset = "0x2170FB0", VA = "0x1821723B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CFOBGNKBGCA(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2171D70", Offset = "0x2170970", VA = "0x182171D70")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> BAOOOEOAHOI(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, int GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x21763E0", Offset = "0x2174FE0", VA = "0x1821763E0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OHDLAHGFANL(this GJOFHKBNPFF GMNCELIMKIF, int CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2175880", Offset = "0x2174480", VA = "0x182175880")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MLJEGLCHDLH(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CKONCFGMELN, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GAAMPOEMOPE)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x21762E0", Offset = "0x2174EE0", VA = "0x1821762E0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OFFEJGCLFHN(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, float EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2176A50", Offset = "0x2175650", VA = "0x182176A50")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PKPBLFEGAJA(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2175740", Offset = "0x2174340", VA = "0x182175740")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LPBBKDCHNBK(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2172810", Offset = "0x2171410", VA = "0x182172810")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> DGDKPCCHDFP(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2175290", Offset = "0x2173E90", VA = "0x182175290")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LEJODOHAPJO(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2172270", Offset = "0x2170E70", VA = "0x182172270")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CFDHKKJPJON(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2175B40", Offset = "0x2174740", VA = "0x182175B40")]
	public static FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>> NMFDOMCAOEC(this GJOFHKBNPFF GMNCELIMKIF)
	{
		return default(FANMFDLLPNO<LNECMHMAHEC<LNECMHMAHEC<HENPDNMICCH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2174830", Offset = "0x2173430", VA = "0x182174830")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> JOLACJLEFAN(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, float EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2176C00", Offset = "0x2175800", VA = "0x182176C00")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PMHOMPCKIDI(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2173870", Offset = "0x2172470", VA = "0x182173870")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> GMGNHHLGJLI(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x21767C0", Offset = "0x21753C0", VA = "0x1821767C0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OPBGMIGCLPN(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x21766A0", Offset = "0x21752A0", VA = "0x1821766A0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OONELNALHMJ(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x21744B0", Offset = "0x21730B0", VA = "0x1821744B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> JFNKGPEHNCI(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2175900", Offset = "0x2174500", VA = "0x182175900")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> MMDJHMDFMOM(this GJOFHKBNPFF GMNCELIMKIF, int CABLCDOIFFL)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2175090", Offset = "0x2173C90", VA = "0x182175090")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LAFIFHINNOD(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> CABLCDOIFFL)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2176940", Offset = "0x2175540", VA = "0x182176940")]
	public static void PFHILGFBICO(this GJOFHKBNPFF GMNCELIMKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2172710", Offset = "0x2171310", VA = "0x182172710")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> DBKMBHPILND(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, float EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2172D80", Offset = "0x2171980", VA = "0x182172D80")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EFFMJBNOKEE(this GJOFHKBNPFF GMNCELIMKIF, float NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x21745F0", Offset = "0x21731F0", VA = "0x1821745F0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> JLODCNIOEJN(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2175B60", Offset = "0x2174760", VA = "0x182175B60")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OBJBFGKJAON(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x21740B0", Offset = "0x2172CB0", VA = "0x1821740B0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HPPLDGPGCHK(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2171DF0", Offset = "0x21709F0", VA = "0x182171DF0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> BJICNCELJEH(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2175C60", Offset = "0x2174860", VA = "0x182175C60")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OCONCPELFEI(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> LJNPNLDDEPN, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> MMGGACIDGGI)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x21754A0", Offset = "0x21740A0", VA = "0x1821754A0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> LKCJLNIOLHE(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, int EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2174F70", Offset = "0x2173B70", VA = "0x182174F70")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> KPINMOBGBCG(this GJOFHKBNPFF GMNCELIMKIF, int NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2176E40", Offset = "0x2175A40", VA = "0x182176E40")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> PPLPCFLIFDE(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NCFLIBONDGJ, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> EHJFNIJOLMP)
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2F03570", Offset = "0x2F02170", VA = "0x182F03570")]
	public static void JDGFGFAGLIO<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<ENAGOLEEKBG> BCGPCJAGDKA, [In] ReadOnlySpan<FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>> JLGCAEJJBGI, [In] ReadOnlySpan<int?> GJPNEAFHEKK, [In] Span<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> GDDJPMKAMDM, [In] Span<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> CBNGJKLOIAB, [In] ReadOnlySpan<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>?> EJGHJKBLHGI) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2F03B10", Offset = "0x2F02710", VA = "0x182F03B10")]
	public static void JHJENGHNBCE<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<FMHNIDCJDLK> AKLCLFEHBGE, [In] ReadOnlySpan<FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>> CMGKGFJBAJE, [In] ReadOnlySpan<int?> GJPNEAFHEKK, [In] Span<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> GDDJPMKAMDM, [In] Span<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>> CBNGJKLOIAB, [In] ReadOnlySpan<FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>?> EJGHJKBLHGI) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2F03ED0", Offset = "0x2F02AD0", VA = "0x182F03ED0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> NJKGNDIBMHP<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OAIAEEEEELG, [Optional] FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2F01BF0", Offset = "0x2F007F0", VA = "0x182F01BF0")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> AEMNHKOEDFK<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> AKEIDPGBIPF, [Optional] FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2F03170", Offset = "0x2F01D70", VA = "0x182F03170")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> IPGMLIMBAFA<TDeps, TStateSys>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN) where TDeps : notnull, PNEKCDHBCAB<TStateSys> where TStateSys : notnull
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2F040B0", Offset = "0x2F02CB0", VA = "0x182F040B0")]
	public static FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK> NNACGDCLJCJ<TDeps, TStateSys>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN) where TDeps : notnull, PNEKCDHBCAB<TStateSys> where TStateSys : notnull
	{
		return default(FANMFDLLPNO<IAEOLPPFPAC.GFJADCLCFIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x21736C0", Offset = "0x21722C0", VA = "0x1821736C0")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> GDPHEOELPEI(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> KCMNKPPLPDN, IntPtr GDOPJMKKOFL, IntPtr JLGOGFBMJGG)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2175FE0", Offset = "0x2174BE0", VA = "0x182175FE0")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> OEBPNPLKFKE(this GJOFHKBNPFF GMNCELIMKIF, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> KDKLJFJJMMK, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> JNCALHABFCA, IntPtr AHCEIEADJCM, IntPtr KMPLPDPGLOO, IntPtr JJOKKIFPAEI, bool BDCBHMPKOOA)
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2F025C0", Offset = "0x2F011C0", VA = "0x182F025C0")]
	public static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> DHHPLDBFCOG<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<ENAGOLEEKBG> IKHANNGOHJJ, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> KDKLJFJJMMK, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> JNCALHABFCA, int? EKJOAODMIAH, [Optional] IntPtr EPKBDLNBCOE) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2F027D0", Offset = "0x2F013D0", VA = "0x182F027D0")]
	private static FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> DHHPLDBFCOG<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<ENAGOLEEKBG> IKHANNGOHJJ, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> KDKLJFJJMMK, FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH> JNCALHABFCA, int? EKJOAODMIAH) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
		return default(FANMFDLLPNO<AOIIIOJNEJI.FPMPDGEBDFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2F04390", Offset = "0x2F02F90", VA = "0x182F04390")]
	public static FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> OMLEPKCHNFO<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO> HLJPFAJADEK, FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>? IMHEBCOFMGN) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
		return default(FANMFDLLPNO<MIJEANECKMI.PHHFIDHLAJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2F02F10", Offset = "0x2F01B10", VA = "0x182F02F10")]
	public static void IBLKNGNNAFL<TDeps, TState>(this GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TState GFCPLDIMNPM, int EHPMPIDDBMJ) where TDeps : notnull, PNEKCDHBCAB<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KDCNDNLPAOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> IPJPCBADHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> AKOAKEEGBOK;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
	public KDCNDNLPAOH(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> BLOAFDAFEBD, FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> OOILENKKEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2171700", Offset = "0x2170300", VA = "0x182171700")]
	public static KDCNDNLPAOH LMDPPDEOAIA(FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>> BLOAFDAFEBD)
	{
		return default(KDCNDNLPAOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct MIJEANECKMI
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class OLLKHGDOPDJ : NHDOLFODKJM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct AGMBLJKAHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> HMEJLLEPMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int NAJFJJKNBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		public AGMBLJKAHLD(FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> CNGCFDKHAMM, int MFJLAMOCOBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MNKGKCHGAOP : NHDOLFODKJM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct KDPDOELBDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int NAJFJJKNBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public KDPDOELBDDC(int MFJLAMOCOBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class OJLJOBBOEOM : NHDOLFODKJM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct GGJNGJCDIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> HMEJLLEPMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int NAJFJJKNBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		public GGJNGJCDIFN(FANMFDLLPNO<DJLBEPGMJGF.NFIDBIAJKFA> CNGCFDKHAMM, int MFJLAMOCOBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum FIJMABPNDHI
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
	public sealed class PHHFIDHLAJO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class NHDOLFODKJM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FCKIHGOBNMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? AIAIEAJPPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KDCNDNLPAOH ICNOKGKCAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FIJMABPNDHI KEKMPMKLEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FANMFDLLPNO<NHDOLFODKJM> ODLCKGKCBMJ;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2170230", Offset = "0x216EE30", VA = "0x182170230")]
		public FCKIHGOBNMB(int? BCKJLIAECEH, [In] KDCNDNLPAOH DCLMDDAMOCK, FIJMABPNDHI ELBPNABFKDE, FANMFDLLPNO<NHDOLFODKJM> HBHOCAGLOON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class OCFHLAHHLMN : NHDOLFODKJM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OELAPDPHDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int NAJFJJKNBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		public OELAPDPHDEH(int MFJLAMOCOBC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal JJHKFFFPFEK<PHHFIDHLAJO, FCKIHGOBNMB> JKKHONCGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal JJHKFFFPFEK<OLLKHGDOPDJ, AGMBLJKAHLD> CKGEJCKBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal JJHKFFFPFEK<OJLJOBBOEOM, GGJNGJCDIFN> JANBLJKPKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal JJHKFFFPFEK<OCFHLAHHLMN, OELAPDPHDEH> AIBMPOMCKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal JJHKFFFPFEK<MNKGKCHGAOP, KDPDOELBDDC> POHHPNOGCBE;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2171AF0", Offset = "0x21706F0", VA = "0x182171AF0")]
	private MIJEANECKMI([In] JJHKFFFPFEK<PHHFIDHLAJO, FCKIHGOBNMB> FAKBEHJOGBG, [In] JJHKFFFPFEK<OLLKHGDOPDJ, AGMBLJKAHLD> DIGLLPAMPGM, [In] JJHKFFFPFEK<OJLJOBBOEOM, GGJNGJCDIFN> JABGGMBBMAC, [In] JJHKFFFPFEK<OCFHLAHHLMN, OELAPDPHDEH> HNIIDIFHGLL, [In] JJHKFFFPFEK<MNKGKCHGAOP, KDPDOELBDDC> JDEHKEMMOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2171900", Offset = "0x2170500", VA = "0x182171900")]
	public static MIJEANECKMI LMDPPDEOAIA()
	{
		return default(MIJEANECKMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class DBCJGOKMNMK
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x216FA10", Offset = "0x216E610", VA = "0x18216FA10")]
	public static void PAMNEBLPMKL(this MIJEANECKMI GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MHNDDNBCGCE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x21717A0", Offset = "0x21703A0", VA = "0x1821717A0")]
	public static void HBJCFKJEPNA(GJOFHKBNPFF GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KCDGKLHFONM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, PHJNOGFFECL> ANGCHBDKAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int HHIABCJGJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int HPJOKJHLHEJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x21716C0", Offset = "0x21702C0", VA = "0x1821716C0")]
	private KCDGKLHFONM([In] BJHMGMAGBFB<DJLBEPGMJGF.BODBLHBKEEF, PHJNOGFFECL> JFHIPPCHDJN, int BJPMKPBKALD, int EODBLCFNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2171460", Offset = "0x2170060", VA = "0x182171460")]
	public static KCDGKLHFONM LMDPPDEOAIA()
	{
		return default(KCDGKLHFONM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x21714D0", Offset = "0x21700D0", VA = "0x1821714D0")]
	public void PAMNEBLPMKL([In] GJOFHKBNPFF FLMGBGGMEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC4080", Offset = "0x2EC2C80", VA = "0x182EC4080")]
	public static void HBJCFKJEPNA<TDeps, TStateSys>(GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN, FANMFDLLPNO<LNEKKJBHBEC> JHHAGEEOAEN) where TDeps : notnull, PNEKCDHBCAB<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EOFAABOLGEG
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x216FFE0", Offset = "0x216EBE0", VA = "0x18216FFE0")]
	public static void HBJCFKJEPNA(GJOFHKBNPFF GMNCELIMKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct GOEPGOOGCKH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface MJFBBFKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HAJDEPGJGEJ(FNPOPJLMFPF<byte> CNMPCJPKIAJ, int PAJEICNBNJI);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct FIGDHOABHOO : MJFBBFKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2170250", Offset = "0x216EE50", VA = "0x182170250", Slot = "4")]
		public void HAJDEPGJGEJ(FNPOPJLMFPF<byte> CNMPCJPKIAJ, int PAJEICNBNJI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct OILFKFFKCBB : MJFBBFKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2179D40", Offset = "0x2178940", VA = "0x182179D40", Slot = "4")]
		public void HAJDEPGJGEJ(FNPOPJLMFPF<byte> CNMPCJPKIAJ, int PAJEICNBNJI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct FAAIKLNINOL : MJFBBFKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x21701B0", Offset = "0x216EDB0", VA = "0x1821701B0", Slot = "4")]
		public void HAJDEPGJGEJ(FNPOPJLMFPF<byte> CNMPCJPKIAJ, int PAJEICNBNJI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct EJBOAJFDEOH : MJFBBFKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x216FD20", Offset = "0x216E920", VA = "0x18216FD20", Slot = "4")]
		public void HAJDEPGJGEJ(FNPOPJLMFPF<byte> CNMPCJPKIAJ, int PAJEICNBNJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class AHPBEMIMAMA<TCallProcessorDeps> where TCallProcessorDeps : struct, MJFBBFKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps KPJEAHOHOKA;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2787FD0", Offset = "0x2786BD0", VA = "0x182787FD0")]
		public static int HBJCFKJEPNA<TDeps, TStateSys>(TDeps DDNPAGAAIOD, TStateSys GFCPLDIMNPM, GJOFHKBNPFF FLMGBGGMEON, [In] FNPOPJLMFPF<byte> BFPKFLKEEDP, int DEPMLOLMHNL) where TDeps : PNEKCDHBCAB<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private FNPOPJLMFPF<HODNHMOJEOG> EPKNACCKDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>> CEDOPBAEHBG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2171150", Offset = "0x216FD50", VA = "0x182171150")]
	private GOEPGOOGCKH([In] FNPOPJLMFPF<HODNHMOJEOG> DENNFIDPJDL, Dictionary<FANMFDLLPNO<LNECMHMAHEC<HENPDNMICCH>>, FANMFDLLPNO<DJLBEPGMJGF.BODBLHBKEEF>> ILPJOIAFLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2171050", Offset = "0x216FC50", VA = "0x182171050")]
	public static GOEPGOOGCKH LMDPPDEOAIA()
	{
		return default(GOEPGOOGCKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2171110", Offset = "0x216FD10", VA = "0x182171110")]
	public void PAMNEBLPMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F790", Offset = "0x2E0E390", VA = "0x182E0F790")]
	public static void HBJCFKJEPNA<TDeps, TStateSys>(GJOFHKBNPFF GMNCELIMKIF, TDeps DDNPAGAAIOD, TStateSys NDHHEKIDGIN) where TDeps : PNEKCDHBCAB<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class KPDGEFDKANG<TDeps, TIndex, TValues> where TDeps : struct, LOPKOMNMNHG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x42E1990", Offset = "0x42E0590", VA = "0x1842E1990")]
	public static void HBJCFKJEPNA([In] FNPOPJLMFPF<HODNHMOJEOG> DENNFIDPJDL, int INNPMCHMCMC, TValues ILAABJMNJPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface LOPKOMNMNHG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNPOPJLMFPF<TIndex> AJFHBIKABPC(int INNPMCHMCMC, [In] TValues ILAABJMNJPL);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(TIndex MFJLAMOCOBC, [In] TValues ILAABJMNJPL);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGODFBICDIJ(TIndex MFJLAMOCOBC, TValues ILAABJMNJPL, FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GHGHFIPPIDL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex NHKKBOFOHDB(int MFJLAMOCOBC);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKJCLOCFFGI(TIndex MFJLAMOCOBC, [In] TValues ILAABJMNJPL);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FANMFDLLPNO<LNECMHMAHEC<NCGEEMOKEJE>> IAHCOEHPAKM(TIndex MFJLAMOCOBC, [In] TValues ILAABJMNJPL);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class AHCKFMFOGHA<TDeps, TIndex, TValues> where TDeps : struct, GHGHFIPPIDL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB51A0", Offset = "0x3EB3DA0", VA = "0x183EB51A0")]
	public static FNPOPJLMFPF<TIndex> HBJCFKJEPNA(int INNPMCHMCMC, [In] TValues ILAABJMNJPL)
	{
		return default(FNPOPJLMFPF<TIndex>);
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

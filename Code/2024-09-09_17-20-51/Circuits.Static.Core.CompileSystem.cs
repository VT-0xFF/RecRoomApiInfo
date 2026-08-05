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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x21513A0", Offset = "0x214FDA0", VA = "0x1821513A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct BBEHPNAKAOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> ONBBGLBFEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int DLIHEBHOHOH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
	public BBEHPNAKAOM(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> MHCPAPBOMNJ, int EDCGGCHLNEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MCAMHENOGDC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class NPMAALBOHLA : DMELOCLMNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BFIFCJBGEEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly LHPDPPIAGFF<byte> FDOLFAKONLG;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20F13A0", Offset = "0x20EFDA0", VA = "0x1820F13A0")]
		public BFIFCJBGEEH(LHPDPPIAGFF<byte> MGCOGNAKONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x214EE70", Offset = "0x214D870", VA = "0x18214EE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class DCONBKKLCHF : DMELOCLMNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct DOGKODBIDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> INGIMJLDNDK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public DOGKODBIDGO(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> KNOFJBKPOGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum KGNIBAJMEBP
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
	public sealed class LNCHPGFDOOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class DMELOCLMNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OHCFLDKBAMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly KGNIBAJMEBP KEFMMNPDOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly OPGJAFEOJCM<DMELOCLMNMO> ILFDPFNGLNA;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		public OHCFLDKBAMF(KGNIBAJMEBP KCPEHAEAELG, OPGJAFEOJCM<DMELOCLMNMO> DBPPEGHBDHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NIBBEMGFGFA : DMELOCLMNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct JLINHJMHHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CLCOFFNIEPN;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public JLINHJMHHFA(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class KHINLDNMKMB : DMELOCLMNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct GBBOLDKNILD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CPPMLHJKLEH GMGMBCLFHPE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public GBBOLDKNILD(CPPMLHJKLEH DHNLDMLMFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x214F8C0", Offset = "0x214E2C0", VA = "0x18214F8C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal GOBIBBLPCBH<LNCHPGFDOOC, OHCFLDKBAMF> IJMELBOFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal GOBIBBLPCBH<NPMAALBOHLA, BFIFCJBGEEH> NCCNAEAHKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal GOBIBBLPCBH<DCONBKKLCHF, DOGKODBIDGO> PJNCEPHNLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GOBIBBLPCBH<NIBBEMGFGFA, JLINHJMHHFA> IEAIFPCBCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal GOBIBBLPCBH<KHINLDNMKMB, GBBOLDKNILD> LJKELDDNAHI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2150DB0", Offset = "0x214F7B0", VA = "0x182150DB0")]
	private MCAMHENOGDC([In] GOBIBBLPCBH<LNCHPGFDOOC, OHCFLDKBAMF> NHKOCMGDPBO, [In] GOBIBBLPCBH<NPMAALBOHLA, BFIFCJBGEEH> KHANBMIBLOC, [In] GOBIBBLPCBH<DCONBKKLCHF, DOGKODBIDGO> AGLDGKIJBKJ, [In] GOBIBBLPCBH<NIBBEMGFGFA, JLINHJMHHFA> ENBHLLIBJAJ, [In] GOBIBBLPCBH<KHINLDNMKMB, GBBOLDKNILD> IEDDHNBAKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2150C70", Offset = "0x214F670", VA = "0x182150C70")]
	public static MCAMHENOGDC OOAFHJGKFEK()
	{
		return default(MCAMHENOGDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CBAOILDOACG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x214EEE0", Offset = "0x214D8E0", VA = "0x18214EEE0")]
	public static void MOGENANDEFO(this MCAMHENOGDC NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OCHOKEGIKDP
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
public struct NNPKAHMPKDO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class HNMEDKGCGBF : LLFIPOGAEIA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ACCDIKOGPKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KHBFJNPEHIK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public ACCDIKOGPKB(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> BLEAPCCMDNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum KPBLFKIJKOL
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
	public sealed class CKGIEAPGHEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class LLFIPOGAEIA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct LNHPPHDJINP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly KPBLFKIJKOL KEFMMNPDOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly OPGJAFEOJCM<LLFIPOGAEIA> ILFDPFNGLNA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		public LNHPPHDJINP(KPBLFKIJKOL KCPEHAEAELG, OPGJAFEOJCM<LLFIPOGAEIA> DBPPEGHBDHI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal GOBIBBLPCBH<CKGIEAPGHEI, LNHPPHDJINP> IJMELBOFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GOBIBBLPCBH<HNMEDKGCGBF, ACCDIKOGPKB> HCPHLPBHIDH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2150B80", Offset = "0x214F580", VA = "0x182150B80")]
	private NNPKAHMPKDO([In] GOBIBBLPCBH<CKGIEAPGHEI, LNHPPHDJINP> NHKOCMGDPBO, [In] GOBIBBLPCBH<HNMEDKGCGBF, ACCDIKOGPKB> MLJOFNKPDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2151310", Offset = "0x214FD10", VA = "0x182151310")]
	public static NNPKAHMPKDO OOAFHJGKFEK()
	{
		return default(NNPKAHMPKDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HLIAMOBPMKL
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x214FFA0", Offset = "0x214E9A0", VA = "0x18214FFA0")]
	public static void MOGENANDEFO(this NNPKAHMPKDO NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EJOLGGLEIDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public LPKDJPNEIBH<int> DNMFJOFEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public LPKDJPNEIBH<int> GCOIDJHADPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CEPLAEOIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int BOHOEPJAEHI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x214F360", Offset = "0x214DD60", VA = "0x18214F360")]
	private EJOLGGLEIDA([In] LPKDJPNEIBH<int> GILLJOEEDCM, [In] LPKDJPNEIBH<int> BOGPDDLBMPK, int EJNAIEOEIGN, int KMKALIJCIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x214F2C0", Offset = "0x214DCC0", VA = "0x18214F2C0")]
	public static EJOLGGLEIDA OOAFHJGKFEK()
	{
		return default(EJOLGGLEIDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ABGKOLCDNGI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2149850", Offset = "0x2148250", VA = "0x182149850")]
	public static void MOGENANDEFO(this EJOLGGLEIDA NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CBKOGCCKKCM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum CACOENOBANE
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class HFHNLELFDHN : LINLDCGNDMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct NFLIOALKGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly OPGJAFEOJCM<JJGDACPDNPL> IACKFCDJKPD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public NFLIOALKGOE(OPGJAFEOJCM<JJGDACPDNPL> BNKDNMBMLNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class GPIFLDGFKOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class LINLDCGNDMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct AMJNIGNNFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly CACOENOBANE KEFMMNPDOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly OPGJAFEOJCM<LINLDCGNDMA> ILFDPFNGLNA;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		private AMJNIGNNFOK(CACOENOBANE KCPEHAEAELG, OPGJAFEOJCM<LINLDCGNDMA> DBPPEGHBDHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2149990", Offset = "0x2148390", VA = "0x182149990")]
		public static AMJNIGNNFOK OOAFHJGKFEK(CACOENOBANE KCPEHAEAELG, OPGJAFEOJCM<LINLDCGNDMA> DBPPEGHBDHI)
		{
			return default(AMJNIGNNFOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FBBHNBCCJOA : LINLDCGNDMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct OBDIAKBDHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly OPGJAFEOJCM<JJGDACPDNPL> IACKFCDJKPD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public OBDIAKBDHLL(OPGJAFEOJCM<JJGDACPDNPL> BNKDNMBMLNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class JJGDACPDNPL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LNBMIDCHALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LPKDJPNEIBH<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> GNBOLAJKLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LPKDJPNEIBH<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> PJJGOMIOLHI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2150B80", Offset = "0x214F580", VA = "0x182150B80")]
		private LNBMIDCHALO([In] LPKDJPNEIBH<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> PKMHPILPCEB, [In] LPKDJPNEIBH<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> CDOCMNIHIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2150B00", Offset = "0x214F500", VA = "0x182150B00")]
		public static LNBMIDCHALO OOAFHJGKFEK()
		{
			return default(LNBMIDCHALO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal GOBIBBLPCBH<GPIFLDGFKOO, AMJNIGNNFOK> IJMELBOFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal GOBIBBLPCBH<FBBHNBCCJOA, OBDIAKBDHLL> BBBNEJIPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GOBIBBLPCBH<HFHNLELFDHN, NFLIOALKGOE> EOBBNLPLGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LPKDJPNEIBH<(OPGJAFEOJCM<GPIFLDGFKOO> CallId, OPGJAFEOJCM<JJGDACPDNPL> IOId)> IBMFHLFCLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal GOBIBBLPCBH<JJGDACPDNPL, LNBMIDCHALO> FLLLAHEJPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal BBDIKCMGBLK<JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> CDEOJGLBMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal BBDIKCMGBLK<JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> LFHFCELBCHE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x214F130", Offset = "0x214DB30", VA = "0x18214F130")]
	private CBKOGCCKKCM([In] GOBIBBLPCBH<GPIFLDGFKOO, AMJNIGNNFOK> NHKOCMGDPBO, [In] GOBIBBLPCBH<FBBHNBCCJOA, OBDIAKBDHLL> KFPKDPBPAPM, [In] GOBIBBLPCBH<HFHNLELFDHN, NFLIOALKGOE> FPCJNAGJINL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<GPIFLDGFKOO> CallId, OPGJAFEOJCM<JJGDACPDNPL> IOId)> NMPFEJBJDPE, [In] GOBIBBLPCBH<JJGDACPDNPL, LNBMIDCHALO> HEHALJEEEOP, [In] BBDIKCMGBLK<JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> CNCOFLJGNBO, [In] BBDIKCMGBLK<JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> NPKLDFBPACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x214EF90", Offset = "0x214D990", VA = "0x18214EF90")]
	public static CBKOGCCKKCM OOAFHJGKFEK()
	{
		return default(CBKOGCCKKCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FMMHGEIIFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x214F7A0", Offset = "0x214E1A0", VA = "0x18214F7A0")]
	private static void MOGENANDEFO(this CBKOGCCKKCM.LNBMIDCHALO NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x214F590", Offset = "0x214DF90", VA = "0x18214F590")]
	public static void MOGENANDEFO(this CBKOGCCKKCM NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PMJBHNEKJEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public LPKDJPNEIBH<byte> MPFPONMCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CBKOGCCKKCM KLFDMAFAGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal LIJLODGFANB LLEHHGCNNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> ODEHABNBEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal MCAMHENOGDC KPMPECPJIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal NNPKAHMPKDO IPFADBMLLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal BBDIKCMGBLK<KJIBBALNENC, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>?> CKBCNOPGEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal LPKDJPNEIBH<OPGJAFEOJCM<KJIBBALNENC>> IAPICAEOFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> BJPFDKAAACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> EAJHFLNIFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> OKKDMHIEKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal JKJAKDFGNFE HFPJBCEJNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal MCMMHJAOJPP LCGMJMEFDLO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2154640", Offset = "0x2153040", VA = "0x182154640")]
	private PMJBHNEKJEF([In] LPKDJPNEIBH<byte> PACGCHIFHGK, [In] CBKOGCCKKCM PBHLNAGKOAJ, [In] LIJLODGFANB JJDFLFGCLPE, [In] MCAMHENOGDC BDKMJMGOGPG, [In] NNPKAHMPKDO HMMAOLBIFHG, [In] BBDIKCMGBLK<KJIBBALNENC, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>?> KHJMHKHDMMF, [In] LPKDJPNEIBH<OPGJAFEOJCM<KJIBBALNENC>> JELCLIDCKNK, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> CLAIEICGKFH, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> BLGDJJBJLNF, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> JGMAPBMPELC, [In] JKJAKDFGNFE PKGAGNBAHKC, [In] MCMMHJAOJPP NCJNFMOOHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2153C90", Offset = "0x2152690", VA = "0x182153C90")]
	public static PMJBHNEKJEF OOAFHJGKFEK()
	{
		return default(PMJBHNEKJEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PJELMALFENP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct GMKHDKJNAGM : AKEDODBAPKM<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>, BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x214FB00", Offset = "0x214E500", VA = "0x18214FB00")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x214FBB0", Offset = "0x214E5B0", VA = "0x18214FBB0", Slot = "4")]
		public OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> JANIJNHBHFM(int ENMILGHAHOM)
		{
			return default(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		public bool NFOCKPCGBLJ(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "5")]
		private bool DNDOCJMJEPH(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x214FBE0", Offset = "0x214E5E0", VA = "0x18214FBE0", Slot = "6")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> JBHGBCFNEHF(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct IBHMNHBNCEG : OGDOIOBBILF<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>, BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2150180", Offset = "0x214EB80", VA = "0x182150180")]
		public LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>> IICHEIIBHBH(int LCPIEBCBBPL, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2150000", Offset = "0x214EA00", VA = "0x182150000")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x21500C0", Offset = "0x214EAC0", VA = "0x1821500C0", Slot = "6")]
		public void GKPGKAHOCKE(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2150180", Offset = "0x214EB80", VA = "0x182150180", Slot = "4")]
		private LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>> NGGBFKGFCJO(int LCPIEBCBBPL, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x21500B0", Offset = "0x214EAB0", VA = "0x1821500B0", Slot = "5")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> GAKEOPMHHNE(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct AHBDENPALMD : AKEDODBAPKM<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>, BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x21498A0", Offset = "0x21482A0", VA = "0x1821498A0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2149950", Offset = "0x2148350", VA = "0x182149950", Slot = "4")]
		public OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> JANIJNHBHFM(int ENMILGHAHOM)
		{
			return default(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		public bool NFOCKPCGBLJ(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "5")]
		private bool OAGGDILNNON(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2149980", Offset = "0x2148380", VA = "0x182149980", Slot = "6")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> LCIIIHJPNNO(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct JKGDPPNDABB : OGDOIOBBILF<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>, BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x21504C0", Offset = "0x214EEC0", VA = "0x1821504C0")]
		public LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>> IICHEIIBHBH(int LCPIEBCBBPL, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2150350", Offset = "0x214ED50", VA = "0x182150350")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2150400", Offset = "0x214EE00", VA = "0x182150400", Slot = "6")]
		public void GKPGKAHOCKE(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21504C0", Offset = "0x214EEC0", VA = "0x1821504C0", Slot = "4")]
		private LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>> OGKCDDAHCFD(int LCPIEBCBBPL, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2150530", Offset = "0x214EF30", VA = "0x182150530", Slot = "5")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> OHLHBPNJFAC(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> ENMILGHAHOM, [In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct HDCANDLCDAF : AKEDODBAPKM<OPGJAFEOJCM<IBKOEPKMBDC>, BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x214FC00", Offset = "0x214E600", VA = "0x18214FC00")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x214FD50", Offset = "0x214E750", VA = "0x18214FD50", Slot = "4")]
		public OPGJAFEOJCM<IBKOEPKMBDC> JANIJNHBHFM(int ENMILGHAHOM)
		{
			return default(OPGJAFEOJCM<IBKOEPKMBDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x214FCD0", Offset = "0x214E6D0", VA = "0x18214FCD0")]
		public bool NFOCKPCGBLJ(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x214FCD0", Offset = "0x214E6D0", VA = "0x18214FCD0", Slot = "5")]
		private bool GKLIBOMFAAL(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x214FD80", Offset = "0x214E780", VA = "0x18214FD80", Slot = "6")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> LEJDOKIHDLH(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct NHMEDKLJHEM : OGDOIOBBILF<OPGJAFEOJCM<IBKOEPKMBDC>, BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x21511C0", Offset = "0x214FBC0", VA = "0x1821511C0")]
		public LPKDJPNEIBH<OPGJAFEOJCM<IBKOEPKMBDC>> IICHEIIBHBH(int LCPIEBCBBPL, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<OPGJAFEOJCM<IBKOEPKMBDC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x21510F0", Offset = "0x214FAF0", VA = "0x1821510F0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2151230", Offset = "0x214FC30", VA = "0x182151230", Slot = "6")]
		public void GKPGKAHOCKE(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x21511C0", Offset = "0x214FBC0", VA = "0x1821511C0", Slot = "4")]
		private LPKDJPNEIBH<OPGJAFEOJCM<IBKOEPKMBDC>> GJPIDKOICLG(int LCPIEBCBBPL, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<OPGJAFEOJCM<IBKOEPKMBDC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x21510E0", Offset = "0x214FAE0", VA = "0x1821510E0", Slot = "5")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FENNCFOEJFI(OPGJAFEOJCM<IBKOEPKMBDC> ENMILGHAHOM, [In] BBDIKCMGBLK<IBKOEPKMBDC, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>?> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct FNJAKGKJCAL : AKEDODBAPKM<int, LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x214F7F0", Offset = "0x214E1F0", VA = "0x18214F7F0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9A5170", Offset = "0x9A3B70", VA = "0x1809A5170", Slot = "4")]
		public int JANIJNHBHFM(int ENMILGHAHOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		public bool NFOCKPCGBLJ(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "5")]
		private bool LDMCNLGEJJH(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x214F890", Offset = "0x214E290", VA = "0x18214F890", Slot = "6")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> GICFJJOHIHN(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct BBJAIFHFEBN : OGDOIOBBILF<int, LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2149B50", Offset = "0x2148550", VA = "0x182149B50")]
		public LPKDJPNEIBH<int> IICHEIIBHBH(int LCPIEBCBBPL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x21499B0", Offset = "0x21483B0", VA = "0x1821499B0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2149A50", Offset = "0x2148450", VA = "0x182149A50", Slot = "6")]
		public void GKPGKAHOCKE(int ENMILGHAHOM, LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2149B50", Offset = "0x2148550", VA = "0x182149B50", Slot = "4")]
		private LPKDJPNEIBH<int> LAKJBCIOEKE(int LCPIEBCBBPL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x21499A0", Offset = "0x21483A0", VA = "0x1821499A0", Slot = "5")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> BNMHCEPIFMD(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> VariableId, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<EOKPLNLLEKB>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct IMHELLJEAMP : AKEDODBAPKM<int, LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21501F0", Offset = "0x214EBF0", VA = "0x1821501F0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9A5170", Offset = "0x9A3B70", VA = "0x1809A5170", Slot = "4")]
		public int JANIJNHBHFM(int ENMILGHAHOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		public bool NFOCKPCGBLJ(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "5")]
		private bool HJPHMPHFMBK(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2150290", Offset = "0x214EC90", VA = "0x182150290", Slot = "6")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> JFEAENMFEIK(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct HJGJHHPLOOP : OGDOIOBBILF<int, LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x214FF30", Offset = "0x214E930", VA = "0x18214FF30")]
		public LPKDJPNEIBH<int> IICHEIIBHBH(int LCPIEBCBBPL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x214FD90", Offset = "0x214E790", VA = "0x18214FD90")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x214FE40", Offset = "0x214E840", VA = "0x18214FE40", Slot = "6")]
		public void GKPGKAHOCKE(int ENMILGHAHOM, LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x214FF30", Offset = "0x214E930", VA = "0x18214FF30", Slot = "4")]
		private LPKDJPNEIBH<int> JGENAFFGHKH(int LCPIEBCBBPL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x214FE30", Offset = "0x214E830", VA = "0x18214FE30", Slot = "5")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FJBJFBMGAMP(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct IOHAGGDHLOF : AKEDODBAPKM<int, LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x21502A0", Offset = "0x214ECA0", VA = "0x1821502A0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9A5170", Offset = "0x9A3B70", VA = "0x1809A5170", Slot = "4")]
		public int JANIJNHBHFM(int ENMILGHAHOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		public bool NFOCKPCGBLJ(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "5")]
		private bool HJPHMPHFMBK(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2150340", Offset = "0x214ED40", VA = "0x182150340", Slot = "6")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> JFEAENMFEIK(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct GFJAKJKKHGA : OGDOIOBBILF<int, LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x214FA90", Offset = "0x214E490", VA = "0x18214FA90")]
		public LPKDJPNEIBH<int> IICHEIIBHBH(int LCPIEBCBBPL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x214F8E0", Offset = "0x214E2E0", VA = "0x18214F8E0")]
		public OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x214F990", Offset = "0x214E390", VA = "0x18214F990", Slot = "6")]
		public void GKPGKAHOCKE(int ENMILGHAHOM, LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x214FA90", Offset = "0x214E490", VA = "0x18214FA90", Slot = "4")]
		private LPKDJPNEIBH<int> JGENAFFGHKH(int LCPIEBCBBPL, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(LPKDJPNEIBH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x214F980", Offset = "0x214E380", VA = "0x18214F980", Slot = "5")]
		private OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FJBJFBMGAMP(int ENMILGHAHOM, [In] LPKDJPNEIBH<(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> Target, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ByteCodeWriteLocation)> KIAGDMGGGNM)
		{
			return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct GNNMMEADDOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> DKJDMGKCMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool ACPGCGFDOGA;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x163AE80", Offset = "0x1639880", VA = "0x18163AE80")]
		public GNNMMEADDOP(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI, bool KEEKCEIEEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x214FBF0", Offset = "0x214E5F0", VA = "0x18214FBF0")]
		public void GJGCCCKLLFN([Out] OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI, [Out] bool KEEKCEIEEPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct OLGBBEMDMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly OPGJAFEOJCM<IBKOEPKMBDC> KKJLNCDJNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> DKJDMGKCMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool ACPGCGFDOGA;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x21514D0", Offset = "0x214FED0", VA = "0x1821514D0")]
		public OLGBBEMDMMM(OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI, bool KEEKCEIEEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x21514C0", Offset = "0x214FEC0", VA = "0x1821514C0")]
		public void GJGCCCKLLFN([Out] OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI, [Out] bool KEEKCEIEEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x21514A0", Offset = "0x214FEA0", VA = "0x1821514A0")]
		public void GJGCCCKLLFN([Out] OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI, [Out] OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI, [Out] bool KEEKCEIEEPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct DLDMCODPGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly OPGJAFEOJCM<IBKOEPKMBDC> KKJLNCDJNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> DKJDMGKCMBG;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		public DLDMCODPGNF(OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x214F2A0", Offset = "0x214DCA0", VA = "0x18214F2A0")]
		public void GJGCCCKLLFN([Out] OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI, [Out] OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x21530F0", Offset = "0x2151AF0", VA = "0x1821530F0")]
	public static void MOGENANDEFO(this PMJBHNEKJEF NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2151B70", Offset = "0x2150570", VA = "0x182151B70")]
	public static void COBEHPDDPFF(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> LHAMEBJJGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2152BB0", Offset = "0x21515B0", VA = "0x182152BB0")]
	public static void KDGOMGAHFMG(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> LHAMEBJJGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2151DF0", Offset = "0x21507F0", VA = "0x182151DF0")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>? EJPPFFOCACA([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2152B50", Offset = "0x2151550", VA = "0x182152B50")]
	public static OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> JPLBPFNHHGI([In] this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2151880", Offset = "0x2150280", VA = "0x182151880")]
	private static void ADMJEPGIDIP(this PMJBHNEKJEF NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x21522A0", Offset = "0x2150CA0", VA = "0x1821522A0")]
	private static OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>? HIJEHLFOEJA([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2152ED0", Offset = "0x21518D0", VA = "0x182152ED0")]
	public static void LKCLNPMBLEL(this PMJBHNEKJEF NKCEKILMAAM, [In] LPKDJPNEIBH<BBEHPNAKAOM> LDLKABKCANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2151A70", Offset = "0x2150470", VA = "0x182151A70")]
	public static MCAMHENOGDC.KGNIBAJMEBP BJAJLHMNHDD([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
	{
		return default(MCAMHENOGDC.KGNIBAJMEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2152A60", Offset = "0x2151460", VA = "0x182152A60")]
	public static LHPDPPIAGFF<byte> JPIEFNMDPBG([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
	{
		return default(LHPDPPIAGFF<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2153A10", Offset = "0x2152410", VA = "0x182153A10")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> OPKHANHFPMO([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2153440", Offset = "0x2151E40", VA = "0x182153440")]
	public static CPPMLHJKLEH NBIECCGPIEA([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2F14150", Offset = "0x2F12B50", VA = "0x182F14150")]
	private static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> EOPMMAPFFEG<TMJoin>(this PMJBHNEKJEF NKCEKILMAAM, MCAMHENOGDC.KGNIBAJMEBP KCPEHAEAELG, OPGJAFEOJCM<TMJoin> DBPPEGHBDHI) where TMJoin : MCAMHENOGDC.DMELOCLMNMO
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x21519F0", Offset = "0x21503F0", VA = "0x1821519F0")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> AEHANFFDIPB(this PMJBHNEKJEF NKCEKILMAAM, bool FLPKEAALNHG)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2153C00", Offset = "0x2152600", VA = "0x182153C00")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> PHDBLIGKDMH(this PMJBHNEKJEF NKCEKILMAAM, LHPDPPIAGFF<byte> MGCOGNAKONH)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2153990", Offset = "0x2152390", VA = "0x182153990")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> OPGEAKGHPFH(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> KNOFJBKPOGF)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2153910", Offset = "0x2152310", VA = "0x182153910")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> OCJGGEMCKPL(this PMJBHNEKJEF NKCEKILMAAM, int BPKFGOPAJGB)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2151AF0", Offset = "0x21504F0", VA = "0x182151AF0")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> CJAJJHCPMMF(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2F13B60", Offset = "0x2F12560", VA = "0x182F13B60")]
	private static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> AFNIPBFONCG<TMJoin>(this PMJBHNEKJEF NKCEKILMAAM, NNPKAHMPKDO.KPBLFKIJKOL KCPEHAEAELG, OPGJAFEOJCM<TMJoin> DBPPEGHBDHI) where TMJoin : NNPKAHMPKDO.LLFIPOGAEIA
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2151EB0", Offset = "0x21508B0", VA = "0x182151EB0")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> FBEGJFJKPBK(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2153040", Offset = "0x2151A40", VA = "0x182153040")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> MIAAJHBKBFH(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2152040", Offset = "0x2150A40", VA = "0x182152040")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> GKGGKLKAGME(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> BLEAPCCMDNK)
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2153BB0", Offset = "0x21525B0", VA = "0x182153BB0")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> PELNLIAMNGB(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2152DB0", Offset = "0x21517B0", VA = "0x182152DB0")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> KKPFDJCKGGC(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21533C0", Offset = "0x2151DC0", VA = "0x1821533C0")]
	public static CBKOGCCKKCM.CACOENOBANE MOOCLGCLOMF([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> EBFIGAGDPKC)
	{
		return default(CBKOGCCKKCM.CACOENOBANE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2151DB0", Offset = "0x21507B0", VA = "0x182151DB0")]
	public static LPAHDOHNHGK<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>, KMBPDBJNIDH<CBKOGCCKKCM.JJGDACPDNPL>> EBHLHNFGBPP([In] this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(LPAHDOHNHGK<OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>, KMBPDBJNIDH<CBKOGCCKKCM.JJGDACPDNPL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2152650", Offset = "0x2151050", VA = "0x182152650")]
	public static OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> IOFCHPDPENG([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> EBFIGAGDPKC)
	{
		return default(OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2151FC0", Offset = "0x21509C0", VA = "0x182151FC0")]
	public static CBKOGCCKKCM.LNBMIDCHALO FGLFJEIAFIC([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> BNKDNMBMLNF)
	{
		return default(CBKOGCCKKCM.LNBMIDCHALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21529E0", Offset = "0x21513E0", VA = "0x1821529E0")]
	public static CBKOGCCKKCM.LNBMIDCHALO JFMFPOLBBFB(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> BNKDNMBMLNF)
	{
		return default(CBKOGCCKKCM.LNBMIDCHALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F152C0", Offset = "0x2F13CC0", VA = "0x182F152C0")]
	private static OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> NKJJJKOFHLN<TMJoin>(this PMJBHNEKJEF NKCEKILMAAM, CBKOGCCKKCM.CACOENOBANE KCPEHAEAELG, OPGJAFEOJCM<TMJoin> DBPPEGHBDHI) where TMJoin : CBKOGCCKKCM.LINLDCGNDMA
	{
		return default(OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2152830", Offset = "0x2151230", VA = "0x182152830")]
	public static (OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>) IOPMIGFIPCC(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default((OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2152360", Offset = "0x2150D60", VA = "0x182152360")]
	public static (OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>) HOIBEPAMMCF(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default((OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2151CF0", Offset = "0x21506F0", VA = "0x182151CF0")]
	public static OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> CPPGBOLKOGD(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2151610", Offset = "0x2150010", VA = "0x182151610")]
	public static void ABLEFPHLHDM(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL> BNKDNMBMLNF, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> HJHCPDGPHPF, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>> DFFIFBEDLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2F144A0", Offset = "0x2F12EA0", VA = "0x182F144A0")]
	public static GNNMMEADDOP LLIHPPPAHJB<TDeps, TStateSys>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI) where TDeps : PPALKLKBFDL<TStateSys>
	{
		return default(GNNMMEADDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2F14200", Offset = "0x2F12C00", VA = "0x182F14200")]
	public static OLGBBEMDMMM EPADPFGOONC<TDeps, TStateSys>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<BOAKMKENONJ> HEPLADJNIKE, int FHNDLLDGKOE) where TDeps : PPALKLKBFDL<TStateSys>
	{
		return default(OLGBBEMDMMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2F13D10", Offset = "0x2F12710", VA = "0x182F13D10")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>? BDCMIDKBJGJ<TDeps, TStateSys>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<BOAKMKENONJ> HEPLADJNIKE, [In] ReadOnlySpan<int> PBMLKLDIKEN, [In] Span<DLDMCODPGNF> PEBEFMGJMIG) where TDeps : PPALKLKBFDL<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F15430", Offset = "0x2F13E30", VA = "0x182F15430")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> PCAIHAFMION<TDeps, TStateSys>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK) where TDeps : PPALKLKBFDL<TStateSys>
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2153820", Offset = "0x2152220", VA = "0x182153820")]
	public static LIJLODGFANB.IIIFODFEIKK OBEDCKOLIJG([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DNICIAANFHD)
	{
		return default(LIJLODGFANB.IIIFODFEIKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x21520C0", Offset = "0x2150AC0", VA = "0x1821520C0")]
	public static LIJLODGFANB.GCEBNLMNKOA GLEGBOJJPKJ([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DNICIAANFHD)
	{
		return default(LIJLODGFANB.GCEBNLMNKOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x21521B0", Offset = "0x2150BB0", VA = "0x1821521B0")]
	public static LIJLODGFANB.DNKJOANDMHO HBLOHBJBJMF([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DNICIAANFHD)
	{
		return default(LIJLODGFANB.DNKJOANDMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2153690", Offset = "0x2152090", VA = "0x182153690")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NOOFBGMKGAI(this PMJBHNEKJEF NKCEKILMAAM, int? NFKIHLMJJPM, string DDDMPLCOGIM)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2151C00", Offset = "0x2150600", VA = "0x182151C00")]
	public static LIJLODGFANB.DCPEOLMGMFL CPMOKFIFKMD([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DNICIAANFHD)
	{
		return default(LIJLODGFANB.DCPEOLMGMFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2151D40", Offset = "0x2150740", VA = "0x182151D40")]
	public static LIJLODGFANB.NMNJMFBFBEO DPPNOKPCMNM([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DNICIAANFHD)
	{
		return default(LIJLODGFANB.NMNJMFBFBEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2153620", Offset = "0x2152020", VA = "0x182153620")]
	public static int? NMFGBJNPPEF([In] this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DNICIAANFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F13C10", Offset = "0x2F12610", VA = "0x182F13C10")]
	private static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> AJFBJEINICP<TMJoin>(this PMJBHNEKJEF NKCEKILMAAM, int? NFKIHLMJJPM, LIJLODGFANB.NMNJMFBFBEO KCPEHAEAELG, OPGJAFEOJCM<TMJoin> DBPPEGHBDHI) where TMJoin : LIJLODGFANB.HLILHODHJKC
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2153B00", Offset = "0x2152500", VA = "0x182153B00")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PBGHGAALDJO(this PMJBHNEKJEF NKCEKILMAAM, int? NFKIHLMJJPM, OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> EBFIGAGDPKC, int ENMILGHAHOM)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2153090", Offset = "0x2151A90", VA = "0x182153090")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MMGOIDOMJAL(this PMJBHNEKJEF NKCEKILMAAM, int? NFKIHLMJJPM)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2151730", Offset = "0x2150130", VA = "0x182151730")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> ADLPFPNBFNB(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? CHIFCFNPACI, int? NFKIHLMJJPM)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21516A0", Offset = "0x21500A0", VA = "0x1821516A0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> ACEKOFDCFDH(this PMJBHNEKJEF NKCEKILMAAM, int? NFKIHLMJJPM, int ENMILGHAHOM)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2153530", Offset = "0x2151F30", VA = "0x182153530")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NECONJCKPDI(this PMJBHNEKJEF NKCEKILMAAM, int? NFKIHLMJJPM)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2152510", Offset = "0x2150F10", VA = "0x182152510")]
	public static void IHJCMCMDHHE(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP, OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> EBFIGAGDPKC, int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2152C80", Offset = "0x2151680", VA = "0x182152C80")]
	public static void KINCIICBKDK(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP, int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2152E00", Offset = "0x2151800", VA = "0x182152E00")]
	public static void LHAHKOCGKNN(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2153590", Offset = "0x2151F90", VA = "0x182153590")]
	public static void NFPOHALJACA(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> CDHECNAFHCH, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> KAHGFHAGCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2151EF0", Offset = "0x21508F0", VA = "0x182151EF0")]
	public static void FGBGFLEOJKB(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP, OPGJAFEOJCM<IGJFABAJMBK<BIHNJPFMNFD>> FPFBPKANLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F15360", Offset = "0x2F13D60", VA = "0x182F15360")]
	public static void NLFFHNBJFFG<M>(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GKGEFPKMEBP, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<M>>> FPFBPKANLHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PPALKLKBFDL<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OPGJAFEOJCM<MCIIOIKPKCA> KHJKKFFIIKJ(TStateSys HHADCNHGHEM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OPGJAFEOJCM<MCIIOIKPKCA> HJPNEHCEHOF(TStateSys HHADCNHGHEM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPGJAFEOJCM<MCIIOIKPKCA> NNJPGOIEHCN(TStateSys HHADCNHGHEM);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPGJAFEOJCM<MCIIOIKPKCA> KNBPONBCGEC(TStateSys HHADCNHGHEM);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> DMPLNBOLKKD(TStateSys HHADCNHGHEM, PMJBHNEKJEF AGLBDIECLFP, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> JEPMNCCHDGH(TStateSys HHADCNHGHEM, PMJBHNEKJEF AGLBDIECLFP, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KIKMINJDAIN(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OPGJAFEOJCM<KJIBBALNENC> JANIPBFLPHP(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI, int CMLMOJMPJCC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OCHOKEGIKDP KEHOPJDFHIA(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AIJNPLCPMIL(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int KABALHBEBMK(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LHPDPPIAGFF<byte> KHBFMFOGOED(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(LHPDPPIAGFF<byte>, OPGJAFEOJCM<MCIIOIKPKCA>) GGKLIJPKDIP(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FAMIHLLEFIO(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OPGJAFEOJCM<IBKOEPKMBDC> BCOMIHPEINA(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK, int FHNDLLDGKOE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OPGJAFEOJCM<IBKOEPKMBDC> EKIKBHDELCC(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<BOAKMKENONJ> HEPLADJNIKE, int FHNDLLDGKOE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int LGLAAOJKJDH(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? JONFIFBJAAJ(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int LNLEDFNNOBO(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? PHFIJGGIIPK(TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, int ENMILGHAHOM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BDBJAGFDAKP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AD00E0", Offset = "0x2ACEAE0", VA = "0x182AD00E0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK?> CEPBIDIOLBI<T, TOpInput, TOpOutput>(this PMJBHNEKJEF NKCEKILMAAM, T MFLKJAHENBP, T PLHCHKLJLJD, int FBKJMGDBEAB, IntPtr AOABLNBOBDJ)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AD11E0", Offset = "0x2ACFBE0", VA = "0x182AD11E0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK?> IBOJMGGDJOM<T, TOpInput, TOpOutput>(this PMJBHNEKJEF NKCEKILMAAM, T MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD, int FBKJMGDBEAB, IntPtr AOABLNBOBDJ)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AD20C0", Offset = "0x2AD0AC0", VA = "0x182AD20C0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK?> MAPAFLMPMOO<TOpInput, TOpOutput>(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD, int FBKJMGDBEAB, IntPtr AOABLNBOBDJ)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x214DCF0", Offset = "0x214C6F0", VA = "0x18214DCF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NKIDJCPEBGI(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x214CF60", Offset = "0x214B960", VA = "0x18214CF60")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> LHHDODNCFPD(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x214E5B0", Offset = "0x214CFB0", VA = "0x18214E5B0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PBEFGOCKGNL(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x214CCC0", Offset = "0x214B6C0", VA = "0x18214CCC0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KDFBJIBBJGI(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x214A100", Offset = "0x2148B00", VA = "0x18214A100")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> BHNPLOJPBJH(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x214B640", Offset = "0x214A040", VA = "0x18214B640")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GNAFKFILEMM(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x214DDF0", Offset = "0x214C7F0", VA = "0x18214DDF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NNFNOFONMGF(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x214C0E0", Offset = "0x214AAE0", VA = "0x18214C0E0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> JDLAFIKELJD(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x214A3A0", Offset = "0x2148DA0", VA = "0x18214A3A0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CKINMEBNNFK(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x214A9F0", Offset = "0x21493F0", VA = "0x18214A9F0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> EAEPNMLGANC(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, int PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x214DEF0", Offset = "0x214C8F0", VA = "0x18214DEF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NOKPEEGCNJB(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x214C320", Offset = "0x214AD20", VA = "0x18214C320")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> JFDOCFGAKLN(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x214E4B0", Offset = "0x214CEB0", VA = "0x18214E4B0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> ONAOAALBMMK(this PMJBHNEKJEF NKCEKILMAAM, float MFLKJAHENBP, float PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x214AAF0", Offset = "0x21494F0", VA = "0x18214AAF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> ECLBDJFOCGG(this PMJBHNEKJEF NKCEKILMAAM, float MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x214D1B0", Offset = "0x214BBB0", VA = "0x18214D1B0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> LNKCLIMAABI(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x214A750", Offset = "0x2149150", VA = "0x18214A750")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DFGHENICLPD(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, int PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x214EBD0", Offset = "0x214D5D0", VA = "0x18214EBD0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PJMGFFKBAIP(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x214CDC0", Offset = "0x214B7C0", VA = "0x18214CDC0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KFKKFJKCGJP(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x214A080", Offset = "0x2148A80", VA = "0x18214A080")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> BCHMOMGLMJD(this PMJBHNEKJEF NKCEKILMAAM, float MFLKJAHENBP, float PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x214ECD0", Offset = "0x214D6D0", VA = "0x18214ECD0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHPOFHLEDM(this PMJBHNEKJEF NKCEKILMAAM, float MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x214A7D0", Offset = "0x21491D0", VA = "0x18214A7D0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DHJFDGPNMPL(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x214A850", Offset = "0x2149250", VA = "0x18214A850")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DIEBOKCNBCD(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, int PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x214A4E0", Offset = "0x2148EE0", VA = "0x18214A4E0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CPOLELNKJEB(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2149BC0", Offset = "0x21485C0", VA = "0x182149BC0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> AFPMPGBBLBC(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x214AD60", Offset = "0x2149760", VA = "0x18214AD60")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> ENEECBMAALM(this PMJBHNEKJEF NKCEKILMAAM, float MFLKJAHENBP, float PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x214D680", Offset = "0x214C080", VA = "0x18214D680")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFGJBNELFOE(this PMJBHNEKJEF NKCEKILMAAM, float MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x214E6F0", Offset = "0x214D0F0", VA = "0x18214E6F0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PHMGAKDKECG(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x214BBF0", Offset = "0x214A5F0", VA = "0x18214BBF0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> ICBFHDBNGJI(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x214B780", Offset = "0x214A180", VA = "0x18214B780")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> GOBALMHNFHD(this PMJBHNEKJEF NKCEKILMAAM, int IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x214B300", Offset = "0x2149D00", VA = "0x18214B300")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> GBDHDPOJAPC(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x214D940", Offset = "0x214C340", VA = "0x18214D940")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> MPCDDNAENOF(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> GOGJKEBMECI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x214ADE0", Offset = "0x21497E0", VA = "0x18214ADE0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> FEHHNBPAHIN(this PMJBHNEKJEF NKCEKILMAAM, int IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x214C5A0", Offset = "0x214AFA0", VA = "0x18214C5A0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> JKJLDKLBOAD(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x214C640", Offset = "0x214B040", VA = "0x18214C640")]
	public static (OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>) JKPEHBHIIFC(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<FGMDLGKIGON> FBCALBMOMME, [In] ReadOnlySpan<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> PKMHPILPCEB, [In] ReadOnlySpan<int?> LOGMGGOKAIL, [In] Span<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> HNJHKHAMKCI)
	{
		return default((OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x214E770", Offset = "0x214D170", VA = "0x18214E770")]
	public static (OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>) PJCAELEBEOK(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<DANLPKAAPFE> OPBDKMAJMPE, [In] ReadOnlySpan<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> PKMHPILPCEB, [In] ReadOnlySpan<int?> LOGMGGOKAIL, [In] Span<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> HNJHKHAMKCI)
	{
		return default((OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFFE0", Offset = "0x2ACE9E0", VA = "0x182ACFFE0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<MCIIOIKPKCA>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<TMarker>>, OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>) BKABNEONAKJ<TMarker>(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCIIOIKPKCA> LLOPNAHBONJ, [In] ReadOnlySpan<byte> LNCKNHNHHDF)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<MCIIOIKPKCA>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<TMarker>>, OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x214B920", Offset = "0x214A320", VA = "0x18214B920")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> HHJKFLAFCGC(this PMJBHNEKJEF NKCEKILMAAM, int CFBNLICAJEE, [Optional] OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x214A560", Offset = "0x2148F60", VA = "0x18214A560")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DAFDDFIKOKK(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CFBNLICAJEE, [Optional] OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x214A650", Offset = "0x2149050", VA = "0x18214A650")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DCDGBKBMFGP(this PMJBHNEKJEF NKCEKILMAAM, [In] ReadOnlySpan<byte> CFBNLICAJEE, [Optional] OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x214B800", Offset = "0x214A200", VA = "0x18214B800")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> HACNCGPGLOL(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CFBNLICAJEE, int ECFPAOHDFEB, [Optional] OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x214CBC0", Offset = "0x214B5C0", VA = "0x18214CBC0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> JPIOAJPFNFJ(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x214C200", Offset = "0x214AC00", VA = "0x18214C200")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> JFBFBMIEHAH(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2149C40", Offset = "0x2148640", VA = "0x182149C40")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> BBPLGMLLICH(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x214B3A0", Offset = "0x2149DA0", VA = "0x18214B3A0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GGKPCKFEDNI(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x214ED50", Offset = "0x214D750", VA = "0x18214ED50")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PPIDBBBIDDL(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x214AC20", Offset = "0x2149620", VA = "0x18214AC20")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> EHBKOGFNPHC(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x214B4A0", Offset = "0x2149EA0", VA = "0x18214B4A0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GJHDKBIOIMG(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, int PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x214A320", Offset = "0x2148D20", VA = "0x18214A320")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CDPAAFPNCEM(this PMJBHNEKJEF NKCEKILMAAM, int MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x214EC50", Offset = "0x214D650", VA = "0x18214EC50")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PKCBIEMJMDE(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MFLKJAHENBP, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PLHCHKLJLJD)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x214BDA0", Offset = "0x214A7A0", VA = "0x18214BDA0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> IEOHGPFCIFL(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x214D080", Offset = "0x214BA80", VA = "0x18214D080")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> LKLJKHFECDI(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x214AF60", Offset = "0x2149960", VA = "0x18214AF60")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> FIHAHKLGIAD(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x214DBF0", Offset = "0x214C5F0", VA = "0x18214DBF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NGAAHANPIED(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x214E390", Offset = "0x214CD90", VA = "0x18214E390")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> OMJHJFINBKJ(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x214CA80", Offset = "0x214B480", VA = "0x18214CA80")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> JLKJOGINHNP(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x214EBB0", Offset = "0x214D5B0", VA = "0x18214EBB0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>> PJIHPANBPBL(this PMJBHNEKJEF NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x214BAF0", Offset = "0x214A4F0", VA = "0x18214BAF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> HMACOBDIPGP(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x214B520", Offset = "0x2149F20", VA = "0x18214B520")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GMMIJIOJHKG(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x214B0A0", Offset = "0x2149AA0", VA = "0x18214B0A0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> FJNAILGENPN(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x214DAF0", Offset = "0x214C4F0", VA = "0x18214DAF0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> NCLBIOCGOBH(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x214B1E0", Offset = "0x2149BE0", VA = "0x18214B1E0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> FNECLLNLBBH(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x214C460", Offset = "0x214AE60", VA = "0x18214C460")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> JIJNBBKMLPA(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x214BEA0", Offset = "0x214A8A0", VA = "0x18214BEA0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> IHAENKNIDPC(this PMJBHNEKJEF NKCEKILMAAM, int IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x214B9E0", Offset = "0x214A3E0", VA = "0x18214B9E0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> HJLOFKAHGGG(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x214A740", Offset = "0x2149140", VA = "0x18214A740")]
	public static void DCIDEPOCHKK(this PMJBHNEKJEF NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x214D840", Offset = "0x214C240", VA = "0x18214D840")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MKMABNPJLCI(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x214A8D0", Offset = "0x21492D0", VA = "0x18214A8D0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> DMGEJLNKLCG(this PMJBHNEKJEF NKCEKILMAAM, float MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x214D700", Offset = "0x214C100", VA = "0x18214D700")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MGBEBNGIKIF(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x214A220", Offset = "0x2148C20", VA = "0x18214A220")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> BIEIKEFMBFM(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x214CE40", Offset = "0x214B840", VA = "0x18214CE40")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> LABNNCHIPDF(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x214BFA0", Offset = "0x214A9A0", VA = "0x18214BFA0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> IPLPBLDCODC(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x214E010", Offset = "0x214CA10", VA = "0x18214E010")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> OGNFOFLNOAG(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> PAKINNCFAJL, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> AIOFCCIBNLB)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x214AE60", Offset = "0x2149860", VA = "0x18214AE60")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> FEJKPMALPJB(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x214D560", Offset = "0x214BF60", VA = "0x18214D560")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MEFEACKEPKE(this PMJBHNEKJEF NKCEKILMAAM, int MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x214D2F0", Offset = "0x214BCF0", VA = "0x18214D2F0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MDHLLALIEEG(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> MNLAHNFDLLH, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> KLEJJNEPDEF)
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1B20", Offset = "0x2AD0520", VA = "0x182AD1B20")]
	public static void LIAKIJDCGBO<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<FGMDLGKIGON> FBCALBMOMME, [In] ReadOnlySpan<OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>> HNFHPDBMAOJ, [In] ReadOnlySpan<int?> LOGMGGOKAIL, [In] Span<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> HNJHKHAMKCI, [In] Span<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> KJGPKHHNBMG, [In] ReadOnlySpan<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>?> POGGPKHMJNM) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1580", Offset = "0x2ACFF80", VA = "0x182AD1580")]
	public static void IJDMKMKFDOH<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<DANLPKAAPFE> EDFBCBDPOLM, [In] ReadOnlySpan<OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>> EGHCIDCKIPD, [In] ReadOnlySpan<int?> LOGMGGOKAIL, [In] Span<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> HNJHKHAMKCI, [In] Span<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>> KJGPKHHNBMG, [In] ReadOnlySpan<OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>?> POGGPKHMJNM) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2B30", Offset = "0x2AD1530", VA = "0x182AD2B30")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> PHHIKJOAKBB<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CHIFCFNPACI, [Optional] OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2AD26D0", Offset = "0x2AD10D0", VA = "0x182AD26D0")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> OOIFNBELNFE<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> BLEAPCCMDNK, [Optional] OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2D10", Offset = "0x2AD1710", VA = "0x182AD2D10")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> PNAGBCEBOFO<TDeps, TStateSys>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM) where TDeps : notnull, PPALKLKBFDL<TStateSys> where TStateSys : notnull
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2230", Offset = "0x2AD0C30", VA = "0x182AD2230")]
	public static OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI> MJJMDOCOFBA<TDeps, TStateSys>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM) where TDeps : notnull, PPALKLKBFDL<TStateSys> where TStateSys : notnull
	{
		return default(OPGJAFEOJCM<NNPKAHMPKDO.CKGIEAPGHEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x214D430", Offset = "0x214BE30", VA = "0x18214D430")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> MDLBMAPGMFD(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> MHOHJIPBCPK, IntPtr KJFFINBCANE, IntPtr NLFBODOMHLK)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2149D80", Offset = "0x2148780", VA = "0x182149D80")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> BCCCKOGJNHN(this PMJBHNEKJEF NKCEKILMAAM, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KGKPAIBGDLB, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KKDJCKJAEMB, IntPtr DJNJGDHNELF, IntPtr AIKFDEEDPDK, IntPtr OCLMELCDJDK, bool KILBBELCNOK)
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD03E0", Offset = "0x2ACEDE0", VA = "0x182AD03E0")]
	public static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> EFIGMACJDJH<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<FGMDLGKIGON> IIICIGJMGAJ, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KGKPAIBGDLB, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KKDJCKJAEMB, int? OHIAAIDFBGG, [Optional] IntPtr ADPAJJANFPA) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD05F0", Offset = "0x2ACEFF0", VA = "0x182AD05F0")]
	private static OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> EFIGMACJDJH<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<FGMDLGKIGON> IIICIGJMGAJ, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KGKPAIBGDLB, OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC> KKDJCKJAEMB, int? OHIAAIDFBGG) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
		return default(OPGJAFEOJCM<MCAMHENOGDC.LNCHPGFDOOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2AD0E30", Offset = "0x2ACF830", VA = "0x182AD0E30")]
	public static OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> GPOFCMCPMNP<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK> CFBNLICAJEE, OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>? HPOPBHJPBJH) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
		return default(OPGJAFEOJCM<LIJLODGFANB.IGJJFHGIJGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2440", Offset = "0x2AD0E40", VA = "0x182AD2440")]
	public static void OLGHJJHKOHJ<TDeps, TState>(this PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TState PFFGBBPKGJN, int NGEAKAPFOEB) where TDeps : notnull, PPALKLKBFDL<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct DMCFEJNECPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> IOMGFOFCGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> MMECMKILJGP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
	public DMCFEJNECPD(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> BOIAOAPIKHP, OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> AJBCBEKAJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x214F2B0", Offset = "0x214DCB0", VA = "0x18214F2B0")]
	public static DMCFEJNECPD OOAFHJGKFEK(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> BOIAOAPIKHP)
	{
		return default(DMCFEJNECPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LIJLODGFANB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class IGHEKNDIEEG : HLILHODHJKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct IIIFODFEIKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> CMAJIPMFOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int BDIPFIAMOOH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		public IIIFODFEIKK(OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> EBFIGAGDPKC, int ENMILGHAHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class ACJPOAKOCAP : HLILHODHJKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GCEBNLMNKOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BDIPFIAMOOH;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public GCEBNLMNKOA(int ENMILGHAHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FIAJMANFNCP : HLILHODHJKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct DNKJOANDMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> CMAJIPMFOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int BDIPFIAMOOH;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		public DNKJOANDMHO(OPGJAFEOJCM<CBKOGCCKKCM.GPIFLDGFKOO> EBFIGAGDPKC, int ENMILGHAHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum NMNJMFBFBEO
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
	public sealed class IGJJFHGIJGK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class HLILHODHJKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FPFHKNLJBAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? DDNHBLNAPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DMCFEJNECPD BJAKMGCHAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NMNJMFBFBEO KEFMMNPDOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OPGJAFEOJCM<HLILHODHJKC> ILFDPFNGLNA;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x214F8A0", Offset = "0x214E2A0", VA = "0x18214F8A0")]
		public FPFHKNLJBAF(int? NFKIHLMJJPM, [In] DMCFEJNECPD FFKKIANGAKG, NMNJMFBFBEO KCPEHAEAELG, OPGJAFEOJCM<HLILHODHJKC> DBPPEGHBDHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class MGIALIMGFMH : HLILHODHJKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DCPEOLMGMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int BDIPFIAMOOH;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		public DCPEOLMGMFL(int ENMILGHAHOM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal NGFEMLGIEMB<IGJJFHGIJGK, FPFHKNLJBAF> IJMELBOFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal NGFEMLGIEMB<IGHEKNDIEEG, IIIFODFEIKK> LGIACKMBIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal NGFEMLGIEMB<FIAJMANFNCP, DNKJOANDMHO> LOOIDFKNPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal NGFEMLGIEMB<MGIALIMGFMH, DCPEOLMGMFL> KCCALPFAMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal NGFEMLGIEMB<ACJPOAKOCAP, GCEBNLMNKOA> OLMEGMEIHEP;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x21509D0", Offset = "0x214F3D0", VA = "0x1821509D0")]
	private LIJLODGFANB([In] NGFEMLGIEMB<IGJJFHGIJGK, FPFHKNLJBAF> NHKOCMGDPBO, [In] NGFEMLGIEMB<IGHEKNDIEEG, IIIFODFEIKK> AKGCBNFLMHD, [In] NGFEMLGIEMB<FIAJMANFNCP, DNKJOANDMHO> KHCCDMAALPK, [In] NGFEMLGIEMB<MGIALIMGFMH, DCPEOLMGMFL> DECBMHNKGFI, [In] NGFEMLGIEMB<ACJPOAKOCAP, GCEBNLMNKOA> INPIHONBFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x21507E0", Offset = "0x214F1E0", VA = "0x1821507E0")]
	public static LIJLODGFANB OOAFHJGKFEK()
	{
		return default(LIJLODGFANB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LOAJKBMJBHN
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2150BC0", Offset = "0x214F5C0", VA = "0x182150BC0")]
	public static void MOGENANDEFO(this LIJLODGFANB NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MKEOJJHFEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2150F80", Offset = "0x214F980", VA = "0x182150F80")]
	public static void KELODGGKPBN(PMJBHNEKJEF NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JKJAKDFGNFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, EJOLGGLEIDA> BHPBFCNNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int NDJONAIEDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int GNINDGIMHPM;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x21507A0", Offset = "0x214F1A0", VA = "0x1821507A0")]
	private JKJAKDFGNFE([In] BBDIKCMGBLK<CBKOGCCKKCM.JJGDACPDNPL, EJOLGGLEIDA> JHEIGFEIHBP, int GHIMJAOAJAE, int AKAGILFGDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2150730", Offset = "0x214F130", VA = "0x182150730")]
	public static JKJAKDFGNFE OOAFHJGKFEK()
	{
		return default(JKJAKDFGNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2150540", Offset = "0x214EF40", VA = "0x182150540")]
	public void MOGENANDEFO([In] PMJBHNEKJEF KKDHCJGLKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2DC0590", Offset = "0x2DBEF90", VA = "0x182DC0590")]
	public static void KELODGGKPBN<TDeps, TStateSys>(PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM, OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH) where TDeps : notnull, PPALKLKBFDL<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EMNBJADECCJ
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x214F3C0", Offset = "0x214DDC0", VA = "0x18214F3C0")]
	public static void KELODGGKPBN(PMJBHNEKJEF NKCEKILMAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MCMMHJAOJPP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface AKJBHPALCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CAAODCKIIGI(LPKDJPNEIBH<byte> PACGCHIFHGK, int CMCPJDJEMIO);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PGOKACJMEGO : AKJBHPALCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2151590", Offset = "0x214FF90", VA = "0x182151590", Slot = "4")]
		public void CAAODCKIIGI(LPKDJPNEIBH<byte> PACGCHIFHGK, int CMCPJDJEMIO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct CDLELGJOBDD : AKJBHPALCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x214F1F0", Offset = "0x214DBF0", VA = "0x18214F1F0", Slot = "4")]
		public void CAAODCKIIGI(LPKDJPNEIBH<byte> PACGCHIFHGK, int CMCPJDJEMIO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct OKONCDCIFGC : AKJBHPALCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2151420", Offset = "0x214FE20", VA = "0x182151420", Slot = "4")]
		public void CAAODCKIIGI(LPKDJPNEIBH<byte> PACGCHIFHGK, int CMCPJDJEMIO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct OMPEFNLCNDL : AKJBHPALCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x21514E0", Offset = "0x214FEE0", VA = "0x1821514E0", Slot = "4")]
		public void CAAODCKIIGI(LPKDJPNEIBH<byte> PACGCHIFHGK, int CMCPJDJEMIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class JPOMPBDOJBK<TCallProcessorDeps> where TCallProcessorDeps : struct, AKJBHPALCME
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps GBEKAPOEJCH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A270", Offset = "0x2C08C70", VA = "0x182C0A270")]
		public static int KELODGGKPBN<TDeps, TStateSys>(TDeps HBFCALFCDLO, TStateSys PFFGBBPKGJN, PMJBHNEKJEF KKDHCJGLKPO, [In] LPKDJPNEIBH<byte> CNGFGCACKLE, int LDMLHFOGHJB) where TDeps : PPALKLKBFDL<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private LPKDJPNEIBH<BBEHPNAKAOM> BDNCMFHPOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>> FMKLKHCPKIN;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2150F40", Offset = "0x214F940", VA = "0x182150F40")]
	private MCMMHJAOJPP([In] LPKDJPNEIBH<BBEHPNAKAOM> LDLKABKCANI, Dictionary<OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<CBKOGCCKKCM.JJGDACPDNPL>> ACDGJBIGCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2150E80", Offset = "0x214F880", VA = "0x182150E80")]
	public static MCMMHJAOJPP OOAFHJGKFEK()
	{
		return default(MCMMHJAOJPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2150E40", Offset = "0x214F840", VA = "0x182150E40")]
	public void MOGENANDEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2E69900", Offset = "0x2E68300", VA = "0x182E69900")]
	public static void KELODGGKPBN<TDeps, TStateSys>(PMJBHNEKJEF NKCEKILMAAM, TDeps HBFCALFCDLO, TStateSys HHADCNHGHEM) where TDeps : PPALKLKBFDL<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JGHPIPJDNHL<TDeps, TIndex, TValues> where TDeps : struct, OGDOIOBBILF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x42F77A0", Offset = "0x42F61A0", VA = "0x1842F77A0")]
	public static void KELODGGKPBN([In] LPKDJPNEIBH<BBEHPNAKAOM> LDLKABKCANI, int LCPIEBCBBPL, TValues KIAGDMGGGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface OGDOIOBBILF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPKDJPNEIBH<TIndex> IICHEIIBHBH(int LCPIEBCBBPL, [In] TValues KIAGDMGGGNM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(TIndex ENMILGHAHOM, [In] TValues KIAGDMGGGNM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKPGKAHOCKE(TIndex ENMILGHAHOM, TValues KIAGDMGGGNM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface AKEDODBAPKM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex JANIJNHBHFM(int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NFOCKPCGBLJ(TIndex ENMILGHAHOM, [In] TValues KIAGDMGGGNM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> FFBOCICCHLC(TIndex ENMILGHAHOM, [In] TValues KIAGDMGGGNM);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class EFALFKKHECK<TDeps, TIndex, TValues> where TDeps : struct, AKEDODBAPKM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D6A0", Offset = "0x3A0C0A0", VA = "0x183A0D6A0")]
	public static LPKDJPNEIBH<TIndex> KELODGGKPBN(int LCPIEBCBBPL, [In] TValues KIAGDMGGGNM)
	{
		return default(LPKDJPNEIBH<TIndex>);
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

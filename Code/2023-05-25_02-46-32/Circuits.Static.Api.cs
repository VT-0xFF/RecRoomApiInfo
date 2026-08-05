using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x167C3A0", Offset = "0x167ABA0", VA = "0x18167C3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
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
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MGNELBEPOLC(in HEEEIFICCNO PDEDDIGJHCG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MJEOEEEGEHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MJBHACCNKIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IMNIHLGBDNI NIBEKCGPHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OHEAGHBKIGJ AABNIDHKHID;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
	public MJBHACCNKIH(IMNIHLGBDNI ACFCCJGDFGH, OHEAGHBKIGJ HNACOCBLEJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EFIODMELMJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<EFIODMELMJL> NIDEMAANECO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFGAHKPBDCA();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNLLDCOACGL(GFLMBMOIAPM MAOPJNOIHBH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJMLDAEIIPH(GFLMBMOIAPM MAOPJNOIHBH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JKJGEMKNGEJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct LFHFNCEJCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly MLJEGCBGPGL DKMPFGNABJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IReadOnlyDictionary<Guid, Guid> KFPDLJKJIMB;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x167BF80", Offset = "0x167A780", VA = "0x18167BF80")]
		public LFHFNCEJCMD(MLJEGCBGPGL LMMHAIGBGJO, IReadOnlyDictionary<Guid, Guid> IALEGAFODIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct JEJMDLLCLNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly IReadOnlyCollection<ByteString> DAGPFFAIHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly IReadOnlyCollection<ByteString> NJDJEFALGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly IReadOnlyCollection<ByteString> MEPDGDMCNPB;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DF400", Offset = "0x9DDC00", VA = "0x1809DF400")]
		public JEJMDLLCLNK(IReadOnlyCollection<ByteString> DLKFFAKNCOE, IReadOnlyCollection<ByteString> PDKEOFBIPGD, IReadOnlyCollection<ByteString> KDHOEEDIDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct GAFJDGGIGFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly MLJEGCBGPGL DKMPFGNABJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly IEnumerable<HGNMPOIAAKI> GMPHCGIJEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly bool CPPDKBLFMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89690", Offset = "0x88A90")]
		public readonly global::OOHDKCNKKJB<DJPDHPKBBFK> FHDFKKHGCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int? IJDFIBOAPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly CODGPOKJEGN? NCHBPAPBDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly CODGPOKJEGN? FENEJHPPADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly JEJMDLLCLNK? LJMPGLFKBHD;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x167BED0", Offset = "0x167A6D0", VA = "0x18167BED0")]
		public GAFJDGGIGFM(in MLJEGCBGPGL LMMHAIGBGJO, IEnumerable<HGNMPOIAAKI> LDOJACGGACG, bool EBIGPHIOJBE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x896F0", Offset = "0x88AF0")] in global::OOHDKCNKKJB<DJPDHPKBBFK> PHNBFNJHAAA, int? HDPIIINCCLN, in CODGPOKJEGN? BODDDJEPBCM, in CODGPOKJEGN? KEPDHFAHOOI, in JEJMDLLCLNK? HKBICEKALOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKAJPLLDHFL? EMLKFEIIMAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89DA0", Offset = "0x891A0")] in global::OOHDKCNKKJB<DJPDHPKBBFK?> DJCGAIJIDMG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DMMBFDBCOPO? LBHCFJHELLH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89E10", Offset = "0x89210")] in global::OOHDKCNKKJB<GBHOLOEGOCK?> ENELKLKDEHJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::PKJAENHCLMN<LFHFNCEJCMD, NKLELKIHOJN> PBCFHNOCALL(in GAFJDGGIGFM PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPMEAPKGEMA MCPKAJBIOEI(IEnumerable<HGNMPOIAAKI> LDOJACGGACG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPMEAPKGEMA JLONPEIILBB();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MLJEGCBGPGL PMJEFEFNHPL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89E80", Offset = "0x89280")] IEnumerable<global::OOHDKCNKKJB<GBHOLOEGOCK>> OPEPIJBOEOG, IEnumerable<HGNMPOIAAKI> LDOJACGGACG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class CINOEDHPPIC
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MKLFLFOOJGN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JBBBOLIAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MIDNIKLIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AHPGPIFIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class KMOMAJMFANO
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GJPMJPJNPOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly CIOHJELGAHC APAFFFJKKII;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	public GJPMJPJNPOO(CIOHJELGAHC LAMKLOBMDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class IFAPNPKCHPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MOIPMGHGLDD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JKJGEMKNGEJ? EABDDJEADPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AHCEGHKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BJALAJPBALD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JKJGEMKNGEJ> PCGKBMHJHJL();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::PKJAENHCLMN<MJBHACCNKIH, NKLELKIHOJN> EPALGFBLAPM(in MJBHACCNKIH LMMHAIGBGJO, IEnumerable<HGNMPOIAAKI> LDOJACGGACG, int EMIGLHINIKN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DJPDHPKBBFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NKAJPLLDHFL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BILDBJHNPPE? DNFDNICACLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DMMBFDBCOPO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	object CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CEPBNJGDDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int OHBNBDLMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ELAIDPHHMOG MPKOMPNKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NodeVisualizationKey JKHFJODHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x897C0", Offset = "0x88BC0")]
	global::FLKPPPHNEOM<MJEOEEEGEHH> BBEFCCIPBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PHGGIMHBEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Guid GCHMEDNKCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OADKJGNLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool NNDOMNKDFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool MLEGGMABAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool AJDHJFENABA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HHOLLEJIGME
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MBJPPEJMCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int AMOOBDNHCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IBBAOEHGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string ADOJPJFCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DPHCHHNGFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HMAGBKIHIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MNMBEEHLPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FOFPDJEMNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool POMFGMPDBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CEMLOPEBMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NENFILKLNLH FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HEEEIFICCNO OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OCPLNNIHMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	[AEIDOAEHPPH(true, "FloatingText")]
	bool OENELDBNNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MKLFLFOOJGN? NKBDMOIPLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NOHBCJLLDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89850", Offset = "0x88C50")]
	global::OOHDKCNKKJB<DJPDHPKBBFK> OBJFEABEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JOFMJBBGELH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x898C0", Offset = "0x88CC0")]
	global::OOHDKCNKKJB<GBHOLOEGOCK> BJPHJBMNEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IIOJCADNPFF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NOAOIOFDIAM HEBNBHNHAKM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MGNELBEPOLC MNEMJFHPOGJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action FFEPICIPMIG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> PCLOJFBOKOC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action EEAHEIGPFHP;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GINJEKDFHNI(int MHIDDOOKKLA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CEGBFEOBNEL(in NENFILKLNLH ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LGAGLBLDGLF(in HEEEIFICCNO ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void POPIHLAMFGJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MPNMKADFDMA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ALGBBDNEIDE();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void NEGBHCEKFEM();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void FFDHOFOOFIE(string BPOKAAOBIOI);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void FKOJLPDCGAA(int NHHNPPKPBIA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "46")]
	global::PKJAENHCLMN<DPIJIKFEAOC, HECNFFAEBGF> DJHCJKHDGEN(string EHNPFOADAIA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GKPOPACCABJ(out Guid NJFBFFHEIKP);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool IDNLIEGNIFB(in Guid DJCGAIJIDMG);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NHGHFKAFNCD();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void DBGNPGEPPAN(bool CFDLPCFDLDE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	CODGPOKJEGN AOGHJEBIGLF();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	bool GKMCEJDEDON(int FFIFJEJFNLL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task<global::PKJAENHCLMN<DPIJIKFEAOC, HECNFFAEBGF>> IJCHCONOBDC(string EHNPFOADAIA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DPMEAPKGEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly MJBHACCNKIH DGLPPFDBOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly GJPMJPJNPOO FHBEENEPMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x167BE90", Offset = "0x167A690", VA = "0x18167BE90")]
	public DPMEAPKGEMA(in MJBHACCNKIH CMMCIHFHBLL, GJPMJPJNPOO IKHHHDILDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class IJPNAPMLKPH
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GBHOLOEGOCK
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void NOAOIOFDIAM(in NENFILKLNLH ELPFDBFBPJP);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct MLJEGCBGPGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly EEONMADIGIK EODKNKCBLBG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	public MLJEGCBGPGL(EEONMADIGIK OJPPIJGPJCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HECNFFAEBGF : NKLELKIHOJN
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GKFPINGACLD : BELEEFKDBKB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MOIPMGHGLDD OLGIPHNBIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BILDBJHNPPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89970", Offset = "0x88D70")]
	public readonly global::OOHDKCNKKJB<GBHOLOEGOCK> BEMIKDEIMHK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x837710", Offset = "0x835F10", VA = "0x180837710")]
	public BILDBJHNPPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x899D0", Offset = "0x88DD0")] in global::OOHDKCNKKJB<GBHOLOEGOCK> DBBFALJLGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NEJHAPFOGFM : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89A40", Offset = "0x88E40")]
	Func<List<KeyValuePair<string, MKEHFBIKBJP>>> BOCHNHFBEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Func<bool>? CCECIAANGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89AA0", Offset = "0x88EA0")]
	Func<int, string> HGCOMMMPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Action? AJCHALLLDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Action? JKEDFJJCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool FFHNIAIMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool AKDLIKGPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KAIKGELPCNJ : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Func<Dictionary<string, MKEHFBIKBJP>> BOCHNHFBEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Func<bool>? CCECIAANGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89B00", Offset = "0x88F00")]
	Func<int, string> HGCOMMMPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FFHNIAIMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool AKDLIKGPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BLJIKNHJAHG : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	GFLMBMOIAPM LPKFLLFNCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HDAIKPEDMEI : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	Func<float> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Action<float> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string FOKLCAMMKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OLGCKHOLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float FDMJOHNAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float AGIOHNAEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DEFPINCHODA : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int? BKBFEACHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool MKOJIIHNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum GLCPLKCMIGN
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EPHJIACDJHG : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int? BKBFEACHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool MKOJIIHNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DPBBNKFIFOK : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Func<float> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Action<float> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float FDMJOHNAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float AGIOHNAEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<bool>? CHJPNJPAHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int JFIFGDMKEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	string FOKLCAMMKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Func<float, float>? FOBKBMOMBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Func<float, float>? PPDLMLNPGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BKDEFKHMNHG : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Func<bool> BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Func<IReadOnlyList<object>> PAILAJFBAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Func<object, string> FBCEHICJIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Func<object> PAEGAEHLKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Action<object> EPEGIKANBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DLMHBEFHDGL : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	int FKKADJMHIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89B60", Offset = "0x88F60")]
	Func<string, bool> FABCLANFMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	string? OJCBLPPINGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool MKOJIIHNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GLCPLKCMIGN JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BIAAGEBPCKJ : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	Func<bool> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Action<bool> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int FEBAPKLGMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IANDKLAOHCC : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Dictionary<string, MKEHFBIKBJP> FABCNDBLNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Action? AJCHALLLDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Action? JKEDFJJCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89BC0", Offset = "0x88FC0")]
	Func<int, string> HGCOMMMPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool FFHNIAIMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool AKDLIKGPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89C20", Offset = "0x89020")]
	Action<EFIODMELMJL> NLIANCOKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ECCABHJGCCC : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Action HDJEAGGKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	GLCPLKCMIGN JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string MOPBINMAJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	string FPCNFPFHBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DCPBHBJPKBO : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Action HDJEAGGKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BFEEEGIDHBM : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	string LEJNMGCPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GFLMBMOIAPM
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JEBDGFODPDF : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	int FKKADJMHIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89CA0", Offset = "0x890A0")]
	Func<string, bool> FABCLANFMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	string? OJCBLPPINGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	bool OLBMBPJLHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KHDKLPGKFLI : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool OJEAODJKICC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	bool DFNADGNCMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
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

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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x16FC740", Offset = "0x16FBB40", VA = "0x1816FC740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void BMJCMBPDMLM(in PGFGIJOBBDI OEIEMLHEENN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class EILMNANBMCH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OGFLFDJCMGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MLHGCNFBPFD KDDKCPMLBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HFKGNCPOBDP DLOIMANMFNM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	public OGFLFDJCMGC(MLHGCNFBPFD EALGELHKBDG, HFKGNCPOBDP FEFAFJOKDPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JHDLFBCPFHN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<JHDLFBCPFHN> AEKHFGPLPLE
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
	void HEJABKPPAHB();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBACFIKIIBM(JCOLLLFPGKF DNKAAHGAKMM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAGFFHGAGLA(JCOLLLFPGKF DNKAAHGAKMM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JEKFEILPFIB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct KNCLGHEKJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly FMOACBJIOFD POHNMKBMPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IReadOnlyDictionary<Guid, Guid> OOOAKONPDDB;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x16FC700", Offset = "0x16FBB00", VA = "0x1816FC700")]
		public KNCLGHEKJMD(FMOACBJIOFD PHAIODMMNJC, IReadOnlyDictionary<Guid, Guid> OKPABAMAEPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct NKJHCFNLCAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly IReadOnlyCollection<ByteString> OGKGOHDEMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly IReadOnlyCollection<ByteString> KBEFGLFANIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly IReadOnlyCollection<ByteString> KOCKGOAGBAI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1D1C0", Offset = "0xA1C5C0", VA = "0x180A1D1C0")]
		public NKJHCFNLCAL(IReadOnlyCollection<ByteString> KEEOJCEKDGL, IReadOnlyCollection<ByteString> HGOKIMFNFDP, IReadOnlyCollection<ByteString> NIHBEKKINDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct BNOGAFCBOIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FMOACBJIOFD POHNMKBMPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly IEnumerable<BBMFKNBGCCI> HGENDJHLICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly bool NONGAHNFKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x897B0", Offset = "0x88BB0")]
		public readonly global::ALHBGECNNLP<OCKONIONONG> CCEAIEKAHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int? MFLKIEFJLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly DJNNNLFDDGE? FJIFNNCDOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly DJNNNLFDDGE? DPJLGBJFAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly NKJHCFNLCAL? KCFNCFNGHIK;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16FC580", Offset = "0x16FB980", VA = "0x1816FC580")]
		public BNOGAFCBOIP(in FMOACBJIOFD PHAIODMMNJC, IEnumerable<BBMFKNBGCCI> CHDEDKGGEHE, bool JENNJMEDDGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89810", Offset = "0x88C10")] in global::ALHBGECNNLP<OCKONIONONG> EHMBFAGHNDO, int? MDFDJCJGBJA, in DJNNNLFDDGE? LAKEFEFLINC, in DJNNNLFDDGE? NKCHJOMFPGD, in NKJHCFNLCAL? PLJCJGMCGEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFINBHEHJLJ? BMHALCGFFGD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89EC0", Offset = "0x892C0")] in global::ALHBGECNNLP<OCKONIONONG?> KCFOMBLHMHL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDBPKLHEGFK? CCJNOOGLBKC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89F30", Offset = "0x89330")] in global::ALHBGECNNLP<OKMKFAGHJMD?> APJCGFNBKKN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::EJIEKPGJGCC<KNCLGHEKJMD, DELOHBKGNFD> INEPHBOIPEP(in BNOGAFCBOIP KBOOOAILJFG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CNDGHPFPCLI OJHGIGPCPGM(IEnumerable<BBMFKNBGCCI> CHDEDKGGEHE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CNDGHPFPCLI FBAMMPJADGL();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FMOACBJIOFD DONDMOMGEGG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89FA0", Offset = "0x893A0")] IEnumerable<global::ALHBGECNNLP<OKMKFAGHJMD>> OKHHEFKJGHF, IEnumerable<BBMFKNBGCCI> CHDEDKGGEHE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class IFFNIPNHIPA
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DEBJIOJKLIK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KLNDGNBJOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BMHKOHJCJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KFLEDONKJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CALJIOIEBOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HLPKFDJAJMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly BBOGGIOJCHA AGIFGIBJLAO;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	public HLPKFDJAJMA(BBOGGIOJCHA FCAKNNEAIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ABGNIJONLNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CMBGBDDNJML
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JEKFEILPFIB? BGHJOACDLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NEHAMOBHOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MCLCHHPPICK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JEKFEILPFIB> KDCMIFABBIN();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::EJIEKPGJGCC<OGFLFDJCMGC, DELOHBKGNFD> BDBJNPNOKMJ(in OGFLFDJCMGC PHAIODMMNJC, IEnumerable<BBMFKNBGCCI> CHDEDKGGEHE, int OCIEIDBPHMM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class OCKONIONONG
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EFINBHEHJLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FCENFKKOKAF? HCLBHECLFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IDBPKLHEGFK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	object BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EBKOAPEOJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int KGMDFLMACAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PNADEAIDAHO LELHKJNBCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NodeVisualizationKey KGGJGJMDBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x898E0", Offset = "0x88CE0")]
	global::DKJMPNEPOKM<EILMNANBMCH> OINDFMHGODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HJGJDDKGPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Guid FONGPLDKKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NHNAJMNMPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LPKFBAIMKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool DBBPEMEGKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FOLHEMFNIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool PMJBNMBCADC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OEHLCHBBCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NCFOLIONCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KGEOCBAHBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string NNOHEDPEELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ECMFFPGAECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CGMFMMHKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MMDEOKLCBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LFLBKOJAHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PDGAGHMJCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KINBAGFMPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OBHBJAMPCFH EFLKGNHAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PGFGIJOBBDI EPEMEPHGANB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EMEOBPLIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	[PDLKJKANJMO(true, "FloatingText")]
	bool CICCPGCMLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DEBJIOJKLIK? OOAPBCPHIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool BMKLOGHEDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89970", Offset = "0x88D70")]
	global::ALHBGECNNLP<OCKONIONONG> BIIGCAMPPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool KAFJIFOGOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x899E0", Offset = "0x88DE0")]
	global::ALHBGECNNLP<OKMKFAGHJMD> DHOAFNEEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JFPKKAPMJEI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EOFDOEEBLCJ GMPANAOJCME;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BMJCMBPDMLM LOOCAJFOJFK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action PNCHDFLBGNI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> DDJNALBFPJP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action NFBPPICLLLC;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIGGEEBHENI(int AFNAMCEEOMA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DGNPOJOBIOF(in OBHBJAMPCFH EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DNIEECILPMF(in PGFGIJOBBDI EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LEIHLBGLFDB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BMNMMCKMELL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LEIDHJOLKJI();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void PDPAIBGIJNI();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void HPCPOAPDLKF(string LMAOKJPAKEM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void BKNPDJPABCH(int CJOLACIBAJH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "46")]
	global::EJIEKPGJGCC<CPKDLGGKAMN, EACFJIDFNJL> BDDLADGIOPL(string ECAOKINFBGP);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool ABMKINIDJLC(out Guid DEHLNLEIKLF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool NHMDMPPIMEC(in Guid KCFOMBLHMHL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LLMEAOAJOJJ();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void KDGPDDPOHCI(bool AHOODKBGLDI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	DJNNNLFDDGE GDIHECJCOLN();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	bool EFHMLIBENPL(int BHJDLHIGDGK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task<global::EJIEKPGJGCC<CPKDLGGKAMN, EACFJIDFNJL>> DLEOHLNLFKM(string ECAOKINFBGP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CNDGHPFPCLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly OGFLFDJCMGC MFDLNFCOKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HLPKFDJAJMA OACPFOJHFFO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x16FC630", Offset = "0x16FBA30", VA = "0x1816FC630")]
	public CNDGHPFPCLI(in OGFLFDJCMGC IHPHNJFCMAH, HLPKFDJAJMA ONBHNNGAOPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class JIELJAJALEO
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
public sealed class OKMKFAGHJMD
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void EOFDOEEBLCJ(in OBHBJAMPCFH LGFAFJOBNGM);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct FMOACBJIOFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly MCCKFDJJNDM EINLCDCHMBJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	public FMOACBJIOFD(MCCKFDJJNDM IKAOGPODIAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EACFJIDFNJL : DELOHBKGNFD
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HLLAMFPGEPB : EIOCCFCCEGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CMBGBDDNJML KGKKOLFHAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FCENFKKOKAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89A90", Offset = "0x88E90")]
	public readonly global::ALHBGECNNLP<OKMKFAGHJMD> ODLJIBOJLMI;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x837700", Offset = "0x836B00", VA = "0x180837700")]
	public FCENFKKOKAF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89AF0", Offset = "0x88EF0")] in global::ALHBGECNNLP<OKMKFAGHJMD> BMCOAFGBDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DCFGCOLOHJI : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89B60", Offset = "0x88F60")]
	Func<List<KeyValuePair<string, EEGKEOAMMJM>>> PMJGFMPGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	Func<int> KOCCPBKPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	Action<int> CBAEHDJNDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Func<bool>? CLFAEHAEBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89BC0", Offset = "0x88FC0")]
	Func<int, string> ENDOBNGGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Action? DGBBEJHGKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Action? IPFELNAOBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool IPJEMKIBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool NPFLGBFLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HIICKFJIIEK : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Func<Dictionary<string, EEGKEOAMMJM>> PMJGFMPGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Func<int> KOCCPBKPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Action<int> CBAEHDJNDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Func<bool>? CLFAEHAEBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89C20", Offset = "0x89020")]
	Func<int, string> ENDOBNGGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool IPJEMKIBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NPFLGBFLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NGHAPLFLEDK : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	JCOLLLFPGKF GCIMCDGIBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GOHOKADKDFP : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	Func<float> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Action<float> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string CDJEFKGJHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool COLKEILMOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float HBOGIDGHHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float JCLBENHCAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GGMNBNPINEP : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Func<string> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Action<string> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int? PIKNEDCCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool EAHGMMAEDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum JOCLPEOFOMO
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
public interface GCCPBKCKHPJ : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Func<string> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Action<string> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int? PIKNEDCCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool EAHGMMAEDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HAFHNCJPHCO : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Func<float> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Action<float> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float HBOGIDGHHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float JCLBENHCAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<bool>? HLKJKDADKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int EALBBNFOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	string CDJEFKGJHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Func<float, float>? EPAMFMAJPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Func<float, float>? LEEKIKBCEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NEKGIFJMNHH : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Func<bool> IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Func<IReadOnlyList<object>> PONKEDIJDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Func<object, string> GPEMNGNHGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Func<object> ENFDHLADPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Action<object> FHNOBOMLJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DDNAIFDFHML : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	int GLBNHMGELOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89C80", Offset = "0x89080")]
	Func<string, bool> AEJNEMHJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	string? HFPPPJJHAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool EAHGMMAEDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	JOCLPEOFOMO KEFHMMCGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Func<string> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Action<string> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LMCALLJCIBN : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	Func<bool> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Action<bool> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int MAOODCNPJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AIAFHLCDJMI : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Dictionary<string, EEGKEOAMMJM> GEJFCKIEDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	Func<int> KOCCPBKPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Action<int> CBAEHDJNDAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Action? DGBBEJHGKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Action? IPFELNAOBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89CE0", Offset = "0x890E0")]
	Func<int, string> ENDOBNGGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool IPJEMKIBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool NPFLGBFLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89D40", Offset = "0x89140")]
	Action<JHDLFBCPFHN> GAGDDAOGOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OACPIOHFGCN : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Func<string> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Action<string> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Action CDIMAIOLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	JOCLPEOFOMO KEFHMMCGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string DFDHGMAGLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	string DCIFDPOBFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DGHIPPFILHC : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Action CDIMAIOLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KDMKEDINAEL : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	string ALMFEDOKBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JCOLLLFPGKF
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KAGAPFIJMNP : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<string> JCCADOCPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Action<string> EPOABKAPMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	int GLBNHMGELOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89DC0", Offset = "0x891C0")]
	Func<string, bool> AEJNEMHJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	string? HFPPPJJHAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string DKJDCEHLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string FEFDIBFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string DHHOPBCHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	bool APOHJDLLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool BEIDOHFEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BCAPELBMEAA : JCOLLLFPGKF
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	Func<int> KOCCPBKPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	Action<int> CBAEHDJNDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	Func<bool>? IJIJLFOFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	Func<bool>? MJIFDGNLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool PICKICJIMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string KIELKPOKPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	Func<bool>? IPGLIHDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	bool NFDNBMABGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	bool BEIDOHFEAMF
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

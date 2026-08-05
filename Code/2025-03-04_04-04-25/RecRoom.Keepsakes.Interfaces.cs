using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PDFNGNEHOPO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HPDENNBAGKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LDBACIOFHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> JDAHJCNPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> PDBBEJLAJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> BKEODGKHKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> LIGCONLAOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IAALFFAGMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> PDPBEKKOKMO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LAJGPAMLJKP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IMKPBFPPJAC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OCCNNMOLCBH([Optional] List<string> PLMCLHPCKGC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NEEPBAPEEOL<Guid> HDCDAFPBCID(MAIAFFCEMDA EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HJOKANJAKGB FAEGOKPFOKP(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HJOKANJAKGB HEHMKNNEGJA(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KKNAALMPOAI(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OKLODBGBFAL(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IBCPHAPFJLO(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GGKLEABLGKL(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IGPCHGKBELD(MAIAFFCEMDA EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KKLJJPNKEDA(Guid CBCFADAIBAF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int GNNGDGIMMFA();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NEEPBAPEEOL<int> NLLAJGEJEHC(long FFFLOIOFAMB, long ECHBAPBKGNC, [Optional] MAIAFFCEMDA? EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NEEPBAPEEOL<int> IJOMEOOBCKO(long FFFLOIOFAMB, long ECHBAPBKGNC, [Optional] MAIAFFCEMDA? EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> BJECIEFEGFE(long FFFLOIOFAMB, long ECHBAPBKGNC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> FDHEMHBDDLC(long FFFLOIOFAMB, long ECHBAPBKGNC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NEEPBAPEEOL<IEnumerable<Guid>> IOMJIMDFPHP(long FFFLOIOFAMB, long ECHBAPBKGNC, [Optional] MAIAFFCEMDA? EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NEEPBAPEEOL<IEnumerable<Guid>> DOFGGPLGLBD(long FFFLOIOFAMB, long ECHBAPBKGNC, [Optional] MAIAFFCEMDA? EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string OOEJNGOEPFD(MAIAFFCEMDA EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string IPKPKEBGNJH(MAIAFFCEMDA EALFFCNJEPJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<MAIAFFCEMDA> DPGODPFNMHF();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<MAIAFFCEMDA> OIAFJGAHLCJ();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool DAGNOCENJMM(long FFFLOIOFAMB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool NLMAPJBNCMG(long FFFLOIOFAMB);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool IHBFGIIFIBL(long ICPGCFKAGBA, [Out] DateTime FJAPCIHJEHN);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JOBCAOKJGNE(long ICPGCFKAGBA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long GCHFCILHOIM(long IDHKBCNDMIM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int AAHFHLNBBKK(long ICPGCFKAGBA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool IDPMKEGPOGK();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool HCBBPJBOGHD(long ICPGCFKAGBA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<long> KGNJAOAKMIF(long ICPGCFKAGBA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int KPGBJNONMBL(long ICPGCFKAGBA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string HIOFLPHIMLB(PKPEIGLPOOD HBFCLOEJEAJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string KOPCCDNHDIG(PKPEIGLPOOD HBFCLOEJEAJ, int GNLBGJKLMHD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string DGKBBLLEEAO(PKPEIGLPOOD HBFCLOEJEAJ, long FFFLOIOFAMB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long NGEIDKAECHO(long MFJNOLFGAKE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	MAIAFFCEMDA LHGFJKMGEGB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EBPFFGDIFFM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum GOIHJNKPLNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool IEKFENDAPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public GOIHJNKPLNN? ILAGEAELMFI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x753E980", Offset = "0x753CF80", VA = "0x18753E980")]
	public EBPFFGDIFFM(bool JCEAEDIKDGF, [Optional] GOIHJNKPLNN? JDFMGCJLBME)
	{
	}
}
namespace Cpp2IlInjected;

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

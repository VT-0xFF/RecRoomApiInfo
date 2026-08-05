using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AALCBNDMPIM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void ADNKHFDJONK(bool PHGMKMDJOCK);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANKAFCALFMK();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNLNKAOAOAF(List<KABAKBKCMCP> GLNFACAIDAH, bool HFNJGNODNCE, bool KDHCGGMIOOL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLOADOFLCEN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<LNKBBFODFEI> LNIDPNCLCDC(KABAKBKCMCP IABFIPEOOOD, ADNKHFDJONK DKDPAFJDNNF, bool BPCDGOJIDHC = false, bool DFECFBHAFOC = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFKCODNMOBC(KABAKBKCMCP IABFIPEOOOD, [Optional] ADNKHFDJONK DKDPAFJDNNF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BBAJJJDICEC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGFLBGGNLJI(IEnumerable<LPCEEOAFMAN> KCCMCIEBMHE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJJAMNJPJNF NGBKIABKJEL(LPCEEOAFMAN BKFPPBFDIMG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<LPCEEOAFMAN>> EKLMFLNGBOO(string JGFLIPDEPGF, bool? FFCMBLJKLLO, bool? HJPPANIEIEC, IEnumerable<int> IEONCMBADKD, bool IJIEDPCENLI, Func<List<GIGCGBBOIBH>, Task<List<GIGCGBBOIBH>>> APADJGCJCOP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<LPCEEOAFMAN>> BLCEKPPAMFG(IReadOnlyList<NAFDJPEFHNC> KBDGPEEICEE, Func<List<GIGCGBBOIBH>, Task<List<GIGCGBBOIBH>>> APADJGCJCOP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> IGKJFIELBCO(Guid PCIMFMHGJDE, long EKNFNCMCLFL, GiftItemDTO AELKLAJNIFP, EPJAFMLNIDE EOPHMAPELAL = EPJAFMLNIDE.RecCenterTokens, [Optional] long? FDDOOHHHMGB, MANGHFFICCB CINFOJPBEMD = MANGHFFICCB.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> FBAIPCONNGJ(MANGHFFICCB CINFOJPBEMD, EPJAFMLNIDE EOPHMAPELAL, int HPGMFNHMFOA, long EKNFNCMCLFL, long? FDDOOHHHMGB, int CCFDOCHGFLO = 1, bool OGHFLGIEMIK = false, bool OCHHPIKNELG = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> CIKFOAHJFIK(MANGHFFICCB CINFOJPBEMD, EPJAFMLNIDE EOPHMAPELAL, int HPGMFNHMFOA, long EKNFNCMCLFL, long? FDDOOHHHMGB, IReadOnlyCollection<int> AOMLHCILGDO, string KBPDEFFIKOJ, bool MDLICJDHHAO, HFEIOFNECBI GBMCPNKHLII, int CCFDOCHGFLO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> KGPLBGANBPP(MANGHFFICCB CINFOJPBEMD, EPJAFMLNIDE EOPHMAPELAL, IReadOnlyList<int> AEOIJCCLPKI, IReadOnlyList<long> GFIPDIHKNBP, long? FDDOOHHHMGB, int GHCHKOGMCKK, string KBPDEFFIKOJ, bool MDLICJDHHAO, HFEIOFNECBI GBMCPNKHLII);
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

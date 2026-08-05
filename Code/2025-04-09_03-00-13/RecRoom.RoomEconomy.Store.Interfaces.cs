using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EPEOEOGNDLB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void MGDJLKNOFED(bool EGLDGMPHBBP);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOAONOMIMHH();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEMNEDPHKHL(List<HLDNPMEHLBF> PIIBFMDEKLB, bool BJKPGMIMEAC, bool CLOHIBJLJFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPPGHEOIFIH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<CIKDDGFOAFI> AAAGLCGAJHA(HLDNPMEHLBF ELDKIKEONAE, MGDJLKNOFED ADLKPPBLCIG, bool FBHJHGBCNOC = false, bool MOHILEBCNCC = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFIBKPEOCCA(HLDNPMEHLBF ELDKIKEONAE, [Optional] MGDJLKNOFED ADLKPPBLCIG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LEOONCFCODI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOJFJGLBDDK(IEnumerable<CJONIHPBPHK> OLKJELILBBO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKBNOMMHCNP JMAKKFGFNBH(CJONIHPBPHK GINDAKCEFBF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<CJONIHPBPHK>> AALGOCEKHMP(string CHHIMIDMPFM, bool? OEMPMOJBBJL, bool? FIDNFHOOFMF, IEnumerable<int> EADGEJJADEB, bool AMPKFGOPAGN, bool IMHKKFBMCJA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<CJONIHPBPHK>> GFFOKGNKGAG(IReadOnlyList<BLIEKJLPENN> ELFACGAHAMA, bool BECFKIAGFFK = true);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> LLFLCIFLIPM(Guid LMGCOEEBLBC, long LHMMCFNMFHK, GiftItemDTO BNOOGHLPMIJ, JMJFIJCEBKJ KMICBDLIHGF = JMJFIJCEBKJ.RecCenterTokens, [Optional] long? CFKIBLGCNPD, KAPAKINLJNB BJOJJMEFCAJ = KAPAKINLJNB.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> CLOLDKCMFFD(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, int JFPNPBEOJIC, long LHMMCFNMFHK, long? CFKIBLGCNPD, int GPCNCLKGHHE = 1, bool APOHMELMCDJ = false, bool OHDFCPDCILJ = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> IHGPLPKDHFE(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, int JFPNPBEOJIC, long LHMMCFNMFHK, long? CFKIBLGCNPD, IReadOnlyCollection<int> IAFENCNAOED, string DAMFJFKKFBI, bool BPMOGMAPOGP, CJEELAAIIDE LDHEDJCJGMK, int GPCNCLKGHHE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> AMKHKLAOIKI(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, IReadOnlyList<int> DAJHJNHIAFN, IReadOnlyList<long> AGJEIDIAAKF, long? CFKIBLGCNPD, int JECAMNCMGAO, string DAMFJFKKFBI, bool BPMOGMAPOGP, CJEELAAIIDE LDHEDJCJGMK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LHCODJPAKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHPMIANEPOM(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CJONIHPBPHK> KGAHGODOEEM(NLJANFOAFJJ EPAFBKOOOLI, IReadOnlyList<CJONIHPBPHK> MGCEJOCCONP);
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

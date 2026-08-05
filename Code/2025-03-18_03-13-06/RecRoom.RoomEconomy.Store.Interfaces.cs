using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface POIMMNLFJPP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void CEIEFJBCIHL(bool EKMHGACKPKM);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIGNGDFBKIM();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCOKECDEMJA(List<DINOAJOKBHF> HANFHGNJKEL, bool FIEDLENIEPD, bool MMHHIFGHHMD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPBGCMGPFHK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<DEPLMKJKOMK> DMCMJMNEPBE(DINOAJOKBHF MINFGJIBBII, CEIEFJBCIHL GIIPLELNBKP, bool GMJPCDLGFBP = false, bool OKBGCBICKPN = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGNDICGIMCL(DINOAJOKBHF MINFGJIBBII, [Optional] CEIEFJBCIHL GIIPLELNBKP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EBFFFHNOALK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAICEEGEHCK(IEnumerable<JHNNDMCAFNP> CGGMENPHCOK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPGDFPCDODM HHLNHBOPHEN(JHNNDMCAFNP PDNDPCPEFBF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<JHNNDMCAFNP>> LPPLICLCFIH(string FPHDKBBNDNE, bool? HOKJAFNFLLB, bool? HGGLMFEMOHA, IEnumerable<int> GOIEJIDMKLI, bool POBANDIJKJL, bool JNACIBIAIOJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<JHNNDMCAFNP>> POHIBPEIGCL(IReadOnlyList<PPCIFNMBIEC> ABDHBJNIOCF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> ODEJGLDAJLP(Guid DLBJLJBGNMD, long POBIMLMMJMA, GiftItemDTO OEJDCBPELEM, BOBIMJKOHAM MFDPCLOJDHA = BOBIMJKOHAM.RecCenterTokens, [Optional] long? EDDKHFGBMFB, JOJCOALEHPO IHNLJACAGEM = JOJCOALEHPO.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> OHAKFAIHGMM(JOJCOALEHPO IHNLJACAGEM, BOBIMJKOHAM MFDPCLOJDHA, int DHBJFOJNPKL, long POBIMLMMJMA, long? EDDKHFGBMFB, int BEDKPGPFHLI = 1, bool FKLGOMCAMHP = false, bool PBMNEDLHFGE = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> AKNGGCDCDHP(JOJCOALEHPO IHNLJACAGEM, BOBIMJKOHAM MFDPCLOJDHA, int DHBJFOJNPKL, long POBIMLMMJMA, long? EDDKHFGBMFB, IReadOnlyCollection<int> CBMJHKLBJHK, string DCEACFEGBDC, bool JAIPGGNBGIG, BJMCILGJIBE KBNLCBOBMGF, int BEDKPGPFHLI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> BGNEEBLMFME(JOJCOALEHPO IHNLJACAGEM, BOBIMJKOHAM MFDPCLOJDHA, IReadOnlyList<int> DBBGLLENMOF, IReadOnlyList<long> CJPIFFJHDIK, long? EDDKHFGBMFB, int FIGLFBNEMJP, string DCEACFEGBDC, bool JAIPGGNBGIG, BJMCILGJIBE KBNLCBOBMGF);
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

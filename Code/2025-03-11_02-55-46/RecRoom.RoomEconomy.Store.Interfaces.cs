using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PPPBCKBOHAP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void POBFEKNGCIN(bool DECBGAGAKJB);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCOEKDBJKEH();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPEPDKAPOAJ(List<OFOAMKHMBCJ> JEMOOAIKEJO, bool BPAKIOGDMOH, bool OCOMBLDKGLF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLOBDAONDAL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<MOLDBMJPKNN> MIFNIOKBCLM(OFOAMKHMBCJ IOIAAAJCJGC, POBFEKNGCIN LOGLEICCEGM, bool PIDEDFDHFKP = false, bool PPBNEBNNKNJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHAKPLDOHHM(OFOAMKHMBCJ IOIAAAJCJGC, [Optional] POBFEKNGCIN LOGLEICCEGM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IOLBAKBOGFO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOMMAPDOIFB(IEnumerable<AOBLIEEPFME> DPPCNDDOFAG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHAKHNGPPPO DLBFKDKNIMJ(AOBLIEEPFME PBLIBPBBABN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<AOBLIEEPFME>> OGONJBIDGLM(string KAFIFCHGCBM, bool? GJPDCFIEPNL, bool? LPLEJFEIOPH, IEnumerable<int> PLEHOGCEJOK, bool KKAJCDAJNJO, bool HKGPMECHIKI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<AOBLIEEPFME>> FLHLNLNAIJH(IReadOnlyList<CPPPGIHAECF> AACOEBLCKGD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> BOKFOCACIKG(Guid BNFNDCGCFGH, long EDGFACHOEOC, GiftItemDTO IMOCCDGIDFE, LMNPJOLMEFF HDODMFJNNAG = LMNPJOLMEFF.RecCenterTokens, [Optional] long? ODCBJACFGKB, PHKGDBEFEIP IJKLAMLPMIA = PHKGDBEFEIP.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> HLLNHJJNDBI(PHKGDBEFEIP IJKLAMLPMIA, LMNPJOLMEFF HDODMFJNNAG, int JHGOHHOIEGP, long EDGFACHOEOC, long? ODCBJACFGKB, int CILACHINJHL = 1, bool FCJGLENMBIN = false, bool GKAADKCEMHH = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> GNBCOBMDPKJ(PHKGDBEFEIP IJKLAMLPMIA, LMNPJOLMEFF HDODMFJNNAG, int JHGOHHOIEGP, long EDGFACHOEOC, long? ODCBJACFGKB, IReadOnlyCollection<int> NIINJCOLDDH, string LPIFIOEEOGF, bool OMHCGDGDACJ, AIBJOFIAIJG KKCKAOKJHHJ, int CILACHINJHL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> IBLKLKCEHJG(PHKGDBEFEIP IJKLAMLPMIA, LMNPJOLMEFF HDODMFJNNAG, IReadOnlyList<int> FFNDNBMECIN, IReadOnlyList<long> JKFFFMPKCHO, long? ODCBJACFGKB, int EGMGKPDEOMA, string LPIFIOEEOGF, bool OMHCGDGDACJ, AIBJOFIAIJG KKCKAOKJHHJ);
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

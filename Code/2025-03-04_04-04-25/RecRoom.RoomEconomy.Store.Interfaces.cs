using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KOFIPGLIJKN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void LNENGEJPMAI(bool KAPAOCNMHLM);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMPDKLLDJDP();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJPHIKHEONE(List<MNEFDGDOLIH> EAMFENGBLFL, bool ECBONHNALEJ, bool PCMDPNOAOGJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBMIHFHHIBG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerator<FBLKJCIOKGP> NIGGOFJGHDA(MNEFDGDOLIH HGIPNEPCOAD, LNENGEJPMAI IJCKFHFIADK, bool CBIAGAILFMN = false, bool CIKDOMAHIIJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLICCMAAFJD(MNEFDGDOLIH HGIPNEPCOAD, [Optional] LNENGEJPMAI IJCKFHFIADK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FLEGLJCJMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACIMKIMDIHE(IEnumerable<MOBJPBHHADI> PHPLCLJIOHA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KOPMHHENCNP NKNPEMGBLFF(MOBJPBHHADI IMBPCMFEPCI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<MOBJPBHHADI>> KGCJGKPJNDG(string LMEMKNINDBF, bool? EMEKHBMBEEI, bool? FKCHMMOCIFN, IEnumerable<int> DLGIBNMNPCG, bool MGFBOHDDNJH, bool PMFKMGIBOHL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<MOBJPBHHADI>> DOEDNOKBDGB(IReadOnlyList<JEJKIPMLEEI> KKGLPNLEJJK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> HNAKMCALHDP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> PHAKMOLGGDP(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, int ANFKLMBEEDK = 1, bool FLIDAPCKHGP = false, bool OJMMABDPBFM = true);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> BEDEEHOGJBG(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, IReadOnlyCollection<int> CPCFIPMJOCL, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM, int ANFKLMBEEDK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> NCAFNNMLGGH(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, IReadOnlyList<int> MODGKGPDPEJ, IReadOnlyList<long> JOKHJHLBJDD, long? PJOEJJABEEO, int BBPIIHOGLAJ, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM);
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

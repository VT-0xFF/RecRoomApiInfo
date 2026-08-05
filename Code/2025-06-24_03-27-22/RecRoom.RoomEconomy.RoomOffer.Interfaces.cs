using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EKGICIFMDLI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HBAAEHCBNNO EJHJMCBBIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PJAJEBBNNBK<JNGEBHOKLOH> PIKIIFIDGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PJAJEBBNNBK<Guid> DLMMGGCGNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<MDDPJNIIBBI<JNGEBHOKLOH, string>> NAHKNLLNDKJ(Guid? LFJGGIIPHOD, long JKJNCHGDMGL, string LAOCJKNALFF, string NFKNKHBBLBH, string PJOILBBKCNO, int DHMNKCHADGA, LFOAGFFIEOL CAIPJDNANON, [Optional] Dictionary<Guid, int> MJFALOELMDJ, [Optional] Guid? IEJABAJAKFG, bool EICPJEALOFL = false);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<MDDPJNIIBBI<JNGEBHOKLOH, string>> EPBMHODNJJJ(Guid CMMOANJGJDI, long JKJNCHGDMGL, string LAOCJKNALFF, string NFKNKHBBLBH, string PJOILBBKCNO, int DHMNKCHADGA, LFOAGFFIEOL CAIPJDNANON, [Optional] Dictionary<Guid, int> MJFALOELMDJ, [Optional] Guid? IEJABAJAKFG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<MDDPJNIIBBI<bool, string>> NCLEMJEIBJP(Guid MLCFFELIEFF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JNGEBHOKLOH> OCHABKGCNGD();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<BKFMDIKHFIM>> OIMGJLIDHGP(long JKJNCHGDMGL, [Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NFIGKFBEGIL(Guid MLCFFELIEFF, [Out] JNGEBHOKLOH LACCNICKJEP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BCMFJPEKPOO(string LAOCJKNALFF, [Out] JNGEBHOKLOH LACCNICKJEP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LAONGIHOELE(Guid MLCFFELIEFF, int NHGKGLMOPAL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MEAJMEABGCI(BJCCECIKIFB NEOGODNGJJE, Guid MLCFFELIEFF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<int> ANNFMNIPIIP(BJCCECIKIFB NEOGODNGJJE, Guid MLCFFELIEFF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PIDHGCIAGIJ();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KBDEHCEJPMH(Guid BMFFGEKEBGJ, [Out] List<string> CAOLNCKIBIA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<MDDPJNIIBBI<bool, string>> GDNMILGHCCE(JNGEBHOKLOH LACCNICKJEP, long FKFFAOOEBPM, int KCCIFDBLGOI, [Optional] string EJJACJNELOC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HJDNCHGOBMO
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPKGOAOLAGF(Guid OCNGFIBBKOL, string EJJACJNELOC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHOCKAELDLH(Guid OCNGFIBBKOL, string EJJACJNELOC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INBNMEFKLJO(Guid OCNGFIBBKOL, int KCCIFDBLGOI);
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

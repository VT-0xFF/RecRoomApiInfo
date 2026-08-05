using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GMFGPOPEPDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BHHPLLLFBGO HJENGAIFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2443B3895C0964", Offset = "0x0", VA = "0x2443B5095C0964", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x975BF8E80244454", Offset = "0x0", VA = "0x975BF9000244454", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EOPEMIILONN<FMBMDIHMAAF> GNFJIHNINMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2444A380244454", Offset = "0x0", VA = "0x2444A500244454", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2444A38975BFAC", Offset = "0x0", VA = "0x2444A50975BFAC", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	EOPEMIILONN<Guid> CDPNNMIJMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x975BFBA802444AB", Offset = "0x0", VA = "0x975BFBC002444AB", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2444FA802444AB", Offset = "0x0", VA = "0x2444FC002444AB", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2444FE8975BFAC", Offset = "0x0", VA = "0x2445000975BFAC", Slot = "6")]
	Task<FBEPHKHKLJE<FMBMDIHMAAF, string>> EBLAHEEEINI(long CGIDLDOBHII, string OHHBGJPCFJD, string JFBABPIJMOE, string DCHICAAFAFA, int LAPJPEBECIF, NDEHPGKNCCL KCNNINELJEC, [Optional] Dictionary<Guid, int> KJIIKMGPIKC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9679A7A80244525", Offset = "0x0", VA = "0x9679A7C00244525", Slot = "7")]
	Task<FBEPHKHKLJE<FMBMDIHMAAF, string>> NALKMEBPNGJ(Guid JFDFPLHONPD, string OHHBGJPCFJD, string JFBABPIJMOE, string DCHICAAFAFA, int LAPJPEBECIF, NDEHPGKNCCL KCNNINELJEC, [Optional] Dictionary<Guid, int> KJIIKMGPIKC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2445CC80244525", Offset = "0x0", VA = "0x2445CE00244525", Slot = "8")]
	Task<FBEPHKHKLJE<bool, string>> CMCICMKFDJO(Guid JFDFPLHONPD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2445CC8975CED0", Offset = "0x0", VA = "0x2445CE0975CED0", Slot = "9")]
	IEnumerable<FMBMDIHMAAF> JGAJAIHDCFN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x975CEEA8024461F", Offset = "0x0", VA = "0x975CEEC0024461F", Slot = "10")]
	Task<List<EHPGOHLABIK>> LLOGNNNBPHG(long CGIDLDOBHII, [Optional] CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2446238024461F", Offset = "0x0", VA = "0x2446250024461F", Slot = "11")]
	bool EJJHFAGBGCH(Guid JFDFPLHONPD, [Out] FMBMDIHMAAF MABALBDICBH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2446238975CEFC", Offset = "0x0", VA = "0x2446250975CEFC", Slot = "12")]
	bool OGCOPPBEKNO(Guid JFDFPLHONPD, int HFNAHOHJPMA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x975CEEA80244676", Offset = "0x0", VA = "0x975CEEC00244676", Slot = "13")]
	void KENJGJBIBFG(MNFCKJNKANA ACNHNLBOPON, Guid JFDFPLHONPD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2446A380244680", Offset = "0x0", VA = "0x2446A500244680", Slot = "14")]
	Task<int> BHACPOIGMJO(MNFCKJNKANA ACNHNLBOPON, Guid JFDFPLHONPD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2446A3895C0964", Offset = "0x0", VA = "0x2446A5095C0964", Slot = "15")]
	bool EEAMMDAGBAF();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x975C10E80244744", Offset = "0x0", VA = "0x975C11000244744", Slot = "16")]
	bool IEENHMILABL(Guid HPIMOBDLJLG, [Out] List<string> ENPNJIMAPCA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24479380244744", Offset = "0x0", VA = "0x24479500244744", Slot = "17")]
	Task<FBEPHKHKLJE<bool, string>> AEHKHINBMLA(FMBMDIHMAAF MABALBDICBH, long KGGPLAMMPJC, int LBCEMAMCEGO, [Optional] string FCIEOFLLLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LHAEONLPLMB
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2447938975C12C", Offset = "0x0", VA = "0x2447950975C12C", Slot = "0")]
	void IBDDPAKIEDM(Guid DNGMKMGNBGI, string FCIEOFLLLDL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x975C13A8024479B", Offset = "0x0", VA = "0x975C13C0024479B", Slot = "1")]
	void AAOOHDADLGL(Guid DNGMKMGNBGI, string FCIEOFLLLDL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2447EA8024479B", Offset = "0x0", VA = "0x2447EC0024479B", Slot = "2")]
	void FGNOHAGNIFC(Guid DNGMKMGNBGI, int LBCEMAMCEGO);
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

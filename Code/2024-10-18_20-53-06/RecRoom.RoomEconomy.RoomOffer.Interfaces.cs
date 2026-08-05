using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IBKEHKEFCHI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LDNMACGBDLI IHNGPJJKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x29CDA48029CCF5", Offset = "0x0", VA = "0x29CDA60029CCF5", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDA48A9BDA90", Offset = "0x0", VA = "0x29CDA60A9BDA90", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PJFDJKKNHLD<LPJPIDNNHJB> LNEGAOPFBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA9BDAAA8029CDF7", Offset = "0x0", VA = "0xA9BDAAC0029CDF7", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CDFB8029CDF7", Offset = "0x0", VA = "0x29CDFD0029CDF7", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PJFDJKKNHLD<Guid> NNDCHJCMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29CDFB8A9BDABC", Offset = "0x0", VA = "0x29CDFD0A9BDABC", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA9BDAAA8029CE4E", Offset = "0x0", VA = "0xA9BDAAC0029CE4E", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29CE738029CE50", Offset = "0x0", VA = "0x29CE750029CE50", Slot = "6")]
	Task<LMFFMMPMNDB<LPJPIDNNHJB, string>> LEAOCPPKMIM(long FJBFONPAOAD, string DDDHPCNFCEK, string BCAMDINMAHA, string DBALDCNBIMF, int GIMEHEPKKIE, CCKIJEALPFA GOLCDNNNGCF, [Optional] Dictionary<Guid, int> MIODJLDGGFB, [Optional] Guid? ILJCELOKLEB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29CE738A7D1C20", Offset = "0x0", VA = "0x29CE750A7D1C20", Slot = "7")]
	Task<LMFFMMPMNDB<LPJPIDNNHJB, string>> GLGHCOEIDOI(Guid PCDMEBECPGE, string DDDHPCNFCEK, string BCAMDINMAHA, string DBALDCNBIMF, int GIMEHEPKKIE, CCKIJEALPFA GOLCDNNNGCF, [Optional] Dictionary<Guid, int> MIODJLDGGFB, [Optional] Guid? ILJCELOKLEB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA9BECAE8029CF3E", Offset = "0x0", VA = "0xA9BECB00029CF3E", Slot = "8")]
	Task<LMFFMMPMNDB<bool, string>> HJPHDINKHAL(Guid PCDMEBECPGE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29CF8D8029CF3E", Offset = "0x0", VA = "0x29CF8F0029CF3E", Slot = "9")]
	IEnumerable<LPJPIDNNHJB> CKNIDGHPLJJ();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29CF8D8A9BECCC", Offset = "0x0", VA = "0x29CF8F0A9BECCC", Slot = "10")]
	Task<List<KMNKJEHLBAA>> MMIMHBIPBEI(long FJBFONPAOAD, [Optional] CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA9BECDA8029CF95", Offset = "0x0", VA = "0xA9BECDC0029CF95", Slot = "11")]
	bool FKOHMKBAKEJ(Guid PCDMEBECPGE, [Out] LPJPIDNNHJB BEENNNIJNFD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29CFE48029CF95", Offset = "0x0", VA = "0x29CFE60029CF95", Slot = "12")]
	bool PPOKDNGJICM(Guid PCDMEBECPGE, int CPHJNCJLNCH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29CFEE8A9BECCC", Offset = "0x0", VA = "0x29CFF00A9BECCC", Slot = "13")]
	void FNHCGPOPDHN(JDJLHJHOJPN PEIJBHPINLD, Guid PCDMEBECPGE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA9BC60E8029D01A", Offset = "0x0", VA = "0xA9BC6100029D01A", Slot = "14")]
	Task<int> GNKGBCKAGNG(JDJLHJHOJPN PEIJBHPINLD, Guid PCDMEBECPGE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x29D02B8029D01A", Offset = "0x0", VA = "0x29D02D0029D01A", Slot = "15")]
	bool NCGPALEBJNJ();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29D02B8A9BEC10", Offset = "0x0", VA = "0x29D02D0A9BEC10", Slot = "16")]
	bool AOJDENGEOBM(Guid DIDFLDPPBOO, [Out] List<string> LGAFMEOGFEN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA9BEC228029D0C0", Offset = "0x0", VA = "0xA9BEC240029D0C0", Slot = "17")]
	Task<LMFFMMPMNDB<bool, string>> CAGBHJELIML(LPJPIDNNHJB BEENNNIJNFD, long ECGCPDICMDG, int HBPMKNLKLPD, [Optional] string AHOOEEOGGAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFLKMDJAPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29D1358029D0C0", Offset = "0x0", VA = "0x29D1370029D0C0", Slot = "0")]
	void DHOPHNBDFBP(Guid CDLPHHNJLBD, string AHOOEEOGGAJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29D1358A9BEC3C", Offset = "0x0", VA = "0x29D1370A9BEC3C", Slot = "1")]
	void EPDKMOLIGIC(Guid CDLPHHNJLBD, string AHOOEEOGGAJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA9BEC4A8029D188", Offset = "0x0", VA = "0xA9BEC4C0029D188", Slot = "2")]
	void BCDIJHBPGFN(Guid CDLPHHNJLBD, int HBPMKNLKLPD);
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

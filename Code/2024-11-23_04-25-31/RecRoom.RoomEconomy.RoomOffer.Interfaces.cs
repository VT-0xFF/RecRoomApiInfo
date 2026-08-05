using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LLGLKLDLHDM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	APNHDGDPKOI PIAIMOFIPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A548C802A53C5", Offset = "0x0", VA = "0x2A548E002A53C5", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A548C8A9C7634", Offset = "0x0", VA = "0x2A548E0A9C7634", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ABIBNEMCANM<KFEFKCGCBID> GBBIKGFCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA9C764E802A54DF", Offset = "0x0", VA = "0xA9C7650002A54DF", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A54E3802A54DF", Offset = "0x0", VA = "0x2A54E5002A54DF", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ABIBNEMCANM<Guid> CJMODBDEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A54E38A9C7660", Offset = "0x0", VA = "0x2A54E50A9C7660", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA9C764E802A5536", Offset = "0x0", VA = "0xA9C7650002A5536", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A5563802A5540", Offset = "0x0", VA = "0x2A5565002A5540", Slot = "6")]
	Task<OKPKCEBGDLD<KFEFKCGCBID, string>> CJCBDIBBGKC(long NPGHGEFGHLA, string JHJFHDOAMLG, string IGIOLLIFOOJ, string FHFCJEAFMJC, int NOMOMKEEIKH, CBDBLFLCAKJ LGNONGANKDO, [Optional] Dictionary<Guid, int> LBJLKLBNGJO, [Optional] Guid? FFOKKCGOKGN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A55638A962018", Offset = "0x0", VA = "0x2A55650A962018", Slot = "7")]
	Task<OKPKCEBGDLD<KFEFKCGCBID, string>> ELKPKMGAEAF(Guid CNNDEEBINDC, long NPGHGEFGHLA, string JHJFHDOAMLG, string IGIOLLIFOOJ, string FHFCJEAFMJC, int NOMOMKEEIKH, CBDBLFLCAKJ LGNONGANKDO, [Optional] Dictionary<Guid, int> LBJLKLBNGJO, [Optional] Guid? FFOKKCGOKGN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA9C6E12802A5620", Offset = "0x0", VA = "0xA9C6E14002A5620", Slot = "8")]
	Task<OKPKCEBGDLD<bool, string>> JHOCAAMENFG(Guid KLGKNBMEEHF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A566F802A5620", Offset = "0x0", VA = "0x2A5671002A5620", Slot = "9")]
	IEnumerable<KFEFKCGCBID> LIADBKCKFNO();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A566F8A9C6E30", Offset = "0x0", VA = "0x2A56710A9C6E30", Slot = "10")]
	Task<List<MGLIIBIJFBP>> PMHNOPMFPGG(long NPGHGEFGHLA, [Optional] CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA9C6E3E802A5677", Offset = "0x0", VA = "0xA9C6E40002A5677", Slot = "11")]
	bool HPACNKICJDE(Guid KLGKNBMEEHF, [Out] KFEFKCGCBID CBNBKKAHFGO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A56C6802A5677", Offset = "0x0", VA = "0x2A56C8002A5677", Slot = "12")]
	bool PABGNPGAOLM(string JHJFHDOAMLG, [Out] KFEFKCGCBID CBNBKKAHFGO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A56CE8A9C6E30", Offset = "0x0", VA = "0x2A56D00A9C6E30", Slot = "13")]
	bool ABDHGMMLFKD(Guid KLGKNBMEEHF, int CLDENMKBOGO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA7B9C36802A56F5", Offset = "0x0", VA = "0xA7B9C38002A56F5", Slot = "14")]
	void BGECIDOPLKC(OGOAPNICIIH JOCAMECBDHO, Guid KLGKNBMEEHF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A57A4802A56F5", Offset = "0x0", VA = "0x2A57A6002A56F5", Slot = "15")]
	Task<int> LHKEECANANN(OGOAPNICIIH JOCAMECBDHO, Guid KLGKNBMEEHF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A57A48A9C6F54", Offset = "0x0", VA = "0x2A57A60A9C6F54", Slot = "16")]
	bool HHAPIEAPHGE();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA9C6F6E802A57F7", Offset = "0x0", VA = "0xA9C6F70002A57F7", Slot = "17")]
	bool CDAPMFAHKDK(Guid PMAKHKBNMPF, [Out] List<string> HMKMALFKOJD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A57FB802A57F7", Offset = "0x0", VA = "0x2A57FD002A57F7", Slot = "18")]
	Task<OKPKCEBGDLD<bool, string>> OEHOGHCOENP(KFEFKCGCBID CBNBKKAHFGO, long GOMPJMKMNGF, int DIKJGKCBPOL, [Optional] string KELKGGAOEHK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CBHIPKFFGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A57FB8A9C6F80", Offset = "0x0", VA = "0x2A57FD0A9C6F80", Slot = "0")]
	void IOIEJOODJHE(Guid DNOHBMJKBLC, string KELKGGAOEHK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA9C6F6E802A584E", Offset = "0x0", VA = "0xA9C6F70002A584E", Slot = "1")]
	void PJBOAIBHOOD(Guid DNOHBMJKBLC, string KELKGGAOEHK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A5873802A5850", Offset = "0x0", VA = "0x2A5875002A5850", Slot = "2")]
	void NKNHDCEFIIO(Guid DNOHBMJKBLC, int DIKJGKCBPOL);
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

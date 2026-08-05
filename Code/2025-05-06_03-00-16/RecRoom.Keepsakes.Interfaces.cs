using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LGPCOINJNKM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BNEMALMGLKL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PLMIFFBKDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> JIBPBCEDKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> JKAEBEACIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> IOHLHGFCHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> BGBECICAOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HEFGLGGOLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> NLNEGJCOGOG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JEENIPIOEKD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PCCGMJOKNHF;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IBEBJNOMNOI([Optional] List<string> BBDAJAICAJA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KJPDFMLMKLI<Guid> FOHEPPNBCLG(CCAFHCPHPLB AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ELBPMMKABPA BGMELEBMFHB(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ELBPMMKABPA NBBFGFENLCC(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KGKMMBFNHCP(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CABMIKJHANA(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GEFIPJAJNFA(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PAIHPHNHAPE(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KGEMEMFFNEN(CCAFHCPHPLB AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AFLKDNJKHDI(Guid HNPAEJPLMGK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int DCGDALNALAJ();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KJPDFMLMKLI<int> FPLAHDAMEMD(long MDLDCACFGIB, long BOOHEBBJOLC, [Optional] CCAFHCPHPLB? AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KJPDFMLMKLI<int> NCJPCECPLMD(long MDLDCACFGIB, long BOOHEBBJOLC, [Optional] CCAFHCPHPLB? AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KJPDFMLMKLI<Dictionary<CCAFHCPHPLB, int>> ONGAGCDJOCJ(long MDLDCACFGIB, long BOOHEBBJOLC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KJPDFMLMKLI<Dictionary<CCAFHCPHPLB, int>> MMBLGAGCGEP(long MDLDCACFGIB, long BOOHEBBJOLC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KJPDFMLMKLI<IEnumerable<Guid>> AMGCKEBCFKJ(long MDLDCACFGIB, long BOOHEBBJOLC, [Optional] CCAFHCPHPLB? AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	KJPDFMLMKLI<IEnumerable<Guid>> IIPPNPFBGMD(long MDLDCACFGIB, long BOOHEBBJOLC, [Optional] CCAFHCPHPLB? AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string MLDMDEDGIHB(CCAFHCPHPLB AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string FLCKBPOANIH(CCAFHCPHPLB AKOLCMIIEMC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<CCAFHCPHPLB> ABNIIAKLBLG();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<CCAFHCPHPLB> BEJCCBFBFKK();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LONBBFLHHJH(long MDLDCACFGIB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool NDJDKNCBFOA(long MDLDCACFGIB);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ALIEFONLIIE(long IGGBKAEOJGI, [Out] DateTime ECKALDCGCPC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JPFFKAJJPAB(long IGGBKAEOJGI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long HGJJIBHDEFE(long CNDIPPCPBLM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int OLOHENMEFCP(long IGGBKAEOJGI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool IFHHECCBFBN();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool LLOFLANPFOF(long IGGBKAEOJGI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<long> PDLDKNGMCJH(long IGGBKAEOJGI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int IJPIEAIIGON(long IGGBKAEOJGI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string ENGPKFBPJON(JEDMBLJKFJC JEGIOIIBLHA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string MOPEGJGDKND(JEDMBLJKFJC JEGIOIIBLHA, int BBPHNLHGLLP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string JMLPJDMNLON(JEDMBLJKFJC JEGIOIIBLHA, long MDLDCACFGIB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long ICOAMAKIEDN(long MAGJEOKDHGO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	CCAFHCPHPLB OFLPOKJJGND();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HKCLMJONLNA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum ILPJNEGALAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool PGLNONNFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public ILPJNEGALAO? AAIPDOGOFGH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B692F0", Offset = "0x7B67AF0", VA = "0x187B692F0")]
	public HKCLMJONLNA(bool HOMBCGCLEFK, [Optional] ILPJNEGALAO? HHEKCMDBICH)
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

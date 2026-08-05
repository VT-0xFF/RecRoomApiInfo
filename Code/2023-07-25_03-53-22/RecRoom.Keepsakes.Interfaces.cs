using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct HLBEAIMBHDH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum PCADCKDOFAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool ILEKHALBIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PCADCKDOFAH? GMOHFBMDALC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x730F9D0", Offset = "0x730E9D0", VA = "0x18730F9D0")]
	public HLBEAIMBHDH(bool NDGDJBGGKMG, [Optional] PCADCKDOFAH? FGHFBGFHMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum COCDGGAIGCK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CPLICJDPDAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IHIADCMNCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> AGIMIJPNKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> ILPBMIDGPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> BIEKGDPJIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> AFJNAKEJMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MIMIDIHEENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> PJNNLGCIODC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BGFPHKLGEJI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ECOBKKFKODG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ACBMCCNLLMD([Optional] List<string> EKNEPGGNFJN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IBHBGBJGJHP<Guid> PAPEJPHDAKC(KMEGHOEMOEP EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GAEMIFNLIHB NKNGKCMKLEN(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GAEMIFNLIHB BDOILHALEJJ(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool EPINDOOFGFG(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HKJCHELCKFN(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OGJGPDHAGLG(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LGAPHKGINEB(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NMLLMIONCKP(KMEGHOEMOEP EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OMIBLLJOPFO(Guid LMKJBONLEIO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int GJIOBDBHCKP();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IBHBGBJGJHP<int> EBDPNPGCOBD(long IHGIEILPMCA, long OMDBFLIACPJ, [Optional] KMEGHOEMOEP? EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	IBHBGBJGJHP<int> FIKBECLJMNB(long IHGIEILPMCA, long OMDBFLIACPJ, [Optional] KMEGHOEMOEP? EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IBHBGBJGJHP<Dictionary<KMEGHOEMOEP, int>> CFNMBMFJLHK(long IHGIEILPMCA, long OMDBFLIACPJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IBHBGBJGJHP<Dictionary<KMEGHOEMOEP, int>> EGHFCECGDNK(long IHGIEILPMCA, long OMDBFLIACPJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IBHBGBJGJHP<IEnumerable<Guid>> LLCIGNAJDAF(long IHGIEILPMCA, long OMDBFLIACPJ, [Optional] KMEGHOEMOEP? EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	IBHBGBJGJHP<IEnumerable<Guid>> GNDABALJGDM(long IHGIEILPMCA, long OMDBFLIACPJ, [Optional] KMEGHOEMOEP? EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string BILGGBPPJFH(KMEGHOEMOEP EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string HAJIMKOFEHB(KMEGHOEMOEP EIIJKHEKNOL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<KMEGHOEMOEP> FHIOJFGNKMH();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<KMEGHOEMOEP> OKMGNIHBGLO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JIGIPHACGAN(long IHGIEILPMCA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool NAJFCGONEMK(long IHGIEILPMCA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OCDCIPBEKKP(long OFIAHIMEHLM, out DateTime BEGBNGFKMNK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long PGJHPJIPPEA(long OFIAHIMEHLM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long IKHAKHKDFJD(long FOFCKHDOLAD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int JAEPEHBAGBO(long OFIAHIMEHLM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool EMIEDELBPIJ();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool PNPFPMNHJNB(long OFIAHIMEHLM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> FEEANNHDHED(long OFIAHIMEHLM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int KHLCGINPEDI(long OFIAHIMEHLM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string JFGOKEGCKKM(ODJOEPELKMB NNEKLHKNGKH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string CGJIAJCPMLH(ODJOEPELKMB NNEKLHKNGKH, int EGCOIOBOFKN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string EOCPMFEKFGM(ODJOEPELKMB NNEKLHKNGKH, long IHGIEILPMCA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long DIDGFBICBFB(long GPDBHFNPFML);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	KMEGHOEMOEP GOMAAINKDPH();
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

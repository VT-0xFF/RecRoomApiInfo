using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct ILBJKOKJFAE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum NBCLMKIHNFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool CJFPGEJBJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public NBCLMKIHNFE? FGGEPHINPFA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x13AB8D0", Offset = "0x13AA4D0", VA = "0x1813AB8D0")]
	public ILBJKOKJFAE(bool HIFHKADBPMB, [Optional] NBCLMKIHNFE? EBAEDMOFJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OIMGCACEJLO
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DBLEGAFLABD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JPBNLLDFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> DLOHJCKKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> ONGIINNNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> PJPFDGEPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> MDJIAEEJCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LGHBAMFLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> DHLAHCFINBA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PLJHOKBCCKG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IJBEEFCONMK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LEEAOBELJPB([Optional] List<string> DOOOIMMJJJG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	global::NBFPPJGKGOH<Guid> DLECKKNFDNC(LNCLLEGDNJK PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EILHPPDHBHH GACFCBKBMLE(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EILHPPDHBHH GKFDGGAKIJN(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IHNACDMNHBO(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OKNLFICGAAJ(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IJJIJGKFIAM(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HFNPEKAKFJB(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JOGMDMAJIAI(LNCLLEGDNJK PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DCAHMBOCKPF(Guid NCDLOEBMMGD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int KMKIOHKONCF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	global::NBFPPJGKGOH<int> LKLGDPDJJBP(long HAMIEGOKEJC, long JEBGGHOLKHJ, [Optional] LNCLLEGDNJK? PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	global::NBFPPJGKGOH<int> ODKKCKLKDMP(long HAMIEGOKEJC, long JEBGGHOLKHJ, [Optional] LNCLLEGDNJK? PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> NFPPPLBCDGB(long HAMIEGOKEJC, long JEBGGHOLKHJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> GICMJGFPMKE(long HAMIEGOKEJC, long JEBGGHOLKHJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	global::NBFPPJGKGOH<IEnumerable<Guid>> NHMNMGCCMAL(long HAMIEGOKEJC, long JEBGGHOLKHJ, [Optional] LNCLLEGDNJK? PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	global::NBFPPJGKGOH<IEnumerable<Guid>> AFJEGDJGBGL(long HAMIEGOKEJC, long JEBGGHOLKHJ, [Optional] LNCLLEGDNJK? PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string HKLLNLDFMIL(LNCLLEGDNJK PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string KIPOFHGHGLO(LNCLLEGDNJK PIKCKAKDFFC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<LNCLLEGDNJK> EMOGDPLJOOF();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<LNCLLEGDNJK> PCAKCLMKPIH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool HMLMELBHIAK(long HAMIEGOKEJC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool EPFJFFOEGBE(long HAMIEGOKEJC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EPDEJPKEOLG(long IICNEKLODJO, out DateTime APGLPJPNNDF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long BGNAFFIAPPJ(long IICNEKLODJO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long DJEAJBELGFG(long HJFGKNKCKCB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int IHFBCDDDFBJ(long IICNEKLODJO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool NDHFIHBFJGM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool OEFGMKGGNDO(long IICNEKLODJO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> IEAMGJOFINO(long IICNEKLODJO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int DFDOPLMBKAA(long IICNEKLODJO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string ICEDGCPIHLL(ILGOKCMADDD KBKLBPALFEG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string GBGDGCEFKLC(ILGOKCMADDD KBKLBPALFEG, int DFIKHPGOHPI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string GGBCDMOLNDM(ILGOKCMADDD KBKLBPALFEG, long HAMIEGOKEJC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long NOGDJKELNAE(long JBHAABPKJOI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	LNCLLEGDNJK IGODJLINLGJ();
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

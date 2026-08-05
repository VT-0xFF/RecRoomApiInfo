using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GLLCMELBIBL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACAIJMDAAFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FDOKNLBEALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> PKGONMOIGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> POJEHJGMACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> ILGMJCNOODK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> PNPGIOBMPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NDBCHDGFINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> DFDDPIBCJLG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action APCDLBMBAFL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MPBCIFNEBGP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BLKFOLIDMCF([Optional] List<string> KBNJCICDCDG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MAKKFMNHCEA<Guid> AILJOLJLBAM(NIPPJGHMNJM CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OABICBNODGM FONBLHIAPML(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OABICBNODGM KJHOHFHBHHK(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AFAMNNEEHEM(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BAGMAPMMKJA(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FKCNDBIPDBH(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EGJMGMONFIF(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DJOLPNMMNJF(NIPPJGHMNJM CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CPCLLOOFIDL(Guid IMDIPHCNPIB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int NKHBADGJAFF();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	MAKKFMNHCEA<int> DLLCFJIMINJ(long DIMOGDCMBFM, long LHOFLPMECDE, [Optional] NIPPJGHMNJM? CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MAKKFMNHCEA<int> NILBCHLCJJF(long DIMOGDCMBFM, long LHOFLPMECDE, [Optional] NIPPJGHMNJM? CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MAKKFMNHCEA<Dictionary<NIPPJGHMNJM, int>> NNAENIBPDDH(long DIMOGDCMBFM, long LHOFLPMECDE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MAKKFMNHCEA<Dictionary<NIPPJGHMNJM, int>> IPADGEBMGJH(long DIMOGDCMBFM, long LHOFLPMECDE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MAKKFMNHCEA<IEnumerable<Guid>> KJNLEHOLGCM(long DIMOGDCMBFM, long LHOFLPMECDE, [Optional] NIPPJGHMNJM? CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MAKKFMNHCEA<IEnumerable<Guid>> FMGEABHDEJK(long DIMOGDCMBFM, long LHOFLPMECDE, [Optional] NIPPJGHMNJM? CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string BBHBDAJGIMG(NIPPJGHMNJM CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string AMBIDAEBJCE(NIPPJGHMNJM CKOCGIMJNAL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<NIPPJGHMNJM> BBJPAOMEKNI();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<NIPPJGHMNJM> ODDMOKDDPEK();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PNKNCCPLMNJ(long DIMOGDCMBFM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool FPDOHMKAMIA(long DIMOGDCMBFM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool LABFICPPFHH(long NHEPHCHPDPG, [Out] DateTime GOHMLEJMCNG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long OGFNLDJPMPP(long NHEPHCHPDPG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long GGOFKFIFAGF(long HOIDFCAAOJC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int BIJLAFLDABG(long NHEPHCHPDPG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool DHAAHCMNAAB();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool GCFDDIHPPKI(long NHEPHCHPDPG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> NNBFEJPDPHP(long NHEPHCHPDPG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int MJGPLJJOBPH(long NHEPHCHPDPG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string KHENDBAFMLA(JJIHCOELGBI CCOBLPDODEC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string BCLPANLBJNA(JJIHCOELGBI CCOBLPDODEC, int MDBJELDBDPH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string GPFAIMPNAIB(JJIHCOELGBI CCOBLPDODEC, long DIMOGDCMBFM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long FAKPEIJKLPO(long PLFJDMDPJEE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	NIPPJGHMNJM KKHIAKOHHDP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BNLNICPGHEH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum OJIPPNCLNMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool BABGILMOJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public OJIPPNCLNMM? KLBEKEOEEMA;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6900370", Offset = "0x68FEB70", VA = "0x186900370")]
	public BNLNICPGHEH(bool JEDMGNPHHLC, [Optional] OJIPPNCLNMM? DAGHANOLKBJ)
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

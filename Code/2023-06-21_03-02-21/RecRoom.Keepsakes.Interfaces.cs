using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct CBGCLGFAHPN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum HJMFBFDCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool AKOEKJMPGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public HJMFBFDCGOH? FJJNAANFJHJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x15AE8E0", Offset = "0x15ADAE0", VA = "0x1815AE8E0")]
	public CBGCLGFAHPN(bool MOMEMJFIEIG, [Optional] HJMFBFDCGOH? OIHOLIFAPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GGFAMGENPMA
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HCHPEGJPAGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJCAOOKOPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> APEBIBMGCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> AEBELICMANA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> OADOLOIKDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> HBKKMGEPPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NOOLEFGLLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> CCLJECEMGLO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GBJBLIGGKHP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DOBKHNAEPNN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JKGEDPNHEJG([Optional] List<string> IPLMAEDGHKL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NHJDNADPIAN<Guid> HDPEOMBAEJP(PIHCLHIKEPH HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OOPPNGPPPLE OONKAMKGBCE(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OOPPNGPPPLE BNMEPDCNLLM(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LMBLDPACBAO(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EFOOBAIBIJH(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NKNCMGJMDFF(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HKIHFFOEMPE(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HIPAKOACLFK(PIHCLHIKEPH HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OHCGEPKEIND(Guid JANCGILILJA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int FBNLCDHDEPN();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NHJDNADPIAN<int> AHKJKOGJJGM(long LNBFDCAEKJF, long MJHHGLBGJNF, [Optional] PIHCLHIKEPH? HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NHJDNADPIAN<int> CCNIAABDIIK(long LNBFDCAEKJF, long MJHHGLBGJNF, [Optional] PIHCLHIKEPH? HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NHJDNADPIAN<Dictionary<PIHCLHIKEPH, int>> NABJDJLJMGN(long LNBFDCAEKJF, long MJHHGLBGJNF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NHJDNADPIAN<Dictionary<PIHCLHIKEPH, int>> ADHNPKNEKII(long LNBFDCAEKJF, long MJHHGLBGJNF);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NHJDNADPIAN<IEnumerable<Guid>> AEFLEIJHNEN(long LNBFDCAEKJF, long MJHHGLBGJNF, [Optional] PIHCLHIKEPH? HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NHJDNADPIAN<IEnumerable<Guid>> HPCJNCMCNEB(long LNBFDCAEKJF, long MJHHGLBGJNF, [Optional] PIHCLHIKEPH? HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string EGDBMGNDHDJ(PIHCLHIKEPH HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string CGOIAPHIHED(PIHCLHIKEPH HPMPEKNNPND);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<PIHCLHIKEPH> LPMJGCCFHAI();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<PIHCLHIKEPH> HCCAMDANEJK();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PPCOEGPIJOH(long LNBFDCAEKJF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool INNDKALCBAB(long LNBFDCAEKJF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool IGPJJLOOEKN(long FEMOKOOLCNN, out DateTime MPOBPBONKOG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JONPIABKOAC(long FEMOKOOLCNN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long PIOBGOMNHPK(long HBPFICPPGKB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int KONPJEIBNBP(long FEMOKOOLCNN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool IFGCGCKKNBE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool IGEKIDHHAOC(long FEMOKOOLCNN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> GAEIDDJKCIE(long FEMOKOOLCNN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int FPEIKBJBHDL(long FEMOKOOLCNN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string JKPEOCFFEIN(CBIIPFAPOKF NACCHDDNOJG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string PCILGPFEJDF(CBIIPFAPOKF NACCHDDNOJG, int HKBOKBNIMKL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string CKJLIILJPAA(CBIIPFAPOKF NACCHDDNOJG, long LNBFDCAEKJF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long PCGCOAHLPGK(long CPPDOOCKKGH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	PIHCLHIKEPH DOFEBOGACMA();
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

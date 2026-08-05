using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct EABOONIFPHF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum KPAPJJHLBDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool KCCPGGKBJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public KPAPJJHLBDC? DCLFKEAIDMF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1714990", Offset = "0x1713D90", VA = "0x181714990")]
	public EABOONIFPHF(bool JPEMBNOGANL, [Optional] KPAPJJHLBDC? LHBOIKFNJBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JLGKDNBEBMC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KMDGAKGFJAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HPDLHDMPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> LKCIIDHMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> JOPMNKHMDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> MDDIGLOHBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> CPHNNLADAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JEBDFKKHNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> NMIBBBPDPKB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action INLHHGCHLPG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JKHEHDAOILP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MJMDBLMHBJL([Optional] List<string> DJJEHKONEHH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	global::CBFHNKNAJIN<Guid> EOLALOCIOFA(CCLDPBPGLEA EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FKADHPEOOEO EDCLCCINBFE(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FKADHPEOOEO CDIACKDFAND(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MDKMKHJAJLA(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PJHBFFDPJLB(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool MBBFDLHCJNB(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DOKELNCFDPA(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JLILDBJDFNP(CCLDPBPGLEA EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BIGFJOMDGMC(Guid NLEOMGLIGJK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int OPENFGOHFAB();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	global::CBFHNKNAJIN<int> NBFEMLFOCGB(long MEFEJANAPKD, long NOAKJPLALPD, [Optional] CCLDPBPGLEA? EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	global::CBFHNKNAJIN<int> CJGPKIHFPJP(long MEFEJANAPKD, long NOAKJPLALPD, [Optional] CCLDPBPGLEA? EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::CBFHNKNAJIN<Dictionary<CCLDPBPGLEA, int>> CHKOGGKDOEK(long MEFEJANAPKD, long NOAKJPLALPD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	global::CBFHNKNAJIN<Dictionary<CCLDPBPGLEA, int>> PHDCJFJIBMN(long MEFEJANAPKD, long NOAKJPLALPD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	global::CBFHNKNAJIN<IEnumerable<Guid>> ALGLMJMLBIB(long MEFEJANAPKD, long NOAKJPLALPD, [Optional] CCLDPBPGLEA? EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	global::CBFHNKNAJIN<IEnumerable<Guid>> FKLIBHAKDFL(long MEFEJANAPKD, long NOAKJPLALPD, [Optional] CCLDPBPGLEA? EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string CCFBMCIGLAI(CCLDPBPGLEA EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string BFCAAMKBBOI(CCLDPBPGLEA EIJDJFDKAHK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<CCLDPBPGLEA> JLGFKKINGHM();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<CCLDPBPGLEA> KIMDKABFMPD();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LAGAMMKFHPM(long MEFEJANAPKD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool ALDMGGMFLKD(long MEFEJANAPKD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NIGIHPNCHAA(long BBKGLINHPNM, out DateTime HKGIMIJBPKB);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JEHMKBFLLEI(long BBKGLINHPNM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long NILNNBEPANM(long IIELFNAFKCE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int DJLLBBFACMP(long BBKGLINHPNM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool FAIKCHOPPLD();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool JPBFJHNPPEM(long BBKGLINHPNM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> AJFJDKJFGDJ(long BBKGLINHPNM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int JFFNFFEGPKC(long BBKGLINHPNM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string EANBIFPKFNJ(GCOMPMIMPAJ CAFKDKOGOOK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string MLFMCOHODIP(GCOMPMIMPAJ CAFKDKOGOOK, int CIPLHMJOGGF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string CPLJCMKNAOO(GCOMPMIMPAJ CAFKDKOGOOK, long MEFEJANAPKD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long EICPEEPDDMC(long CAIPJDCBIME);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	CCLDPBPGLEA PIMABPBMAJN();
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

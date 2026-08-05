using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct EKFLAMAKKCI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum EPBKAABONED
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool GMBNNGAOLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public EPBKAABONED? KOIKGFKOIKP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F31990", Offset = "0x6F30190", VA = "0x186F31990")]
	public EKFLAMAKKCI(bool KOFFKNLBDFJ, [Optional] EPBKAABONED? DIEFGOFMNJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EBMIIJENMDF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FDJMJPOBBAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BPOPBHDFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> DIGPGEFBFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> IADAOGOLAED
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> PEAEAHGPEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> OJBJBAFALPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KNGCEHKAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> LFGGGLCBHFN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NBONNKJHDJO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ALNMAKCNKJK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OCMPNOAPKEN([Optional] List<string> OGBPPOFHCGD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JJMNNLLBAJO<Guid> NLDMCFBGICC(HILCHEIPPND OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GHJKEMFHLHG KKBBJGAHPIB(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GHJKEMFHLHG LIBAGKJAJAM(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MCDGGKELPCP(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FNNBBLBFPKJ(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LCCANNMFLCB(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EDJCILLCNFB(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LPKDMFACAPF(HILCHEIPPND OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BBKCEBEJPBH(Guid LKGGLHIONPO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int NIELHBNOBHH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JJMNNLLBAJO<int> LPNMNIHLGNP(long AFGKPOPONBN, long MLFPNCDFMFB, [Optional] HILCHEIPPND? OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JJMNNLLBAJO<int> IHAJOMBLKLM(long AFGKPOPONBN, long MLFPNCDFMFB, [Optional] HILCHEIPPND? OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JJMNNLLBAJO<Dictionary<HILCHEIPPND, int>> FAPDJEPEIIA(long AFGKPOPONBN, long MLFPNCDFMFB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JJMNNLLBAJO<Dictionary<HILCHEIPPND, int>> BOAPCOOHPJO(long AFGKPOPONBN, long MLFPNCDFMFB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JJMNNLLBAJO<IEnumerable<Guid>> PMHJOPAAKFO(long AFGKPOPONBN, long MLFPNCDFMFB, [Optional] HILCHEIPPND? OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	JJMNNLLBAJO<IEnumerable<Guid>> IDDBHCIPMGC(long AFGKPOPONBN, long MLFPNCDFMFB, [Optional] HILCHEIPPND? OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string DMLBLCGPPOD(HILCHEIPPND OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string BKKGMHHJLKL(HILCHEIPPND OBPJKIHHCKA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<HILCHEIPPND> DLFBPJMLMDH();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<HILCHEIPPND> PELNICIFEJE();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool IEDNGAJCICP(long AFGKPOPONBN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool CLJFDKDCMJK(long AFGKPOPONBN);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NJHELEGOLNA(long LNJPMMGCLEE, out DateTime PKGOOCDADMP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long ADMHMPACKDB(long LNJPMMGCLEE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long ANENOMIKNLO(long PALEFKCDMIE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int KMEKFEBOOGJ(long LNJPMMGCLEE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool KDCIEDNCGPH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool INGKGCCKLJN(long LNJPMMGCLEE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> OELMCJDHFHC(long LNJPMMGCLEE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int HIMHBPDHHFA(long LNJPMMGCLEE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string HKLGMAINFEL(NDHHBPMHGPL PBFJMMIHAAA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string FFICIEEBKPP(NDHHBPMHGPL PBFJMMIHAAA, int CEMIGKDJPLB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string OAJNBFDJGOM(NDHHBPMHGPL PBFJMMIHAAA, long AFGKPOPONBN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long LKNIDCPAOKO(long ELEBFIAHDOE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	HILCHEIPPND OALDFDFAGON();
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

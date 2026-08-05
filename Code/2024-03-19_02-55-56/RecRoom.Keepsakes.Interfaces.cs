using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CHAGLEMINPC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BPEEKCLPMIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KODMEBKALPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> CCODJOFNGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> IMMKGPLPPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> GMPAFOKPOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> HLJJEFOJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool APJEKHAEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> AEKKPKENJAL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IIFGAMNKJOJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OJDDBLPJCHB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ENBPJOMDFEC([Optional] List<string> PFFLMEFOGCK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BJNFJNCLHKJ<Guid> NCEDOCCCLDJ(HNLAOBHNGAL MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NCJNDIGDIHF GBPOEBMNMJB(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NCJNDIGDIHF MJLENJOEHNE(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KIMNJDPODKP(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LPAGHBHIODI(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool EKKEOHJFLPC(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ACJLDJPOFGE(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IBGMPBOHOJK(HNLAOBHNGAL MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LAPCHHJGEGF(Guid AHLCAKLIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int OOHKLHOKFKN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BJNFJNCLHKJ<int> GMEFONJLIJB(long INFPDCJCIBN, long NJNEEFBILPP, [Optional] HNLAOBHNGAL? MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BJNFJNCLHKJ<int> FFKDHIGLIOO(long INFPDCJCIBN, long NJNEEFBILPP, [Optional] HNLAOBHNGAL? MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BJNFJNCLHKJ<Dictionary<HNLAOBHNGAL, int>> EMGJGDOHCAH(long INFPDCJCIBN, long NJNEEFBILPP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BJNFJNCLHKJ<Dictionary<HNLAOBHNGAL, int>> LNKMJFBGILF(long INFPDCJCIBN, long NJNEEFBILPP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BJNFJNCLHKJ<IEnumerable<Guid>> NBHNOENDNBG(long INFPDCJCIBN, long NJNEEFBILPP, [Optional] HNLAOBHNGAL? MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BJNFJNCLHKJ<IEnumerable<Guid>> ELLNDCJFIMB(long INFPDCJCIBN, long NJNEEFBILPP, [Optional] HNLAOBHNGAL? MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string MHEPEHBIBDF(HNLAOBHNGAL MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string ICPDJEPPEGM(HNLAOBHNGAL MPJODJODHKN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<HNLAOBHNGAL> EFPHOJKDDIC();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<HNLAOBHNGAL> JGCDENMMJAC();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool KMDGIBNDBPA(long INFPDCJCIBN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool ALIHEGLJJKI(long INFPDCJCIBN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OGEDDDPHGDJ(long LDIFHHJAIMG, [Out] DateTime OAAHAKMHCNJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long KJPBFMGHLEL(long LDIFHHJAIMG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long PHNMGNGALID(long CIOCLBBJILJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int FIDPMILBPFG(long LDIFHHJAIMG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool BNMNHMGJAFL();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool GMOJNFIBJDI(long LDIFHHJAIMG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> ABKHEEBIHOP(long LDIFHHJAIMG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int PBCEDHPFIIB(long LDIFHHJAIMG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string LLAFMGNEOHH(LFPBPOLDEPE GNICBNKFKEJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string BBDEBOAKFEE(LFPBPOLDEPE GNICBNKFKEJ, int BEGMKHGDGNN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string MOILOBCNDMF(LFPBPOLDEPE GNICBNKFKEJ, long INFPDCJCIBN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long NDANGBKMOGJ(long KAANGIJOEDM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	HNLAOBHNGAL JHHMAOCFOGI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JFHOCJEFEGF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum PGMOLAPEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool KCOLDEMJDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public PGMOLAPEFJI? JACBHINHAEO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61B3E50", Offset = "0x61B2E50", VA = "0x1861B3E50")]
	public JFHOCJEFEGF(bool IAGPAOINGHK, [Optional] PGMOLAPEFJI? KONCEHKHGII)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LNKCCJMOOCN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IALAHAHMGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MDBLAKNBJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> FOPIOHPKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> PFBLGEMEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> MEKMHNNCMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> HCNLDEACPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IFFODBHDCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> FPIJLHNKIKC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ELHOMCKFJPE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OGILHAKOJFH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FIFLGKIEBPN([Optional] List<string> EELFKCCEFDA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JNFFOANFOAP<Guid> HPPNKEPGJPF(EIOCNLPONOP DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PEMLHLMJEJH IOGEFAFKOJB(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PEMLHLMJEJH PIAGFMHILBI(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JJANJGGOJAH(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EKOPECIHBEB(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OBDEIKJMMEG(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MLHKHOAPPON(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DOJHKBHEPHC(EIOCNLPONOP DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PMCCLPCHDHG(Guid MIPKJNCHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int DDOMJMKAKNM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JNFFOANFOAP<int> EOPIHONKCNL(long NIJFNKBIOIC, long KMOOFGBNAOG, [Optional] EIOCNLPONOP? DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JNFFOANFOAP<int> CHEELOHPMGD(long NIJFNKBIOIC, long KMOOFGBNAOG, [Optional] EIOCNLPONOP? DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JNFFOANFOAP<Dictionary<EIOCNLPONOP, int>> BKPENAKHGBK(long NIJFNKBIOIC, long KMOOFGBNAOG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JNFFOANFOAP<Dictionary<EIOCNLPONOP, int>> NIGGNBDAFLD(long NIJFNKBIOIC, long KMOOFGBNAOG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JNFFOANFOAP<IEnumerable<Guid>> PKJOLFFMCIP(long NIJFNKBIOIC, long KMOOFGBNAOG, [Optional] EIOCNLPONOP? DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	JNFFOANFOAP<IEnumerable<Guid>> BCGFHOLDBKN(long NIJFNKBIOIC, long KMOOFGBNAOG, [Optional] EIOCNLPONOP? DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string KFFBEMBLPKE(EIOCNLPONOP DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string GNKPMBBCBAO(EIOCNLPONOP DLIABPPAJGJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<EIOCNLPONOP> NNJGFKGLJOH();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<EIOCNLPONOP> HLBBLEJGKFA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LEMIPKOOMAH(long NIJFNKBIOIC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool MNLCMEBJEOK(long NIJFNKBIOIC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NDNDKLMFCHD(long DPMPAIBMPNJ, [Out] DateTime MACPBEDLGML);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long AIOGGKKHBOL(long DPMPAIBMPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long MPGMAGPEDLH(long AONCNCCFDCJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int PPNNGOBNOIF(long DPMPAIBMPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool INONOCCIDHP();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool PHMAJHLLCML(long DPMPAIBMPNJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> MOOKBFJCGMK(long DPMPAIBMPNJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int JKAOLFPGJHF(long DPMPAIBMPNJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string NGJOIGFHIPA(OFGJLJGOIJH KNNHCJOOIML);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string PHODDGNBOMH(OFGJLJGOIJH KNNHCJOOIML, int EKOGBAMEHCN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string HGJJJHOAPDD(OFGJLJGOIJH KNNHCJOOIML, long NIJFNKBIOIC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long CABFFDDNJAB(long ODBMBBAJJLC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	EIOCNLPONOP DNLDLKNKEOD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GEHJIKFOCLO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum CMOAEAMBDPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool IICGHIBDBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public CMOAEAMBDPB? GIFFEEDPNPF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61DF500", Offset = "0x61DE900", VA = "0x1861DF500")]
	public GEHJIKFOCLO(bool EEFKJALFOCH, [Optional] CMOAEAMBDPB? AELHCIIJHCI)
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

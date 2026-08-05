using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KKNECKBIAGF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IDBFMLEOKFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JONFAACMCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> BGEMPNDBGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> HCMLFIIMIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> BJGGECJOKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> LONKCHOJEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HOAJHMDAOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> FDOCMIFJJEG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NCCKBKKNOEE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JFBEIMNGOCA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CMFCPDHBOIF([Optional] List<string> LKHDCMDGFDI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GKAGCLBDDCM<Guid> AHBFDCGIFBH(MHFCDHEHNAN HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IIJBCHKFBNI EJDNEDAPECC(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IIJBCHKFBNI LCAFMLBNICC(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OCJFICODDCE(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KOLMBCAJIDB(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LCGCFEDPDLD(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GPCMLEEPADC(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NCMDNEDPIBK(MHFCDHEHNAN HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LJAAOPJEPNN(Guid JKBCBKNFNIG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int DJLCHBLAKEN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GKAGCLBDDCM<int> GFHMMCNIEEL(long KKFMPNCGPKO, long NCNOEDACGAC, [Optional] MHFCDHEHNAN? HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	GKAGCLBDDCM<int> NAKFNEKAPKJ(long KKFMPNCGPKO, long NCNOEDACGAC, [Optional] MHFCDHEHNAN? HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GKAGCLBDDCM<Dictionary<MHFCDHEHNAN, int>> LLGGMNIAJMO(long KKFMPNCGPKO, long NCNOEDACGAC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GKAGCLBDDCM<Dictionary<MHFCDHEHNAN, int>> EOMPDCNEFMN(long KKFMPNCGPKO, long NCNOEDACGAC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GKAGCLBDDCM<IEnumerable<Guid>> BOFIFBMKNJO(long KKFMPNCGPKO, long NCNOEDACGAC, [Optional] MHFCDHEHNAN? HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	GKAGCLBDDCM<IEnumerable<Guid>> KFBONHEEDPG(long KKFMPNCGPKO, long NCNOEDACGAC, [Optional] MHFCDHEHNAN? HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string DEOFDFEAADO(MHFCDHEHNAN HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string KKDFNFDJIAK(MHFCDHEHNAN HKIILMNBMEC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<MHFCDHEHNAN> PNMJIAGMBLN();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<MHFCDHEHNAN> GKHCLKNFOOC();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JABOFOIONHG(long KKFMPNCGPKO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool BEEPKIPEKOG(long KKFMPNCGPKO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EJBNJLCIKOE(long HFJOPFAGDCI, [Out] DateTime KBFELELNMLE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long AIJJFKNCFOA(long HFJOPFAGDCI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long HJAEPMBOHEH(long LMAOJHOFDAB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int JEBCDGLOPKB(long HFJOPFAGDCI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool FFKDPNCLNCD();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool DEAHNNIGIDC(long HFJOPFAGDCI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> CPKPHKNIMCF(long HFJOPFAGDCI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int PDCBBFADBND(long HFJOPFAGDCI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string FPAPIIKGFAI(PHFFNLPKFLI NKLPBKCLOKO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string IOEIHFEAOCH(PHFFNLPKFLI NKLPBKCLOKO, int KNDOIPMHDAO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string HEJJEEBLCFK(PHFFNLPKFLI NKLPBKCLOKO, long KKFMPNCGPKO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long ECDIJAOGOML(long PLMHPCBCDID);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	MHFCDHEHNAN GNIHDOPCENN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FEPECIEJBFO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum LFDJEKMOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool DEKGFKOPBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public LFDJEKMOHKB? NHJIHGGNJHF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x609A270", Offset = "0x6099670", VA = "0x18609A270")]
	public FEPECIEJBFO(bool IGDABCIGHJM, [Optional] LFDJEKMOHKB? MFLFCMPGDIH)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HNHINHDLGHM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NKOPLKBCBHN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GPHDADNBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> GMDHBIAAJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> MEBCPDPMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> HDNOBIJEPKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> DCKCBGAGKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NPJFMOBNCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> NMCEDEGNFFN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IFGNHOJLIPK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ELCIPCDALKL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IBBMGDLHIDE([Optional] List<string> DOMAEGHOIFI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KGAPFDAFEHM<Guid> CBBAGMCFADN(AFACIFHCNFE HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HPIGCMLNLFB OOKKLLFFHHB(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HPIGCMLNLFB DGIEHHIBNHN(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KCIHHGPDIPG(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FJCHHOLFEHN(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool HFMHJOKKBNO(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KOOENPJKLND(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LABPHLPNBGM(AFACIFHCNFE HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OAKGNPCBDEL(Guid JMMICACHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int JJAMMPPCNIA();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KGAPFDAFEHM<int> HMOOFKNMDEG(long CINEDGEJAIA, long FMIBHJAGMML, [Optional] AFACIFHCNFE? HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KGAPFDAFEHM<int> GIKBMDOIEBH(long CINEDGEJAIA, long FMIBHJAGMML, [Optional] AFACIFHCNFE? HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> GAKLEELILCF(long CINEDGEJAIA, long FMIBHJAGMML);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> KNAPILKEBKG(long CINEDGEJAIA, long FMIBHJAGMML);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KGAPFDAFEHM<IEnumerable<Guid>> FNJDKOMMEDN(long CINEDGEJAIA, long FMIBHJAGMML, [Optional] AFACIFHCNFE? HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	KGAPFDAFEHM<IEnumerable<Guid>> CAMDHOLMIIO(long CINEDGEJAIA, long FMIBHJAGMML, [Optional] AFACIFHCNFE? HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string DMMHNIIOGNE(AFACIFHCNFE HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string MBNPJOJFEFL(AFACIFHCNFE HCKJHIJFJHB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<AFACIFHCNFE> BKBPFKAAOAP();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<AFACIFHCNFE> OBOIJEABHLM();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MPKOKCOBPGN(long CINEDGEJAIA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool KIDMMMNJBKG(long CINEDGEJAIA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OHDLCKOLKLK(long LEFNFFBHJLH, [Out] DateTime PCOPOHCFOEK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long CIPNDKFOHMO(long LEFNFFBHJLH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long KLJDKKKJPMN(long NOPNHMAKDDC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int IMLPCICOANG(long LEFNFFBHJLH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool EJLAOEGCPAO();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool HICOLJJMCJD(long LEFNFFBHJLH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<long> OJDGLONCKHN(long LEFNFFBHJLH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int LFOFCFKLNCI(long LEFNFFBHJLH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string PJOLPNLHCHD(KFHGHFECODO EFDNENPKLBL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string IBNONOAANNC(KFHGHFECODO EFDNENPKLBL, int BBHCPOJFPGN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string GBJCBBBHNEI(KFHGHFECODO EFDNENPKLBL, long CINEDGEJAIA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long AAEOKOGAAMB(long NBJFEGFELAB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	AFACIFHCNFE HNNDJMBLIDL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HBIEODGBPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IFPNLJIGFAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool LKCLHBEDNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IFPNLJIGFAP? MKNJGPOHDKC;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5200", Offset = "0x7CA4200", VA = "0x187CA5200")]
	public HBIEODGBPJP(bool GHDMMGHHCHI, [Optional] IFPNLJIGFAP? BBLALKGPAPJ)
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

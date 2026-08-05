using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HPOHBKNCION
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FCFLAHCLCOE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CDIDFMOBMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> DLMKLIHNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> PHFCJBOFJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> GIGNBKDCBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> DBDDPPKMMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HBHPCHNIMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> CPLPIMOPJIH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NCEDAFIKCEN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DFNLMJDIGNL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KCKGELKPHOC([Optional] List<string> GINAAIAHMHO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	global::DJAOLOOILHN<Guid> LCBNMOGANIG(CJFKFPHLBGA KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OFEHPCFKLFI JFKPECMAABI(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OFEHPCFKLFI IDJMDOLEPFI(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool EMBFMEBJKLN(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BLHPDKADPON(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LOKHBGHMGLK(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OGNPBJLKGBO(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OKMEHDMDIDE(CJFKFPHLBGA KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HEINMDPNEPP(Guid EBLAFADKOLC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int BJGFPJKIPIK();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	global::DJAOLOOILHN<int> PDBPFHIAKCB(long GPCCPBNNCAG, long AKANJBGBLEM, [Optional] CJFKFPHLBGA? KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	global::DJAOLOOILHN<int> FBNPOGBNMGG(long GPCCPBNNCAG, long AKANJBGBLEM, [Optional] CJFKFPHLBGA? KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::DJAOLOOILHN<Dictionary<CJFKFPHLBGA, int>> DFJGHFJAAOO(long GPCCPBNNCAG, long AKANJBGBLEM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	global::DJAOLOOILHN<Dictionary<CJFKFPHLBGA, int>> OKKMLBENOMF(long GPCCPBNNCAG, long AKANJBGBLEM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	global::DJAOLOOILHN<IEnumerable<Guid>> DODMMGAIBPO(long GPCCPBNNCAG, long AKANJBGBLEM, [Optional] CJFKFPHLBGA? KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	global::DJAOLOOILHN<IEnumerable<Guid>> AHJAHDBEBEN(long GPCCPBNNCAG, long AKANJBGBLEM, [Optional] CJFKFPHLBGA? KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string NEBNDDGBJJH(CJFKFPHLBGA KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string NKBOOBDHKDC(CJFKFPHLBGA KLPICBBCBEB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<CJFKFPHLBGA> HAJAGDPIFHM();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<CJFKFPHLBGA> NAKDAPICIKG();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool CEOMIDMDAFA(long GPCCPBNNCAG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool DJBKGFFMCEN(long GPCCPBNNCAG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EDCBNOKOIBB(long LDCIADOLPPD, out DateTime BFJOAGEGGAE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long MIOECLOBJLK(long LDCIADOLPPD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long DDNKDOKDJFH(long PBMPBPOPOCH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int LFKDDBOKLDL(long LDCIADOLPPD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool DJEHACENFEJ();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool BJALOLJAPBP(long LDCIADOLPPD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> LJPDPEMLCNE(long LDCIADOLPPD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int AGIGKBDALNB(long LDCIADOLPPD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string LDEIIEBJDDF(ADPLFNDBLHL IHEHFHENADJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string KLPPPKPBEOB(ADPLFNDBLHL IHEHFHENADJ, int MNGHBLPEACJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string HCHCGDGJIBG(ADPLFNDBLHL IHEHFHENADJ, long GPCCPBNNCAG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long MNAADBJAJHH(long NPNNGINBAPF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	CJFKFPHLBGA PMMDMHJFPCI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LFJHBAPJOEC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum BKLPGOMGKNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool IJBDJFNJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public BKLPGOMGKNE? AHOBCKALCIJ;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C710", Offset = "0x1E7B110", VA = "0x181E7C710")]
	public LFJHBAPJOEC(bool EOPPOHDFHDF, [Optional] BKLPGOMGKNE? ODJHDLEEHAN)
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

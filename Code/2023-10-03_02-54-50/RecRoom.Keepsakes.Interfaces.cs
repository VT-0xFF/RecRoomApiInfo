using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DDILGEBCCLC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ADFHGHMLBHI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BOMODALCFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> BLNODINNPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> PABPEDDPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> AOKPMLLOBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> EKIFOACKOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NFKNDFNNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> BFHDNMIJAOA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PBCMJGDCEEG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MJNFIJKHPDC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KAHLCGPAIMH([Optional] List<string> DOOEOEMMCBK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FNFCBJEHDPL<Guid> GIAGIACPKLI(NJFKBBPNNAP DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DFJLMOHJECJ CEAELKKCIGF(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DFJLMOHJECJ KPEFHMBOKNJ(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AOOHDFGMCNO(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HEMCICFKEEI(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool AIMFGFCBLEA(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AMEFOODLCOB(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MGHBONCJMFL(NJFKBBPNNAP DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DOEGLECDPAF(Guid KNBGMNMIJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int LCFDGPNKDDK();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FNFCBJEHDPL<int> HAJADKMOFJI(long EJLCNJNHKAA, long ENLIPOMDFFC, [Optional] NJFKBBPNNAP? DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	FNFCBJEHDPL<int> HDAGAOGHMMH(long EJLCNJNHKAA, long ENLIPOMDFFC, [Optional] NJFKBBPNNAP? DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FNFCBJEHDPL<Dictionary<NJFKBBPNNAP, int>> BMLPFKBENDM(long EJLCNJNHKAA, long ENLIPOMDFFC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FNFCBJEHDPL<Dictionary<NJFKBBPNNAP, int>> BNLLGNANJFE(long EJLCNJNHKAA, long ENLIPOMDFFC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FNFCBJEHDPL<IEnumerable<Guid>> OCHPAMCOLKA(long EJLCNJNHKAA, long ENLIPOMDFFC, [Optional] NJFKBBPNNAP? DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	FNFCBJEHDPL<IEnumerable<Guid>> FDBAKBDNGNP(long EJLCNJNHKAA, long ENLIPOMDFFC, [Optional] NJFKBBPNNAP? DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string LEALJKOOPEF(NJFKBBPNNAP DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string AAMEPFJOEAA(NJFKBBPNNAP DJPOOJOPCCK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<NJFKBBPNNAP> EIGNLJIIEMN();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<NJFKBBPNNAP> JDKOPKDJFAM();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool DKPGDMONMDE(long EJLCNJNHKAA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HIIMOMEINLM(long EJLCNJNHKAA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool AADICILDDND(long NMOGKLFIANK, [Out] DateTime HAEMLHHDJPA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long KCJAFKGMFDF(long NMOGKLFIANK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long MDBDCHOKHAD(long OHOCIHENNPF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int KONKHCLDFKG(long NMOGKLFIANK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool PKBCJOANPDE();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool HDDECDPOILM(long NMOGKLFIANK);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> IHPFJKEBNPA(long NMOGKLFIANK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int FCFJKGFKOKI(long NMOGKLFIANK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string IJAMODLAJOG(AAGMCIHPOLM KONJDKHDPBP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string FEOAGAIEIIP(AAGMCIHPOLM KONJDKHDPBP, int EFLMPCCIEBA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string BEPKEMEOGPJ(AAGMCIHPOLM KONJDKHDPBP, long EJLCNJNHKAA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long EDGALCGDAKB(long KLEKPCDENJA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	NJFKBBPNNAP JGLMCOBLILO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LLLGDJEIFOI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IIHMMKNABCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool JDKJJDOBIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IIHMMKNABCC? DBAHMJGDFJH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4290", Offset = "0x5CB2A90", VA = "0x185CB4290")]
	public LLLGDJEIFOI(bool HGJGCPMFIGJ, [Optional] IIHMMKNABCC? HOONGJJJIJB)
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

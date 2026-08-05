using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct LLKAACAOHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum OOFECPEEIHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool EJCGMHFILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public OOFECPEEIHK? KOCLDGIOIBJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE370", Offset = "0x6FFC970", VA = "0x186FFE370")]
	public LLKAACAOHBA(bool OHEHOJADCKH, [Optional] OOFECPEEIHK? LOEKGHJOKHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CCADIFGKOGM
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LKLECENCKFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HHMAMPOHJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> NDEFNKFFFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> GMFDPHNNEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> NGKEKIOMMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> DPFHAPGDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CKFGAFJFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> CJDNHCDKGIG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PKFKAJAHCLE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CNHABPKENFP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DKKIJJLCNLH([Optional] List<string> PABDOPMBDIL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MFBKDKPGMNP<Guid> BPJFMBNIFPD(KNBGGKHAOAH GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HHGLIBCDIDA JCGJFFFFOKJ(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HHGLIBCDIDA OABKJJDDCGB(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MIDHPHFPIHP(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MNINGHBLMHB(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LAKBHHOLDBL(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IGCCEPDBDAP(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GCFHMJECPNM(KNBGGKHAOAH GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JNBJAOCNCIE(Guid ABCJLNPFGLC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int NNMBGJECEBH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	MFBKDKPGMNP<int> EPAOPPNCHIP(long AHLGFJPMMNL, long OHAAGCLGODK, [Optional] KNBGGKHAOAH? GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MFBKDKPGMNP<int> DENBIDNNOCL(long AHLGFJPMMNL, long OHAAGCLGODK, [Optional] KNBGGKHAOAH? GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MFBKDKPGMNP<Dictionary<KNBGGKHAOAH, int>> HMFBDKGJPGK(long AHLGFJPMMNL, long OHAAGCLGODK);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MFBKDKPGMNP<Dictionary<KNBGGKHAOAH, int>> EMDLLFFFLPB(long AHLGFJPMMNL, long OHAAGCLGODK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MFBKDKPGMNP<IEnumerable<Guid>> HAMLGNLOKPD(long AHLGFJPMMNL, long OHAAGCLGODK, [Optional] KNBGGKHAOAH? GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MFBKDKPGMNP<IEnumerable<Guid>> PIHDCGBGAFO(long AHLGFJPMMNL, long OHAAGCLGODK, [Optional] KNBGGKHAOAH? GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string JJEBDFGBGML(KNBGGKHAOAH GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string CNILGIEJMBD(KNBGGKHAOAH GMLMLHACFDB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<KNBGGKHAOAH> BPAABFONEND();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<KNBGGKHAOAH> EMLILALNPLA();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LLOFBLKCKHL(long AHLGFJPMMNL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool EAHEKHPPAJG(long AHLGFJPMMNL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NLDCAJGGDNB(long BICLHLPBJLE, out DateTime LEAOHKIKGNO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long BEINOFAKLDP(long BICLHLPBJLE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long ELMJBGECFCM(long DJLPNLOCDIK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int BEEBAGPCFPH(long BICLHLPBJLE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool FMNJDEOCFKB();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool KHNOMCEEFAP(long BICLHLPBJLE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> ADMBFJCAAOG(long BICLHLPBJLE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int GBMMNENCMLK(long BICLHLPBJLE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string EFJCMOOMING(GJABPMEGKCN HBCGBCEJEDE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string LCOKFCJFALM(GJABPMEGKCN HBCGBCEJEDE, int LBEJMAKALIB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string FNOAJCPHGGK(GJABPMEGKCN HBCGBCEJEDE, long AHLGFJPMMNL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long PGAODPECFNN(long OOFGIKBNHBN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	KNBGGKHAOAH GBLPPNMHKHO();
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

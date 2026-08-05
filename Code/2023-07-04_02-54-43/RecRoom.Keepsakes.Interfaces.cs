using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct IIJLPGJKDPK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum FDEALPKGNEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool ELIGGNGMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public FDEALPKGNEH? FEONHGPGCBL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7274EA0", Offset = "0x72734A0", VA = "0x187274EA0")]
	public IIJLPGJKDPK(bool FIIDOIHOPIF, [Optional] FDEALPKGNEH? LLOAEDKNIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LCOAPPHFBDO
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NEEJAOENAHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PGJIFELPPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> BFIEKPDNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> HFNCDCPBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> DHIKFFIJKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> GLOJOGEJFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NJCNCKAILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> DMLDPAIOMJA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EIKLMNAGGAM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EGDOKLEHBFI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NGOGIGMIGAP([Optional] List<string> HACBBPJFDDL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LEKACFEIBBA<Guid> JAPALLFKPCA(NHINHHJKNOE DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ADCACBFKFKM AMKNLHGGPKG(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ADCACBFKFKM OIDBPOKJNOL(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BKPDJPDKCBJ(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DDFEEDMFCGF(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JKPJECENAJN(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DLAKEOEIIDC(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CEIIOCJACMC(NHINHHJKNOE DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FDABNPMJOCN(Guid BHBNPLODPJC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int EMDBEGPJPDC();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	LEKACFEIBBA<int> AHCIGKMPNKL(long EDDMGMBKEBK, long DGNKKLIGEOC, [Optional] NHINHHJKNOE? DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LEKACFEIBBA<int> FDKEOOKBCCJ(long EDDMGMBKEBK, long DGNKKLIGEOC, [Optional] NHINHHJKNOE? DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LEKACFEIBBA<Dictionary<NHINHHJKNOE, int>> LMMHAOKDKOI(long EDDMGMBKEBK, long DGNKKLIGEOC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LEKACFEIBBA<Dictionary<NHINHHJKNOE, int>> CCOIHBHNMDE(long EDDMGMBKEBK, long DGNKKLIGEOC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LEKACFEIBBA<IEnumerable<Guid>> EPJOMMHHMJM(long EDDMGMBKEBK, long DGNKKLIGEOC, [Optional] NHINHHJKNOE? DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	LEKACFEIBBA<IEnumerable<Guid>> OGBFCNKIKBO(long EDDMGMBKEBK, long DGNKKLIGEOC, [Optional] NHINHHJKNOE? DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string EAEJMCEDFLO(NHINHHJKNOE DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string AKBNFCHNIHD(NHINHHJKNOE DOLKJBDIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<NHINHHJKNOE> CKEKJGCJALG();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<NHINHHJKNOE> IDHMLKBNFMH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool CFFHOCGCODB(long EDDMGMBKEBK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool OMOOJGGPPFK(long EDDMGMBKEBK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PGONFJKODCK(long PICNFCHGPOB, out DateTime PGGAINGBBMN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long EOFADNLKOKG(long PICNFCHGPOB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long NHPBKACCIBJ(long EEOJDHFJHEP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int MNJNAOGJCHF(long PICNFCHGPOB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool BHLAHDJPJGM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool CIEJLJIAADB(long PICNFCHGPOB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> INFLFFEPEME(long PICNFCHGPOB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int OEHELFHJMII(long PICNFCHGPOB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string GCBJPKBCALE(IKBGIOLBELG HLNGHNGFGFC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string LLAPMBLNPBE(IKBGIOLBELG HLNGHNGFGFC, int CFPEMLGGEHI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string JFKJJELPMOH(IKBGIOLBELG HLNGHNGFGFC, long EDDMGMBKEBK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long NIGIIOGFCCD(long PALCPIKIKLB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	NHINHHJKNOE OANKFFGHJFN();
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

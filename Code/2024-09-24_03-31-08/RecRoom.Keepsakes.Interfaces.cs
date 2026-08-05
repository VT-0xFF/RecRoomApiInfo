using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LCICAOIJPCD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IDLEPFJPCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ADCGBPHMIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> ANGLFICIAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> DAAAIMEHMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> LHHCHMPHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> JAAGIGFHJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DAPADKGACMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> JNIOHCECEIH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action FGNOOGICBGE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BBLALOIGCLB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BDJBEIFAPOM([Optional] List<string> PAPHIOMHALE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HABLMKCEIGL<Guid> OGHBPDGIHOH(GAPPDCPCNCP DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KGIOENCPIOK CPNMLJIIGNI(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KGIOENCPIOK OFNAHNHJDBM(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BPMBLKOJFLH(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BLIHKOLHNOK(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool HKFGCGOFGPO(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AMDINFMBHFC(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PGBPBCMJCBK(GAPPDCPCNCP DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HPEJIGDOEEJ(Guid PFKGIENKOJN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int DEJGJBGLGBC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HABLMKCEIGL<int> KBEDMPHLGDI(long MOEKPKHCJHD, long KBAIBDCGCPD, [Optional] GAPPDCPCNCP? DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	HABLMKCEIGL<int> EKBEOFAKMHM(long MOEKPKHCJHD, long KBAIBDCGCPD, [Optional] GAPPDCPCNCP? DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HABLMKCEIGL<Dictionary<GAPPDCPCNCP, int>> MFGLCPKGHNK(long MOEKPKHCJHD, long KBAIBDCGCPD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HABLMKCEIGL<Dictionary<GAPPDCPCNCP, int>> JFKGOIEGHNP(long MOEKPKHCJHD, long KBAIBDCGCPD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HABLMKCEIGL<IEnumerable<Guid>> DDHNGMCDEBN(long MOEKPKHCJHD, long KBAIBDCGCPD, [Optional] GAPPDCPCNCP? DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HABLMKCEIGL<IEnumerable<Guid>> FHGEOPJMGHI(long MOEKPKHCJHD, long KBAIBDCGCPD, [Optional] GAPPDCPCNCP? DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string PAMDGOGHDPE(GAPPDCPCNCP DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string APNBNEKCABF(GAPPDCPCNCP DLBPCHBONCJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<GAPPDCPCNCP> DINPJDAFIHI();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<GAPPDCPCNCP> LOHMLEOPHAO();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool NGDHODIKBML(long MOEKPKHCJHD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool BBLKCJKJMFB(long MOEKPKHCJHD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OJFOAEGPKAB(long LKLEPPPOAOH, [Out] DateTime KBAPOBMINAE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long GIKFIBNLLPA(long LKLEPPPOAOH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long GADPFBGCAPF(long JPLHBCGDBGM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int JJIHEOFGLMF(long LKLEPPPOAOH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool IMFIEKPBODD();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool HGIEBLIDPOP(long LKLEPPPOAOH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> LGLHOGNDFLO(long LKLEPPPOAOH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int KKKELLCAHGI(long LKLEPPPOAOH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string MCMNEHEKMPH(ENEALBCGEMD ADKFLDCMKMC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string NAPNJFLKHMK(ENEALBCGEMD ADKFLDCMKMC, int EEJEEMFNGHM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string IFEPPBLMDAK(ENEALBCGEMD ADKFLDCMKMC, long MOEKPKHCJHD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long NKJGLLHGOHL(long EJDOICMPDFF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GAPPDCPCNCP LLFNEAGKLNO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KMCJFBPIHPO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum AGCGMMCMFOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool HBBANKCMCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public AGCGMMCMFOG? ONNEPHGGMOM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BC08A0", Offset = "0x6BBF2A0", VA = "0x186BC08A0")]
	public KMCJFBPIHPO(bool GHPIOLPPJDL, [Optional] AGCGMMCMFOG? PAEHGJGIFLN)
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

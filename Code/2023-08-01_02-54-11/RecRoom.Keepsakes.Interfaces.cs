using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct JEPIOKIFFOO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum HIGKAMEGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool ECBIIPKHCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public HIGKAMEGMCH? AINBJFLPKJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72D1470", Offset = "0x72D0470", VA = "0x1872D1470")]
	public JEPIOKIFFOO(bool MMNFDNKKDNL, [Optional] HIGKAMEGMCH? EMOADDGIBDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HLIECHJGLFP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OOJGBAODHBI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NEHNNPLNMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> KDABHCFBEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> AMHHLOHLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> GIJLGLBECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> FADOLNCGCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JJDJOJEIFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> NNBLCBOIHIP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GJNOIIPHFHO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CIDBDMBDJKK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OMHIDKHCLEC([Optional] List<string> LJJGJAPNBPE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LJAJHHFEMAM<Guid> OOAJCMGDKEG(POHMPBPHJDB FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FHJJKILLDME ADKJNBNFJNJ(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FHJJKILLDME MMDBKAIABDD(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IDADCJFDEIK(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DGLDDJEFPLN(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JFAADIJDGKO(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HGNCENCCMFK(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BCLHABOGNCJ(POHMPBPHJDB FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void APEFJFGGBFF(Guid DOFNMNEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int ICNMNPLFGPN();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	LJAJHHFEMAM<int> GJCHDKAKGIN(long IIKHCGCAMCH, long KJGGLMIPDJB, [Optional] POHMPBPHJDB? FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LJAJHHFEMAM<int> DOPEHPHKPJL(long IIKHCGCAMCH, long KJGGLMIPDJB, [Optional] POHMPBPHJDB? FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LJAJHHFEMAM<Dictionary<POHMPBPHJDB, int>> NGKEHGEDONE(long IIKHCGCAMCH, long KJGGLMIPDJB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LJAJHHFEMAM<Dictionary<POHMPBPHJDB, int>> IKMEFKCNAAA(long IIKHCGCAMCH, long KJGGLMIPDJB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LJAJHHFEMAM<IEnumerable<Guid>> BIFJGHCCILH(long IIKHCGCAMCH, long KJGGLMIPDJB, [Optional] POHMPBPHJDB? FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	LJAJHHFEMAM<IEnumerable<Guid>> LKBECGAGHGN(long IIKHCGCAMCH, long KJGGLMIPDJB, [Optional] POHMPBPHJDB? FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string ABOPCHANFNK(POHMPBPHJDB FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string KNGMILPCOCI(POHMPBPHJDB FBBPJENJIDG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<POHMPBPHJDB> EJEJHALLBJF();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<POHMPBPHJDB> LJOCHBCDOLH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool KDHADAGIAHF(long IIKHCGCAMCH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool POGKMJCNHNM(long IIKHCGCAMCH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool BAKBNFFEGIF(long MFHMCMMDLBN, out DateTime IJPJMPMOEDL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long IMGDKGHPMAP(long MFHMCMMDLBN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long FDJDFKJAJFN(long AJCKGJECEPM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int NNNMCJCBLMO(long MFHMCMMDLBN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool JGGDJKMLMAC();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool NOMINBGEDGJ(long MFHMCMMDLBN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> KBKDGOLEHIO(long MFHMCMMDLBN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int HMPIIOOENCD(long MFHMCMMDLBN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string LFHMNLAFMBH(OGFEJAPOCAM APFLKDKNNNH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string CAKAJOHAMLB(OGFEJAPOCAM APFLKDKNNNH, int EOFJIEAFENB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string FCNPOOMPCJA(OGFEJAPOCAM APFLKDKNNNH, long IIKHCGCAMCH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long PGDLFCLINOD(long PBLIFEIEJBN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	POHMPBPHJDB GJDFPPOKAIG();
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

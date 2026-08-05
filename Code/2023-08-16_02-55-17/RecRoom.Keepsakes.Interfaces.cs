using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct ILFIAEHALFM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum CDJKFAMHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool DHDFFKNECHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public CDJKFAMHBCM? HBNAFPHGMOL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F83DE0", Offset = "0x6F82FE0", VA = "0x186F83DE0")]
	public ILFIAEHALFM(bool MHJLBEDJNAE, [Optional] CDJKFAMHBCM? IADKEBJKLGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GGIJEBBOGCD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EOBEKFCDCGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OIMGCFAAMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> MKOMCMLNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> NECCJLKLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> FCFCNPIBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> DNKDOOPFLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IFJEANPGBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> MONEFKLEAPA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GMNOHCFAGLP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LJGENJMCMGG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ODJAACCGCIJ([Optional] List<string> KLKDCMDJCNE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OOMFLHAHLDK<Guid> IMAIMMBIJKI(DLHAJNJECEF HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GIOBGNHJLID ADNJJPKGBDH(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GIOBGNHJLID KMCMABMPGND(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LOKFFKALNLO(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GLICHGAJHCL(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PGLIGCLEGHF(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CLFBCHFMFJF(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LKKHBNDCMEA(DLHAJNJECEF HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DIGIGGNDEJO(Guid CKCOJKGAGID);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int KBLAFDAIPBO();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OOMFLHAHLDK<int> FMBPCNJHDAA(long HBFBDJIOFCF, long HHLFKPKHDIA, [Optional] DLHAJNJECEF? HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	OOMFLHAHLDK<int> JLEJDKPEGPO(long HBFBDJIOFCF, long HHLFKPKHDIA, [Optional] DLHAJNJECEF? HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OOMFLHAHLDK<Dictionary<DLHAJNJECEF, int>> GMCNPHCHFML(long HBFBDJIOFCF, long HHLFKPKHDIA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OOMFLHAHLDK<Dictionary<DLHAJNJECEF, int>> MKDJHBOJFLE(long HBFBDJIOFCF, long HHLFKPKHDIA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OOMFLHAHLDK<IEnumerable<Guid>> JCBLIPOLNHI(long HBFBDJIOFCF, long HHLFKPKHDIA, [Optional] DLHAJNJECEF? HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	OOMFLHAHLDK<IEnumerable<Guid>> DMHLLFHFKAN(long HBFBDJIOFCF, long HHLFKPKHDIA, [Optional] DLHAJNJECEF? HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string OOLKAOEDJDD(DLHAJNJECEF HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string FLFDILHLFIL(DLHAJNJECEF HKACKNCFAEK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<DLHAJNJECEF> IMFPDILFKMC();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<DLHAJNJECEF> MBAFDBJCHGL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LFKONGAOMOJ(long HBFBDJIOFCF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool MNLGEGOGDAO(long HBFBDJIOFCF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KKOCAFCHNJD(long NMDBCDIOHJN, out DateTime HNLHDHCOGFI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long PENEOLHFPMD(long NMDBCDIOHJN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long AFPILHNKHIJ(long ALIEGFJJCIB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int ECGHODDPDHP(long NMDBCDIOHJN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool LDCAMOOMFLP();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool APGGNJICPDO(long NMDBCDIOHJN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> ODOLOILJHHI(long NMDBCDIOHJN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int IGKEEEHGPPC(long NMDBCDIOHJN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string CLBLOLMEDOI(GMCHEMCNICO AGPFNFFABML);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string NBDIBBFAHPG(GMCHEMCNICO AGPFNFFABML, int NPLDKLOKFAB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string IHDDDDJEKBG(GMCHEMCNICO AGPFNFFABML, long HBFBDJIOFCF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long OAGHOEFKFHG(long JLLLDBKHPHE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	DLHAJNJECEF EHFJMFEADFA();
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

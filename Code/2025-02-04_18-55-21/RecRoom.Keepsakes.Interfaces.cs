using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NNIAPLHCIND
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KGJJNCGCPGF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OFMEHGIBIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> JDOFIOHJCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> JNOIOBCLNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> JCHKBLLKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> IENLGNLGFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JHPINOOOOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> COHGBJKLANH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EGMOJCEHEHA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AHEBEEKCEDE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AFLAIINCJKM([Optional] List<string> HCPCOPHPEAK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MNHDJBCOCND<Guid> MODLGEJBDBJ(MJGAMLALHAD NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LDHIGNIGDAL IMFJACNMNLL(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LDHIGNIGDAL BJODHDDAHLN(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PLEHECPMKCI(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IPBBCGDEFGE(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ILLKCCMPBFK(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EKNCDGNCEII(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NHAHMPOMEEL(MJGAMLALHAD NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EGPDDDOBDFJ(Guid MJDLHFNFBNN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int GOBMMJHOMDB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	MNHDJBCOCND<int> NAECFGNLIHO(long OGMIFIGJENM, long JMJOPNJJPCA, [Optional] MJGAMLALHAD? NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MNHDJBCOCND<int> OGOPKBLAPFE(long OGMIFIGJENM, long JMJOPNJJPCA, [Optional] MJGAMLALHAD? NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MNHDJBCOCND<Dictionary<MJGAMLALHAD, int>> BLMMOKLCCCE(long OGMIFIGJENM, long JMJOPNJJPCA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MNHDJBCOCND<Dictionary<MJGAMLALHAD, int>> JMHMINJOECG(long OGMIFIGJENM, long JMJOPNJJPCA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MNHDJBCOCND<IEnumerable<Guid>> CBADOBEKHCN(long OGMIFIGJENM, long JMJOPNJJPCA, [Optional] MJGAMLALHAD? NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MNHDJBCOCND<IEnumerable<Guid>> JADFBPIPFAN(long OGMIFIGJENM, long JMJOPNJJPCA, [Optional] MJGAMLALHAD? NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string LHNGKKCIJKF(MJGAMLALHAD NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string HPMBLJONHLP(MJGAMLALHAD NJKEIHDFKML);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<MJGAMLALHAD> HHAFDOCPPGH();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<MJGAMLALHAD> LNHKMFHGOJB();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool KJPHOFCLADF(long OGMIFIGJENM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool IABOJBKDEJO(long OGMIFIGJENM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GADNCBKAMHG(long GDMCPEAFOIK, [Out] DateTime NKILJKODMPC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JFBAMBOKFJF(long GDMCPEAFOIK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long COMFKFBBILE(long MEFMCAHGIGP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int CMEGBNEGAAM(long GDMCPEAFOIK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool GMCJJMHKOCI();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool MNGLNDEJLKC(long GDMCPEAFOIK);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<long> DIMPPDFIFHC(long GDMCPEAFOIK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int NMFKFHAJJKN(long GDMCPEAFOIK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string MLCMJAJDLAO(JKOPLJNIFNL EFDLDIHIPLO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string DDKKBHLLJIC(JKOPLJNIFNL EFDLDIHIPLO, int FEHNKBKBBEB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string CCPMFDFFJFL(JKOPLJNIFNL EFDLDIHIPLO, long OGMIFIGJENM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long HPMFFDNLMON(long ICFCJEPDCGA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	MJGAMLALHAD GJBHCLIDIPA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GMNPJHMNGIE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum FADMCFGNGOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool COAJPLAHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public FADMCFGNGOI? CMFMNKBHEAA;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72B3EF0", Offset = "0x72B2CF0", VA = "0x1872B3EF0")]
	public GMNPJHMNGIE(bool FGHEDCBOKOI, [Optional] FADMCFGNGOI? LDOKPHBGKNJ)
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

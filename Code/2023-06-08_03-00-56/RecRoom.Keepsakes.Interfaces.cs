using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct GHNECKNGNHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum PELBBMDGLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool OFDPCGFMLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PELBBMDGLMJ? JNLJOLIDDBB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1943930", Offset = "0x1942730", VA = "0x181943930")]
	public GHNECKNGNHJ(bool OCDKCBLONLO, [Optional] PELBBMDGLMJ? DIFENFCDHBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IGCICNAMBLN
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BKMMAEGBDIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HEPNNDOEKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> AGCKOOLACPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> ONDKDKCBNML
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> LOCNJLHJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> CKJJEOCABDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IPLOADPOOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> GMFEFPEMOLM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JLCFBBOEMHN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HCLPGFAMDMC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OPFAKBMMNBA([Optional] List<string> IELJKPKIOKG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AHPDIJDJLKD<Guid> AAKCCEMLKMA(CJCGELBDEFP OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NONMCJIBNII DBLCNAOAJGE(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NONMCJIBNII OJLKFGDOCBE(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MBLELPOAPCF(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FILONPOJLLI(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GIBPMGLDEMC(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PLMBMAONKIK(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OJLJKGBJGBK(CJCGELBDEFP OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FMCKLFJHFHF(Guid JAGFBLADBKH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int GIIDEMKNLAC();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	AHPDIJDJLKD<int> EEJPEJMAIEF(long OFOPNAOLFGC, long JDCHPBMGIIG, [Optional] CJCGELBDEFP? OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AHPDIJDJLKD<int> KLJEPFPFEMA(long OFOPNAOLFGC, long JDCHPBMGIIG, [Optional] CJCGELBDEFP? OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	AHPDIJDJLKD<Dictionary<CJCGELBDEFP, int>> KDJABEMGAFP(long OFOPNAOLFGC, long JDCHPBMGIIG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	AHPDIJDJLKD<Dictionary<CJCGELBDEFP, int>> PINAMAEDMEF(long OFOPNAOLFGC, long JDCHPBMGIIG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AHPDIJDJLKD<IEnumerable<Guid>> BMEKEJLJIKG(long OFOPNAOLFGC, long JDCHPBMGIIG, [Optional] CJCGELBDEFP? OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	AHPDIJDJLKD<IEnumerable<Guid>> MMCGBMLAGKI(long OFOPNAOLFGC, long JDCHPBMGIIG, [Optional] CJCGELBDEFP? OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string IPLOBMNMNMH(CJCGELBDEFP OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string NFEDDAEJFKD(CJCGELBDEFP OBLILFIPCML);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<CJCGELBDEFP> BEAHJIEFHLO();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<CJCGELBDEFP> EOJJLFNKMFN();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PICKJKFAMLI(long OFOPNAOLFGC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool PBAILHIEBIL(long OFOPNAOLFGC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool BNDOFJAFGON(long NEEOIHGDHIB, out DateTime MDANIGDFGJE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long JCCJNFOLOHM(long NEEOIHGDHIB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long KLKCBBJCCMI(long HOMCADMCJMH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int IIJKDKNNCMP(long NEEOIHGDHIB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool ENDFPGGHHPJ();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool EDHNPHGIHLC(long NEEOIHGDHIB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> CJGHAKKGBDN(long NEEOIHGDHIB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int KAMDHMLKNHC(long NEEOIHGDHIB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string NMPKKPKHBBO(MCDHIHMDLLH INLCGDKIMGB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string JHKMAEICGDD(MCDHIHMDLLH INLCGDKIMGB, int ONKBGFIFFAN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string ELJDCOEDNEG(MCDHIHMDLLH INLCGDKIMGB, long OFOPNAOLFGC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long HLKADHPLLCL(long FLGJMMJDABB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	CJCGELBDEFP AIMLAMNKNBN();
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

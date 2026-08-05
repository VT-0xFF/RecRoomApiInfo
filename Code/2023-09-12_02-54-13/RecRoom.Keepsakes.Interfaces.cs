using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct JJCEDPNKLNH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum BLJEEDHDIKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool HJACKKJJKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public BLJEEDHDIKB? CMIAOIACLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72371C0", Offset = "0x72365C0", VA = "0x1872371C0")]
	public JJCEDPNKLNH(bool CJLJIBEBJFK, [Optional] BLJEEDHDIKB? BCOFAGGEPGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DOOGOHEIGCD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EGBNLJBLJLB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NKHDJICGNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> DPDHHONNJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> LABOPJBNIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> GIPHBKFKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> FAMMFJCKMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IHILCNDJPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> JJHLPJCFCKN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KBKNGKPDFLO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BHJIMBPDEJD;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FPJLCOENLBI([Optional] List<string> DPHKIJLINDH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KDCMFGDLEKL<Guid> DBBBPKALIPA(GMHDHODCNMC HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LMHNGLGIJDH MHNNBBKAIGJ(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LMHNGLGIJDH FMMNIGEABBE(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FMJKBPLIFBG(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JMKBIJGGNNO(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool CFFPGFDBBPM(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NCBABEEPDNK(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IINLEPELMPO(GMHDHODCNMC HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void APELLBIEOHG(Guid HODMOHOMIKF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int NGLGMOPPMON();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KDCMFGDLEKL<int> DKBAFOFBECI(long KFHMHOFPIPN, long HEMEJJGNILE, [Optional] GMHDHODCNMC? HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KDCMFGDLEKL<int> GJJJBDCELKI(long KFHMHOFPIPN, long HEMEJJGNILE, [Optional] GMHDHODCNMC? HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KDCMFGDLEKL<Dictionary<GMHDHODCNMC, int>> OLDFMJAOKAM(long KFHMHOFPIPN, long HEMEJJGNILE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KDCMFGDLEKL<Dictionary<GMHDHODCNMC, int>> FHCMLCKFJLC(long KFHMHOFPIPN, long HEMEJJGNILE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KDCMFGDLEKL<IEnumerable<Guid>> GOHOIEKKHPJ(long KFHMHOFPIPN, long HEMEJJGNILE, [Optional] GMHDHODCNMC? HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	KDCMFGDLEKL<IEnumerable<Guid>> CPFALFCDCAO(long KFHMHOFPIPN, long HEMEJJGNILE, [Optional] GMHDHODCNMC? HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string BGOPKBHCLPK(GMHDHODCNMC HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string LFIIOMMPNNF(GMHDHODCNMC HDLDJIFAKDK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<GMHDHODCNMC> AIEKPNBFNIF();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<GMHDHODCNMC> KBEGDBMCCCL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool EPBBHHNFPCB(long KFHMHOFPIPN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool PDCLFJNFHLL(long KFHMHOFPIPN);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool BPCHNLILBEM(long JMLMKPDPECA, out DateTime DKIIFFAOBLG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long PPEONIJBKKJ(long JMLMKPDPECA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long EFEHIPPOKLP(long GBCFPAENHKN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int DFMGBDMLKKM(long JMLMKPDPECA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool BLIGAJADHMH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool PGJHFKMGIFD(long JMLMKPDPECA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> LAKCCNCKGJO(long JMLMKPDPECA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int DBONAIPCMHM(long JMLMKPDPECA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string AMBACEBIFPP(HIBKGIAMNDM NANDFNJJFJL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string DBBNMKPAKJJ(HIBKGIAMNDM NANDFNJJFJL, int LEKEGLOONMA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string DFOJJIHJEMC(HIBKGIAMNDM NANDFNJJFJL, long KFHMHOFPIPN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long FBHLLMNBKIF(long OJMLIKKDMAP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GMHDHODCNMC FGCEGIEJICA();
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

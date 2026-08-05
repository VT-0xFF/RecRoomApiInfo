using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KBIBLPIJFEB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Premium,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	All
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BDIHIGBPAAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AOOILPEGBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IReadOnlyList<KeepsakeRoomListDTO> IMFKABPOIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<KeepsakeRoomListDTO> JIJCCMPEOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyList<KeepsakeRoomListDTO> HNKFFOMJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IReadOnlyDictionary<long, string> PGOLJCILGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HECKIJHMNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<Guid?> FPDLCKMENMO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PCOLPDAJEHA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JEBFCLKJNIG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KKAPNMHGDMK([Optional] List<string> DOOLPFJHHOB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DOPLGHLIBGN<Guid> NPGBJBBNNMI(EFLJMDBPODD NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AJKHGLHHDGH BDHMHKHJCHE(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AJKHGLHHDGH BHEJMCMFJKM(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DIBOBGEAOAC(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JGPGICJBFPN(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GFGBDBDFHOI(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CGFKBLALPMK(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FCBHODDNFMB(EFLJMDBPODD NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LFJLCCIDKIF(Guid GFIDPDNCIHA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	int ONJFGKANOIE();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	DOPLGHLIBGN<int> ANFGJELCKDK(long CGIDLDOBHII, long BDDGJJKPACH, [Optional] EFLJMDBPODD? NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	DOPLGHLIBGN<int> CKKNBCPOGPN(long CGIDLDOBHII, long BDDGJJKPACH, [Optional] EFLJMDBPODD? NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DOPLGHLIBGN<Dictionary<EFLJMDBPODD, int>> OLCPMDMFJJJ(long CGIDLDOBHII, long BDDGJJKPACH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DOPLGHLIBGN<Dictionary<EFLJMDBPODD, int>> JHEDCFIJCDD(long CGIDLDOBHII, long BDDGJJKPACH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DOPLGHLIBGN<IEnumerable<Guid>> IOEMIPBBAMI(long CGIDLDOBHII, long BDDGJJKPACH, [Optional] EFLJMDBPODD? NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	DOPLGHLIBGN<IEnumerable<Guid>> BBGAOFCAEHB(long CGIDLDOBHII, long BDDGJJKPACH, [Optional] EFLJMDBPODD? NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	string BNJAICOIFEN(EFLJMDBPODD NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string CFEDJDCEFHF(EFLJMDBPODD NPOCCMNJGID);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	List<EFLJMDBPODD> FMINNOABKPF();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IComparer<EFLJMDBPODD> AMKCIJHKENL();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LIIEKBJGDKH(long CGIDLDOBHII);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool MJEEBMOOCCO(long CGIDLDOBHII);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EDFOKOJLGBM(long OCCDBIOPOBA, [Out] DateTime ACLJDBKFKAD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "36")]
	long OPIJJDJCLOI(long OCCDBIOPOBA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "37")]
	long NEBKDCMPNDI(long FCDFOAIDDAO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "38")]
	int OMKJGMMMCDM(long OCCDBIOPOBA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool CCOMPDFFGNK();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool KPEHOFHMLGC(long OCCDBIOPOBA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IEnumerable<long> MIPCLNGMFMH(long OCCDBIOPOBA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int BPCKGODPKBC(long OCCDBIOPOBA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	string FOAKFKDPNCM(LEJJNCGFDAM OFHOALOPBCE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "44")]
	string IAGPAJODHDO(LEJJNCGFDAM OFHOALOPBCE, int FELKLNBNHPI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	string GGMLFFBBCJA(LEJJNCGFDAM OFHOALOPBCE, long CGIDLDOBHII);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	long AKEFHKECANF(long PENGIDFBHBA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "47")]
	EFLJMDBPODD BFNCKPDCJEE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PBNIPNKOABC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum NHDNKHPFAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LockedByTime,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LockedByItem
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool PMICOJIMHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public NHDNKHPFAIJ? CLNLJPIGCBF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x601BBB0", Offset = "0x601A9B0", VA = "0x18601BBB0")]
	public PBNIPNKOABC(bool HDAJCCLPFFI, [Optional] NHDNKHPFAIJ? DDDEDBAMFCE)
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

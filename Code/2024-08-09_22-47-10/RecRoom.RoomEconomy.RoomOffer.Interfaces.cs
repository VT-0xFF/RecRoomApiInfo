using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ILNAFCALEKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IDDBOOGKPOH ICBNLOOLFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x27C62E8027C600", Offset = "0x0", VA = "0x27C6300027C600", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27C62E8A162DD0", Offset = "0x0", VA = "0x27C6300A162DD0", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HLCMNEBCMLD<IFGIPBJKKGB> AHPNMIEAOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1616AA8027C656", Offset = "0x0", VA = "0xA1616AC0027C656", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27C6848027C660", Offset = "0x0", VA = "0x27C6860027C660", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HLCMNEBCMLD<Guid> IGGPGNFIPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27C68E8A1616AC", Offset = "0x0", VA = "0x27C6900A1616AC", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1616AA8027C6B6", Offset = "0x0", VA = "0xA1616AC0027C6B6", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27C6EE8027C6C0", Offset = "0x0", VA = "0x27C6F00027C6C0", Slot = "6")]
	Task<NNKIHJJJOOI<IFGIPBJKKGB, string>> FKABHJBLLEN(long GICEIKJHPKB, string FIKHOKLHCII, string ANGPLEOPDHC, string FIBLLFHMDBJ, int GOPFHBMOMFI, NOKMJDABBNB PHBIOMBCCNI, [Optional] Dictionary<Guid, int> PEFNOPIEILK, [Optional] Guid? AAHMKLHLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27C6EE8A162DD0", Offset = "0x0", VA = "0x27C6F00A162DD0", Slot = "7")]
	Task<NNKIHJJJOOI<IFGIPBJKKGB, string>> BBBLBJCJDEI(Guid IBMGMLCLALN, string FIKHOKLHCII, string ANGPLEOPDHC, string FIBLLFHMDBJ, int GOPFHBMOMFI, NOKMJDABBNB PHBIOMBCCNI, [Optional] Dictionary<Guid, int> PEFNOPIEILK, [Optional] Guid? AAHMKLHLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA16F78E8027C77E", Offset = "0x0", VA = "0xA16F7900027C77E", Slot = "8")]
	Task<NNKIHJJJOOI<bool, string>> IMHKEHMLOII(Guid IBMGMLCLALN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27C7A48027C780", Offset = "0x0", VA = "0x27C7A60027C780", Slot = "9")]
	IEnumerable<IFGIPBJKKGB> GDPHNEIEGEN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27C7AE8A1616AC", Offset = "0x0", VA = "0x27C7B00A1616AC", Slot = "10")]
	Task<List<KCIEOHDDGMO>> BNMADHEIMEK(long GICEIKJHPKB, [Optional] CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA162DCE8027C7E0", Offset = "0x0", VA = "0xA162DD00027C7E0", Slot = "11")]
	bool AKHMOCHOKEF(Guid IBMGMLCLALN, [Out] IFGIPBJKKGB DBOOCHFJFMP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27C80E8027C7E0", Offset = "0x0", VA = "0x27C8100027C7E0", Slot = "12")]
	bool PFCJNBDHBNL(Guid IBMGMLCLALN, int PIFNCIKJBIG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27C80E8A162DD0", Offset = "0x0", VA = "0x27C8100A162DD0", Slot = "13")]
	void OPHEPKIDKBE(OOGKCGEGFAA MPPBKBAPBEE, Guid IBMGMLCLALN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA162DCE8027C83E", Offset = "0x0", VA = "0xA162DD00027C83E", Slot = "14")]
	Task<int> LEKOHDBDJBI(OOGKCGEGFAA MPPBKBAPBEE, Guid IBMGMLCLALN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27C86E8027C840", Offset = "0x0", VA = "0x27C8700027C840", Slot = "15")]
	bool CDMFOGEFHBP();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27C86E8A162DD0", Offset = "0x0", VA = "0x27C8700A162DD0", Slot = "16")]
	bool DLGABLCBKFJ(Guid IGDIJGNAEAA, [Out] List<string> COGKLLKNLBI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA162DCE8027C8A6", Offset = "0x0", VA = "0xA162DD00027C8A6", Slot = "17")]
	Task<NNKIHJJJOOI<bool, string>> MGGHJPHPFBD(IFGIPBJKKGB DBOOCHFJFMP, long BPBFMBKNAEK, int DBKDHFIFEPD, [Optional] string HNKLDIBHIEM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CMCOCCLHMKM
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27C8EE8027C8C0", Offset = "0x0", VA = "0x27C8F00027C8C0", Slot = "0")]
	void FPGGNPFNBJK(Guid EFKLGAJDEFG, string HNKLDIBHIEM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27C8EE8A162DD0", Offset = "0x0", VA = "0x27C8F00A162DD0", Slot = "1")]
	void OENIGLNDCDJ(Guid EFKLGAJDEFG, string HNKLDIBHIEM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA1629668027C928", Offset = "0x0", VA = "0xA1629680027C928", Slot = "2")]
	void KACHJDECHCN(Guid EFKLGAJDEFG, int DBKDHFIFEPD);
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IPCDKJJOFHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EHODCIMNDCH KAIPMBNGAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x27E72B8027E727", Offset = "0x0", VA = "0x27E72D0027E727", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27E72B8A32D86C", Offset = "0x0", VA = "0x27E72D0A32D86C", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ODIOBOMGOFD<DNGJEJMBPBJ> KLHAMJGLAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA32D85A8027E77E", Offset = "0x0", VA = "0xA32D85C0027E77E", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27E7A38027E780", Offset = "0x0", VA = "0x27E7A50027E780", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ODIOBOMGOFD<Guid> GKACHGGKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27E7A38A2C9380", Offset = "0x0", VA = "0x27E7A50A2C9380", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA32C1DE8027E856", Offset = "0x0", VA = "0xA32C1E00027E856", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27E8A58027E856", Offset = "0x0", VA = "0x27E8A70027E856", Slot = "6")]
	Task<CIKECDEKJAI<DNGJEJMBPBJ, string>> JLLMJEJLACI(long DIMOGDCMBFM, string BHFPKCCDEEC, string OLBMKMHMAID, string OJJODEJMFNM, int NMMAMOIDCII, EOGMFBHHBNG ICEKCEKLCMM, [Optional] Dictionary<Guid, int> MMGPFGJIMFI, [Optional] Guid? IGENBIHBCPC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27E8A58A32C1FC", Offset = "0x0", VA = "0x27E8A70A32C1FC", Slot = "7")]
	Task<CIKECDEKJAI<DNGJEJMBPBJ, string>> IKJFBMGJAPJ(Guid KMILCLKNBCL, string BHFPKCCDEEC, string OLBMKMHMAID, string OJJODEJMFNM, int NMMAMOIDCII, EOGMFBHHBNG ICEKCEKLCMM, [Optional] Dictionary<Guid, int> MMGPFGJIMFI, [Optional] Guid? IGENBIHBCPC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA32C20A8027E8AD", Offset = "0x0", VA = "0xA32C20C0027E8AD", Slot = "8")]
	Task<CIKECDEKJAI<bool, string>> LOBKBIFLIJP(Guid KMILCLKNBCL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27E8FC8027E8AD", Offset = "0x0", VA = "0x27E8FE0027E8AD", Slot = "9")]
	IEnumerable<DNGJEJMBPBJ> EOKDEIGNGCC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27E8FE8A32C1FC", Offset = "0x0", VA = "0x27E9000A32C1FC", Slot = "10")]
	Task<List<ODEFILMDKJC>> PFCFPEGIIMF(long DIMOGDCMBFM, [Optional] CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA2C937E8027E925", Offset = "0x0", VA = "0xA2C93800027E925", Slot = "11")]
	bool IDIBMMGAIEP(Guid KMILCLKNBCL, [Out] DNGJEJMBPBJ LFGEFHMAKGD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27E9D48027E925", Offset = "0x0", VA = "0x27E9D60027E925", Slot = "12")]
	bool AGLNACIBINJ(Guid KMILCLKNBCL, int FAIIIKMOBAL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27E9D48A32C680", Offset = "0x0", VA = "0x27E9D60A32C680", Slot = "13")]
	void EOJJIEIPBGA(LCMANADAOPN DAFEONGKMPP, Guid KMILCLKNBCL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA32C69A8027EA27", Offset = "0x0", VA = "0xA32C69C0027EA27", Slot = "14")]
	Task<int> HDJKEDAPBNA(LCMANADAOPN DAFEONGKMPP, Guid KMILCLKNBCL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27EA2B8027EA27", Offset = "0x0", VA = "0x27EA2D0027EA27", Slot = "15")]
	bool MBNDNCMFHOK();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27EA2B8A32C6AC", Offset = "0x0", VA = "0x27EA2D0A32C6AC", Slot = "16")]
	bool KMMIGDNJLKF(Guid DHNCLNFPOCP, [Out] List<string> KJENABEECLP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA32C69A8027EA7E", Offset = "0x0", VA = "0xA32C69C0027EA7E", Slot = "17")]
	Task<CIKECDEKJAI<bool, string>> BAIEEFBALAP(DNGJEJMBPBJ LFGEFHMAKGD, long KJLCJAHKKHE, int KOIONGLECCC, [Optional] string PNLLCLELBOC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JGFIPPLEBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27EAA28027EA80", Offset = "0x0", VA = "0x27EAA40027EA80", Slot = "0")]
	void PBOFAIMBGCJ(Guid GABENOAMOPA, string PNLLCLELBOC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27EAA28A11C9E0", Offset = "0x0", VA = "0x27EAA40A11C9E0", Slot = "1")]
	void LIPHPHKCAOC(Guid GABENOAMOPA, string PNLLCLELBOC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA32D07E8027EB43", Offset = "0x0", VA = "0xA32D0800027EB43", Slot = "2")]
	void EAOLKJHNLJG(Guid GABENOAMOPA, int KOIONGLECCC);
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

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
		[Cpp2IlInjected.Address(RVA = "0x27E9FC8027E9AD", Offset = "0x0", VA = "0x27E9FE0027E9AD", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27E9FE8A32D37C", Offset = "0x0", VA = "0x27EA000A32D37C", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ODIOBOMGOFD<DNGJEJMBPBJ> KLHAMJGLAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2CA4FE8027EA25", Offset = "0x0", VA = "0xA2CA5000027EA25", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27EAD48027EA25", Offset = "0x0", VA = "0x27EAD60027EA25", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ODIOBOMGOFD<Guid> GKACHGGKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27EAD48A32D800", Offset = "0x0", VA = "0x27EAD60A32D800", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA32D81A8027EB27", Offset = "0x0", VA = "0xA32D81C0027EB27", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27EB2B8027EB27", Offset = "0x0", VA = "0x27EB2D0027EB27", Slot = "6")]
	Task<CIKECDEKJAI<DNGJEJMBPBJ, string>> JLLMJEJLACI(long DIMOGDCMBFM, string BHFPKCCDEEC, string OLBMKMHMAID, string OJJODEJMFNM, int NMMAMOIDCII, EOGMFBHHBNG ICEKCEKLCMM, [Optional] Dictionary<Guid, int> MMGPFGJIMFI, [Optional] Guid? IGENBIHBCPC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27EB2B8A32D82C", Offset = "0x0", VA = "0x27EB2D0A32D82C", Slot = "7")]
	Task<CIKECDEKJAI<DNGJEJMBPBJ, string>> IKJFBMGJAPJ(Guid KMILCLKNBCL, string BHFPKCCDEEC, string OLBMKMHMAID, string OJJODEJMFNM, int NMMAMOIDCII, EOGMFBHHBNG ICEKCEKLCMM, [Optional] Dictionary<Guid, int> MMGPFGJIMFI, [Optional] Guid? IGENBIHBCPC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA32D81A8027EB7E", Offset = "0x0", VA = "0xA32D81C0027EB7E", Slot = "8")]
	Task<CIKECDEKJAI<bool, string>> LOBKBIFLIJP(Guid KMILCLKNBCL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27EBA28027EB80", Offset = "0x0", VA = "0x27EBA40027EB80", Slot = "9")]
	IEnumerable<DNGJEJMBPBJ> EOKDEIGNGCC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27EBA28A11DB60", Offset = "0x0", VA = "0x27EBA40A11DB60", Slot = "10")]
	Task<List<ODEFILMDKJC>> PFCFPEGIIMF(long DIMOGDCMBFM, [Optional] CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA32E1FE8027EC43", Offset = "0x0", VA = "0xA32E2000027EC43", Slot = "11")]
	bool IDIBMMGAIEP(Guid KMILCLKNBCL, [Out] DNGJEJMBPBJ LFGEFHMAKGD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27EC928027EC43", Offset = "0x0", VA = "0x27EC940027EC43", Slot = "12")]
	bool AGLNACIBINJ(Guid KMILCLKNBCL, int FAIIIKMOBAL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27EC928A32E21C", Offset = "0x0", VA = "0x27EC940A32E21C", Slot = "13")]
	void EOJJIEIPBGA(LCMANADAOPN DAFEONGKMPP, Guid KMILCLKNBCL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA32E22A8027EC9A", Offset = "0x0", VA = "0xA32E22C0027EC9A", Slot = "14")]
	Task<int> HDJKEDAPBNA(LCMANADAOPN DAFEONGKMPP, Guid KMILCLKNBCL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27ECE98027EC9A", Offset = "0x0", VA = "0x27ECEB0027EC9A", Slot = "15")]
	bool MBNDNCMFHOK();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27ECEE8A32E21C", Offset = "0x0", VA = "0x27ECF00A32E21C", Slot = "16")]
	bool KMMIGDNJLKF(Guid DHNCLNFPOCP, [Out] List<string> KJENABEECLP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA119EE68027ED15", Offset = "0x0", VA = "0xA119EE80027ED15", Slot = "17")]
	Task<CIKECDEKJAI<bool, string>> BAIEEFBALAP(DNGJEJMBPBJ LFGEFHMAKGD, long KJLCJAHKKHE, int KOIONGLECCC, [Optional] string PNLLCLELBOC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JGFIPPLEBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27EDBC8027ED15", Offset = "0x0", VA = "0x27EDBE0027ED15", Slot = "0")]
	void PBOFAIMBGCJ(Guid GABENOAMOPA, string PNLLCLELBOC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27EDBC8A32E8C0", Offset = "0x0", VA = "0x27EDBE0A32E8C0", Slot = "1")]
	void LIPHPHKCAOC(Guid GABENOAMOPA, string PNLLCLELBOC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA32E8DA8027EE0F", Offset = "0x0", VA = "0xA32E8DC0027EE0F", Slot = "2")]
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

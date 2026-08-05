using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FNBPAPFOCON
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GHNLMGKLHKE OGFEAGNOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x29148380291434", Offset = "0x0", VA = "0x29148500291434", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29148E8A7C37D8", Offset = "0x0", VA = "0x2914900A7C37D8", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KHECJJJIFBB<MBADDKCFDLI> JKHIHMDMKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA5BAF96802914B4", Offset = "0x0", VA = "0xA5BAF98002914B4", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x291559802914B4", Offset = "0x0", VA = "0x29155B002914B4", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KHECJJJIFBB<Guid> PPKGHDFBAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2915598A7C489C", Offset = "0x0", VA = "0x29155B0A7C489C", Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA7C48B6802915AC", Offset = "0x0", VA = "0xA7C48B8002915AC", Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2915B0802915AC", Offset = "0x0", VA = "0x2915B2002915AC", Slot = "6")]
	Task<BCLNLKLFCPB<MBADDKCFDLI, string>> OFOGDCMPIAL(long FNKMOIJJLLC, string KJPHMNNIMDP, string PADNFDKMCHE, string CPGBJNDENLC, int MOBOCAMNDBJ, LMBFNEAFENH HMDAEPELHPE, [Optional] Dictionary<Guid, int> NLPOJJPLDHK, [Optional] Guid? GCCFGEODKIC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2915B08A7C48C8", Offset = "0x0", VA = "0x2915B20A7C48C8", Slot = "7")]
	Task<BCLNLKLFCPB<MBADDKCFDLI, string>> FEPGPKPECJF(Guid MNLAOAAAPCD, string KJPHMNNIMDP, string PADNFDKMCHE, string CPGBJNDENLC, int MOBOCAMNDBJ, LMBFNEAFENH HMDAEPELHPE, [Optional] Dictionary<Guid, int> NLPOJJPLDHK, [Optional] Guid? GCCFGEODKIC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA7C48B680291603", Offset = "0x0", VA = "0xA7C48B800291603", Slot = "8")]
	Task<BCLNLKLFCPB<bool, string>> PEEBPBOFCKO(Guid MNLAOAAAPCD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29163380291610", Offset = "0x0", VA = "0x29163500291610", Slot = "9")]
	IEnumerable<MBADDKCFDLI> FHAKHFJMOHF();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2916338A5B627C", Offset = "0x0", VA = "0x2916350A5B627C", Slot = "10")]
	Task<List<KGCBJGFLFIL>> BHLKNGPJLPL(long FNKMOIJJLLC, [Optional] CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA7C32BA802916EE", Offset = "0x0", VA = "0xA7C32BC002916EE", Slot = "11")]
	bool POHPGOOACHB(Guid MNLAOAAAPCD, [Out] MBADDKCFDLI PACBBFMGBPL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29173D802916EE", Offset = "0x0", VA = "0x29173F002916EE", Slot = "12")]
	bool KLCBJHDNLFL(Guid MNLAOAAAPCD, int OCCJFNMCPPB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29173D8A7C32D8", Offset = "0x0", VA = "0x29173F0A7C32D8", Slot = "13")]
	void COLPPBBPEKD(PDPPFLAPOCL JDDNDMPDAKN, Guid MNLAOAAAPCD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA7C32E680291745", Offset = "0x0", VA = "0xA7C32E800291745", Slot = "14")]
	Task<int> NMIOPDPODMB(PDPPFLAPOCL JDDNDMPDAKN, Guid MNLAOAAAPCD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x29179480291745", Offset = "0x0", VA = "0x29179600291745", Slot = "15")]
	bool CIGPNPHDHFM();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29179E8A7C32D8", Offset = "0x0", VA = "0x2917A00A7C32D8", Slot = "16")]
	bool AKHJOJLPKIK(Guid LILBGFPIHAH, [Out] List<string> EMDFAIFONJM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA5B627A802917C5", Offset = "0x0", VA = "0xA5B627C002917C5", Slot = "17")]
	Task<BCLNLKLFCPB<bool, string>> FIHFECPIPEL(MBADDKCFDLI PACBBFMGBPL, long MPJBCCCKHNN, int OGKJJPEBIOK, [Optional] string BOHJMMJDHCK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CFHKKLBDKPB
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29187C802917C5", Offset = "0x0", VA = "0x29187E002917C5", Slot = "0")]
	void GOOLIBEBIIN(Guid IADJLLLDDPB, string BOHJMMJDHCK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29187C8A7C2B7C", Offset = "0x0", VA = "0x29187E0A7C2B7C", Slot = "1")]
	void GNJAOLNEMKK(Guid IADJLLLDDPB, string BOHJMMJDHCK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA7C2B96802918CF", Offset = "0x0", VA = "0xA7C2B98002918CF", Slot = "2")]
	void DNBPIBCANOL(Guid IADJLLLDDPB, int OGKJJPEBIOK);
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

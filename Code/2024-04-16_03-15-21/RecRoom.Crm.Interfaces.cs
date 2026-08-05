using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BBKMJIEEOGC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x245134802450E5", Offset = "0x0", VA = "0x245136002450E5", Slot = "0")]
	void JBBKDDIMAHC(string PPFKKCMONPM, string ACDAMDLACDC, bool OPFDFPBHIOO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24513E899A0900", Offset = "0x0", VA = "0x245140099A0900", Slot = "1")]
	void NJPCPEFKAKG();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x988C19A80245165", Offset = "0x0", VA = "0x988C19C00245165", Slot = "2")]
	void MOEJGEJBIKK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24520480245165", Offset = "0x0", VA = "0x24520600245165", Slot = "3")]
	void LBIFEFMJLAD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x245204899A2304", Offset = "0x0", VA = "0x245206099A2304", Slot = "4")]
	void BGFGJFKHPOO(string EKIDEPBKGEL, [Optional] string DDMLMGKNDDM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LNCHGOKGNIB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DIDIEBDLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99A231E80245257", Offset = "0x0", VA = "0x99A232000245257", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GGFGILLLCFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GDLEDDNLPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24525B80245257", Offset = "0x0", VA = "0x24525D00245257", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NCPIHKLHIIK> NIFGABMFAKM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2452D3802452B0", Offset = "0x0", VA = "0x2452D5002452B0", Slot = "3")]
	Task MEJEOBIHPJE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2452D38988C19C", Offset = "0x0", VA = "0x2452D50988C19C", Slot = "4")]
	void GKFNPGBHNDK();
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

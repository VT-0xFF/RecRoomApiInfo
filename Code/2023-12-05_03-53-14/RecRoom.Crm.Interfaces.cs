using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OMBJPMEBJAF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x914151A802337B4", Offset = "0x0", VA = "0x914151C002337B4", Slot = "0")]
	void PAPFPNIFIDG(string LKOCJEIHAIE, string OJECEFKHMIM, bool JOJHFLEAGNI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x233847802337B4", Offset = "0x0", VA = "0x233849002337B4", Slot = "1")]
	void KJHDOCCPICN();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x233847893284E8", Offset = "0x0", VA = "0x233849093284E8", Slot = "2")]
	void LALMGBCLKDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x93285028023389A", Offset = "0x0", VA = "0x93285040023389A", Slot = "3")]
	void KMGIOLOHAGA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23389E8023389A", Offset = "0x0", VA = "0x2338A00023389A", Slot = "4")]
	void EHLLICAILPC(string BBDMLGPBHLI, [Optional] string MPPGIAGOGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EJKLLGBGNFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BCGLPDFOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23389E89328514", Offset = "0x0", VA = "0x2338A009328514", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AFEINBMHMBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OMAALEMAAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9328502802338F1", Offset = "0x0", VA = "0x9328504002338F1", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JHFFKAAKJLP> MDNMOIFEJME;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x93278C6802339DA", Offset = "0x0", VA = "0x93278C8002339DA", Slot = "3")]
	Task GJHPIDDJMKM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x233A29802339DA", Offset = "0x0", VA = "0x233A2B002339DA", Slot = "4")]
	void MADHOJJNIDP();
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

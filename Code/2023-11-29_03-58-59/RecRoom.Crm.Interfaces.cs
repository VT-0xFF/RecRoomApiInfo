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
	[Cpp2IlInjected.Address(RVA = "0x2335118023350D", Offset = "0x0", VA = "0x2335130023350D", Slot = "0")]
	void PAPFPNIFIDG(string LKOCJEIHAIE, string OJECEFKHMIM, bool JOJHFLEAGNI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23351189329228", Offset = "0x0", VA = "0x23351309329228", Slot = "1")]
	void KJHDOCCPICN();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x932921680233564", Offset = "0x0", VA = "0x932921800233564", Slot = "2")]
	void LALMGBCLKDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23359380233570", Offset = "0x0", VA = "0x23359500233570", Slot = "3")]
	void KMGIOLOHAGA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x233593891928E0", Offset = "0x0", VA = "0x233595091928E0", Slot = "4")]
	void EHLLICAILPC(string BBDMLGPBHLI, [Optional] string MPPGIAGOGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EJKLLGBGNFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BCGLPDFOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9327C9A80233634", Offset = "0x0", VA = "0x9327C9C00233634", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0x23368380233634", Offset = "0x0", VA = "0x23368500233634", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JHFFKAAKJLP> MDNMOIFEJME;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2336DA8023368B", Offset = "0x0", VA = "0x2336DC0023368B", Slot = "3")]
	Task GJHPIDDJMKM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2336DE89327CB8", Offset = "0x0", VA = "0x2336E009327CB8", Slot = "4")]
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

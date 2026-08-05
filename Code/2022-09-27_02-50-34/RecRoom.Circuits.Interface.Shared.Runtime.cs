using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DMKNIDCKJEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NAEJNKDOELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x794365A801793E7", Offset = "0x0", VA = "0x794365C001793E7", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1794B2801793F0", Offset = "0x0", VA = "0x1794B4001793F0", Slot = "1")]
	void BKNCMNINOLG(string JFLKGPEABBP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1794FE8794365C", Offset = "0x0", VA = "0x1795000794365C", Slot = "2")]
	void CBHHJKNBFBL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x794366E8017954A", Offset = "0x0", VA = "0x79436700017954A", Slot = "3")]
	void GAIBDEJGDCF(string HGHEMBBLDIC);
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

using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CFKANHJCJBB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE32A8029B228", Offset = "0x0", VA = "0xA9BE32C0029B228", Slot = "0")]
	void PKELKJJEMAA(object APPINHJJCPL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29B22C8029B228", Offset = "0x0", VA = "0x29B22E0029B228", Slot = "1")]
	void GKKGACKCIFK(object APPINHJJCPL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29B22C8A9BE33C", Offset = "0x0", VA = "0x29B22E0A9BE33C", Slot = "2")]
	void MLPOCEDOOEN(object APPINHJJCPL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE32A8029B27F", Offset = "0x0", VA = "0xA9BE32C0029B27F", Slot = "3")]
	void JMINEGBAPKF(object OMHMFLHBNDJ, string BIFHNMDIJFJ, params object[] CJLBFJEOAOD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29B2A28029B280", Offset = "0x0", VA = "0x29B2A40029B280", Slot = "4")]
	void NBABLAMEJFE(Exception LGAEDPBIIBH);
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

using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OOHNMPDBDKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2BC818802BC7E0", Offset = "0x0", VA = "0x2BC81A002BC7E0", Slot = "0")]
	void GICKCNCALPG(object CGFIKJKJOPN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2BC81E87AC9574", Offset = "0x0", VA = "0x2BC82007AC9574", Slot = "1")]
	void OLBPMFKMEEG(object CGFIKJKJOPN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B15CD6802BC8A3", Offset = "0x0", VA = "0x7B15CD8002BC8A3", Slot = "2")]
	void IEFBBADHFBO(object CGFIKJKJOPN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8FC802BC8B0", Offset = "0x0", VA = "0x2BC8FE002BC8B0", Slot = "3")]
	void EIOECGDMLLH(object IEGGGFEMEIG, string ODADACHNCFJ, params object[] NHMGHNFFDAC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8FE87ACC478", Offset = "0x0", VA = "0x2BC90007ACC478", Slot = "4")]
	void HIDCPPFEOHB(Exception KODAIHDNBNM);
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

using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IJBPODBAIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28EF0E88D336C0", Offset = "0x0", VA = "0x28EF1008D336C0", Slot = "0")]
	void EBBBCGBJAMD(object IHHCPPEACEL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8D336BE8028EF40", Offset = "0x0", VA = "0x8D336C00028EF40", Slot = "1")]
	void KCDPBEAKICC(object IHHCPPEACEL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28EF6C8028EF40", Offset = "0x0", VA = "0x28EF6E0028EF40", Slot = "2")]
	void HCKGDGCKGDE(object IHHCPPEACEL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28EF6E88D336C0", Offset = "0x0", VA = "0x28EF7008D336C0", Slot = "3")]
	void HMJPIEMINIO(object HBLIBBFCHOD, string GGIBFNEFEKK, params object[] JMLOLLOGKEE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8D32E3A8028EFD6", Offset = "0x0", VA = "0x8D32E3C0028EFD6", Slot = "4")]
	void FPKDEEJGEFP(Exception AMMLDGPCMMN);
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

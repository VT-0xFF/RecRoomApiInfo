using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KDPJCMIPNDI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x913A12A8023273E", Offset = "0x0", VA = "0x913A12C0023273E", Slot = "0")]
	void JJBLJPHBGMP(object CABFMJIIGKB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23276E80232740", Offset = "0x0", VA = "0x23277000232740", Slot = "1")]
	void MADLBFNHIAJ(object CABFMJIIGKB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23276E8913A12C", Offset = "0x0", VA = "0x2327700913A12C", Slot = "2")]
	void MOICFBOLICL(object CABFMJIIGKB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9138ACE80232796", Offset = "0x0", VA = "0x9138AD000232796", Slot = "3")]
	void MPIKJPMKGKA(object BFDLBONPDOA, string CCDBHMCDPAB, params object[] ODENEMACEPI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2327CA802327A0", Offset = "0x0", VA = "0x2327CC002327A0", Slot = "4")]
	void IJEAKANFJBD(Exception BJFILFAGADB);
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

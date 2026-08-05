using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CHFEFMDBOKH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89B5D76802D6E73", Offset = "0x0", VA = "0x89B5D78002D6E73", Slot = "0")]
	void JMPIMKEPGCC(object EKFPDHJKIFI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EE1802D6E80", Offset = "0x0", VA = "0x2D6EE3002D6E80", Slot = "1")]
	void NILLMIKLNIE(object EKFPDHJKIFI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EEE889B5D78", Offset = "0x0", VA = "0x2D6EF0089B5D78", Slot = "2")]
	void FJBPMGCIHDO(object EKFPDHJKIFI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x89B5D82802D6F1C", Offset = "0x0", VA = "0x89B5D84002D6F1C", Slot = "3")]
	void KOPLBGBGIAB(object CNBGAPJABKP, string DLJPLGLNMPN, params object[] DCPGFNKOIOA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F81802D6F20", Offset = "0x0", VA = "0x2D6F83002D6F20", Slot = "4")]
	void BEDJPDADNLD(Exception KNHCPKJGGLL);
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

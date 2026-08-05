using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OIBKIPLCFKG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x224EAA80224E05", Offset = "0x0", VA = "0x224EAC00224E05", Slot = "0")]
	void OPCGADAFALC(object ANEILBIOBIP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x224EAA89091388", Offset = "0x0", VA = "0x224EAC09091388", Slot = "1")]
	void HNIGHEOMACJ(object ANEILBIOBIP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x90913A280224EFD", Offset = "0x0", VA = "0x90913A400224EFD", Slot = "2")]
	void PPNGJCPFMDM(object ANEILBIOBIP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x224F0180224EFD", Offset = "0x0", VA = "0x224F0300224EFD", Slot = "3")]
	void ABJGGAPLEPI(object LIODJEBJPCP, string NODJEJKFPPC, params object[] DDNMEJONMEK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x224F01890913B4", Offset = "0x0", VA = "0x224F03090913B4", Slot = "4")]
	void KKHHGMHFEEG(Exception PADODIHKGMF);
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

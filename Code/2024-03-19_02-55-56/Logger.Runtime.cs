using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HFDHFBJEHPL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2449EA8024499B", Offset = "0x0", VA = "0x2449EC0024499B", Slot = "0")]
	void LFPFJBDDFDP(object IJDHPGKKFNN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2449EE899FD2F8", Offset = "0x0", VA = "0x2449F0099FD2F8", Slot = "1")]
	void FEMOACDEPIA(object IJDHPGKKFNN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x98017EA80244A15", Offset = "0x0", VA = "0x98017EC00244A15", Slot = "2")]
	void HHGJCABCFKG(object IJDHPGKKFNN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x244AB280244A15", Offset = "0x0", VA = "0x244AB400244A15", Slot = "3")]
	void IONIIJIFHCO(object LNLKAOCIPJI, string LKAHAANPPAP, params object[] AFBHAGBGAAM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x244AB2899FCB9C", Offset = "0x0", VA = "0x244AB4099FCB9C", Slot = "4")]
	void NNPBFMNBJLK(Exception KGGEIOKLINA);
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

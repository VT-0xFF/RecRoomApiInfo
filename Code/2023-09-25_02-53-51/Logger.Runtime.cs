using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MEFINKCPADA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2243D9802243D5", Offset = "0x0", VA = "0x2243DB002243D5", Slot = "0")]
	void IJCNCIMJJJN(object AABDFOONPNL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2243D9890B3F78", Offset = "0x0", VA = "0x2243DB090B3F78", Slot = "1")]
	void KMECECAIKPF(object AABDFOONPNL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x90B3F668022442C", Offset = "0x0", VA = "0x90B3F680022442C", Slot = "2")]
	void DBDIOOJNOCJ(object AABDFOONPNL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2244C680224430", Offset = "0x0", VA = "0x2244C800224430", Slot = "3")]
	void MLBKPMGIFPO(object CNKGFJIJGPA, string AFHDKJPDCMJ, params object[] LHPGBFGMEDK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2244CE88ECB38C", Offset = "0x0", VA = "0x2244D008ECB38C", Slot = "4")]
	void KHOPFOOFEEJ(Exception ACDFONNILGA);
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

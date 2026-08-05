using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ABOPJMGLBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8A3E88A8024CE17", Offset = "0x0", VA = "0x8A3E88C0024CE17", Slot = "0")]
	void GMDPMBHBMHO(object LHCMKIAHBCL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24CE5E8024CE17", Offset = "0x0", VA = "0x24CE600024CE17", Slot = "1")]
	void LANMENEBCCI(object LHCMKIAHBCL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24CE5E88A3E87C", Offset = "0x0", VA = "0x24CE6008A3E87C", Slot = "2")]
	void IGJAGIEBANG(object LHCMKIAHBCL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8A3A9768024CE89", Offset = "0x0", VA = "0x8A3A9780024CE89", Slot = "3")]
	void CNAKOFFGMFL(object JDFBABENAGD, string EDOFEKLODKJ, params object[] LCGFCGNMPHN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24CF458024CE89", Offset = "0x0", VA = "0x24CF470024CE89", Slot = "4")]
	void NIDIKBENFKN(Exception MGCANHHBOBI);
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

using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PCJJBDFPBKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA8ACA1A8028E158", Offset = "0x0", VA = "0xA8ACA1C0028E158", Slot = "0")]
	void GHFFBIFPAGE(object HOKLECPLLKF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28E1A78028E158", Offset = "0x0", VA = "0x28E1A90028E158", Slot = "1")]
	void PDMELOEAEMA(object HOKLECPLLKF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28E1A78A8ACA38", Offset = "0x0", VA = "0x28E1A90A8ACA38", Slot = "2")]
	void NILLNCBIFOE(object HOKLECPLLKF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA8ACA468028E1AF", Offset = "0x0", VA = "0xA8ACA480028E1AF", Slot = "3")]
	void KPFMDGGKJEN(object PDMONEGPHPK, string DNBEJMJLODH, params object[] JIAHCJFCHOA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28E1FE8028E1AF", Offset = "0x0", VA = "0x28E2000028E1AF", Slot = "4")]
	void MHECLAALKFO(Exception ELJPDDNBAFK);
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

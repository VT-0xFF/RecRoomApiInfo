using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ENCPAGENDDF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AEE87D14604", Offset = "0x0", VA = "0x2C1AF007D14604", Slot = "0")]
	void KAENCIOMIKC(object MCHCOEKKPGN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D1477E802C1BD7", Offset = "0x0", VA = "0x7D14780002C1BD7", Slot = "1")]
	void JMLEDMNKBAL(object MCHCOEKKPGN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CDD802C1BE0", Offset = "0x0", VA = "0x2C1CDF002C1BE0", Slot = "2")]
	void OJGGPFBMBLK(object MCHCOEKKPGN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CDE87D14740", Offset = "0x0", VA = "0x2C1CE007D14740", Slot = "3")]
	void GCJPJENOLIB(object KPEPJOHCOMD, string LPHAFHGMPHB, params object[] GLNACLILDAP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D14602802C1D39", Offset = "0x0", VA = "0x7D14604002C1D39", Slot = "4")]
	void DDKMGADFJLO(Exception POPOANAACFM);
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

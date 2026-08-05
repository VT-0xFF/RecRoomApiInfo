using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CNEHIJMIJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2B457D802B452E", Offset = "0x0", VA = "0x2B457F002B452E", Slot = "0")]
	void LDCMEBNGNBB(object GGCNADGKGHO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2B457D8ACF509C", Offset = "0x0", VA = "0x2B457F0ACF509C", Slot = "1")]
	void HMENLDAHMFF(object GGCNADGKGHO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xACF50AA802B4585", Offset = "0x0", VA = "0xACF50AC002B4585", Slot = "2")]
	void FLFHHGHPOFJ(object GGCNADGKGHO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B45D4802B4585", Offset = "0x0", VA = "0x2B45D6002B4585", Slot = "3")]
	void MMIMPPICCEN(object NOIHGGNEIML, string LAKAMCGCHJB, params object[] DCNLGGHAIIP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B45DE8ACF509C", Offset = "0x0", VA = "0x2B45E00ACF509C", Slot = "4")]
	void AOPIFNDGGEI(Exception ANOAFKDKLKA);
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

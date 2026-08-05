using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NILNDPCCLIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AF20B2802C587F", Offset = "0x0", VA = "0x7AF20B4002C587F", Slot = "0")]
	void NDPGLCAACEE(object ICGADBEDOKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2C58DD802C58C0", Offset = "0x0", VA = "0x2C58DF002C58C0", Slot = "1")]
	void MLELIFDMLCO(object ICGADBEDOKK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C58DE87AF20B4", Offset = "0x0", VA = "0x2C58E007AF20B4", Slot = "2")]
	void BNCJEJEKKDP(object ICGADBEDOKK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B568A6802C596F", Offset = "0x0", VA = "0x7B568A8002C596F", Slot = "3")]
	void IAPOFPMPPKD(object MAFDHEKFLMG, string CBMJIKPEMCL, params object[] FKNKEJLLBEP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AF3802C5980", Offset = "0x0", VA = "0x2C5AF5002C5980", Slot = "4")]
	void CEGKELFPDAM(Exception KODHGAIEAOC);
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

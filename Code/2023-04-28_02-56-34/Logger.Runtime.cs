using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NHOBFCMCDOK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2E03788839FA4C", Offset = "0x0", VA = "0x2E037A0839FA4C", Slot = "0")]
	void BMBLFHKAJNC(object JFFPIFJCILI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x839FA3A802E03C3", Offset = "0x0", VA = "0x839FA3C002E03C3", Slot = "1")]
	void KKMEEEPEJPP(object JFFPIFJCILI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E03F5802E03D0", Offset = "0x0", VA = "0x2E03F7002E03D0", Slot = "2")]
	void MCFEJMHAGOD(object JFFPIFJCILI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E03F5882C99B8", Offset = "0x0", VA = "0x2E03F7082C99B8", Slot = "3")]
	void ICCPFEPHODG(object PKDAKJPDDGD, string MAGHGMIOMCC, params object[] FKFCAPAEHKO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x839F696802E04AD", Offset = "0x0", VA = "0x839F698002E04AD", Slot = "4")]
	void LEOIFHKKJAG(Exception JIBCJCBDLGH);
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

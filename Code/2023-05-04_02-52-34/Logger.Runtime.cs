using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NHOBFCMCDOK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2E9223883D5B78", Offset = "0x0", VA = "0x2E9225083D5B78", Slot = "0")]
	void BMBLFHKAJNC(object JFFPIFJCILI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x83D5B8A802E9256", Offset = "0x0", VA = "0x83D5B8C002E9256", Slot = "1")]
	void KKMEEEPEJPP(object JFFPIFJCILI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E925F802E9256", Offset = "0x0", VA = "0x2E9261002E9256", Slot = "2")]
	void MCFEJMHAGOD(object JFFPIFJCILI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E925F883D5B9C", Offset = "0x0", VA = "0x2E9261083D5B9C", Slot = "3")]
	void ICCPFEPHODG(object PKDAKJPDDGD, string MAGHGMIOMCC, params object[] FKFCAPAEHKO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83D5BAA802E9267", Offset = "0x0", VA = "0x83D5BAC002E9267", Slot = "4")]
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

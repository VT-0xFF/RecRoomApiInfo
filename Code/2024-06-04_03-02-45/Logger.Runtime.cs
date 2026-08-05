using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KOLINNPELBE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2762748A2C6484", Offset = "0x0", VA = "0x2762760A2C6484", Slot = "0")]
	void CPICANFMBIK(object LPJFGGMIIEB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA2C649E802762C7", Offset = "0x0", VA = "0xA2C64A0002762C7", Slot = "1")]
	void FEIEOIOHKJJ(object LPJFGGMIIEB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2762CB802762C7", Offset = "0x0", VA = "0x2762CD002762C7", Slot = "2")]
	void CODFCBACCFD(object LPJFGGMIIEB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2762CB8A2C64B0", Offset = "0x0", VA = "0x2762CD0A2C64B0", Slot = "3")]
	void KKCGOBDCLOH(object BHFMOMNKABO, string NFAJBIAKHPK, params object[] EKJLJLJONBC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA2C649E8027631E", Offset = "0x0", VA = "0xA2C64A00027631E", Slot = "4")]
	void BDLOOEDHKPI(Exception KAGEPDCJNNE);
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

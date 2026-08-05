using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CICIOHJMEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28FB8D8028FB3E", Offset = "0x0", VA = "0x28FB8F0028FB3E", Slot = "0")]
	void OJMFFMAGFPH(object FPPDOFKLJHI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28FB8D8A7C3D78", Offset = "0x0", VA = "0x28FB8F0A7C3D78", Slot = "1")]
	void JGMEBBODIKH(object FPPDOFKLJHI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA7C3D868028FB95", Offset = "0x0", VA = "0xA7C3D880028FB95", Slot = "2")]
	void BAFDALIIBIE(object FPPDOFKLJHI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28FBE48028FB95", Offset = "0x0", VA = "0x28FBE60028FB95", Slot = "3")]
	void FMFDMFOAJIN(object EIGKPCONJCB, string OJCKNPDLJJF, params object[] AAAOIGBEBAB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28FBEE8A7C3D78", Offset = "0x0", VA = "0x28FBF00A7C3D78", Slot = "4")]
	void CGGKMGOEAMC(Exception LAHIFJKDMEM);
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

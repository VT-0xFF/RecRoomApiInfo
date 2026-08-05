using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CICIOHJMEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x287A0E8A6A9298", Offset = "0x0", VA = "0x287A100A6A9298", Slot = "0")]
	void OJMFFMAGFPH(object FPPDOFKLJHI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA488A8280287A35", Offset = "0x0", VA = "0xA488A8400287A35", Slot = "1")]
	void JGMEBBODIKH(object FPPDOFKLJHI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x287AFC80287A35", Offset = "0x0", VA = "0x287AFE00287A35", Slot = "2")]
	void BAFDALIIBIE(object FPPDOFKLJHI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x287AFC8A6A7D7C", Offset = "0x0", VA = "0x287AFE0A6A7D7C", Slot = "3")]
	void FMFDMFOAJIN(object EIGKPCONJCB, string OJCKNPDLJJF, params object[] AAAOIGBEBAB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA6A7D9680287B4F", Offset = "0x0", VA = "0xA6A7D9800287B4F", Slot = "4")]
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

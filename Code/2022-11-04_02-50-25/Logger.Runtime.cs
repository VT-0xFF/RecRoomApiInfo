using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HBPOPKLDDIA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x764C75A802A54C3", Offset = "0x0", VA = "0x764C75C002A54C3", Slot = "0")]
	void FAPEDBEJAFN(object PDHCNHGCAHC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A5523802A54C3", Offset = "0x0", VA = "0x2A5525002A54C3", Slot = "1")]
	void DMAOCAEJLEK(object PDHCNHGCAHC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A55238764C770", Offset = "0x0", VA = "0x2A55250764C770", Slot = "2")]
	void NMFHFCNCOGB(object PDHCNHGCAHC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x764C786802A553D", Offset = "0x0", VA = "0x764C788002A553D", Slot = "3")]
	void KGBENDMEGJJ(object IDEIPFIOJKJ, string JACFEBHLKLA, params object[] LBFFDNKPEBE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A556A802A553D", Offset = "0x0", VA = "0x2A556C002A553D", Slot = "4")]
	void HLFMCFJLPEP(Exception GCOPFBLODIP);
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

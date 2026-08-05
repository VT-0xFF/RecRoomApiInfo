using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GOLAIFJFJFA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA777196802A23D5", Offset = "0x0", VA = "0xA777198002A23D5", Slot = "0")]
	void KGPNCCLAFMC(object DFDLACHAHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A249C802A23D5", Offset = "0x0", VA = "0x2A249E002A23D5", Slot = "1")]
	void NPJNPINPGOP(object DFDLACHAHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A249C8A9AA4F0", Offset = "0x0", VA = "0x2A249E0A9AA4F0", Slot = "2")]
	void NJHAKNOPGIO(object DFDLACHAHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA9AA50A802A24EF", Offset = "0x0", VA = "0xA9AA50C002A24EF", Slot = "3")]
	void BHEEINEAEPN(object JCPOMHNJOIE, string BJFFNJGHPDD, params object[] HJEECPNIDIG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A24F3802A24EF", Offset = "0x0", VA = "0x2A24F5002A24EF", Slot = "4")]
	void JKJEFNMOBEN(Exception BIHGENFKIAE);
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

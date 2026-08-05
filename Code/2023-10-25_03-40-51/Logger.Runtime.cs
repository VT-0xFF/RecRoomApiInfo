using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KNIGOHBLMAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9DDE8022D454", Offset = "0x0", VA = "0x8EF9DE00022D454", Slot = "0")]
	void BPAIBICBBJL(object DFCBIKLJFPD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22D4E78022D454", Offset = "0x0", VA = "0x22D4E90022D454", Slot = "1")]
	void OEGGIANHCJN(object DFCBIKLJFPD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22D4E7890AD8FC", Offset = "0x0", VA = "0x22D4E9090AD8FC", Slot = "2")]
	void BNJKOEGGPFA(object DFCBIKLJFPD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x90AD9168022D53A", Offset = "0x0", VA = "0x90AD9180022D53A", Slot = "3")]
	void EMIDOENHLMK(object DDMHMHFODEB, string GEACENBCPHD, params object[] MEALCFKPKME);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22D53E8022D53A", Offset = "0x0", VA = "0x22D5400022D53A", Slot = "4")]
	void LPIFGLLPDKC(Exception GAGKDENINAJ);
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

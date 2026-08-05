using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JPOEPDBMJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27A27E8A162DFC", Offset = "0x0", VA = "0x27A2800A162DFC", Slot = "0")]
	void NEKMHMJECLN(object MMCLBKHCHDA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA16539E8027A31B", Offset = "0x0", VA = "0xA1653A00027A31B", Slot = "1")]
	void OGMGDLIKAKP(object MMCLBKHCHDA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27A39E8027A320", Offset = "0x0", VA = "0x27A3A00027A320", Slot = "2")]
	void FPLONKHBNMC(object MMCLBKHCHDA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27A39E8A160D0C", Offset = "0x0", VA = "0x27A3A00A160D0C", Slot = "3")]
	void LPHNGBKHACF(object NMIKEFKOPMC, string DNDIAOIJGOO, params object[] JEKDODJMDHN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA17DA268027A456", Offset = "0x0", VA = "0xA17DA280027A456", Slot = "4")]
	void HCCFHGNLNMP(Exception LAPJEJLKEKK);
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

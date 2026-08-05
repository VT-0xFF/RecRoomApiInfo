using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void NFCEFKHBPLO(KLHKIJHKJFB IBFKFNLEDKN, Entity BODOHICDFAL, EntityManager JOKFOKELNGA);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MNEBACPACPN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KLHKIJHKJFB, LCDDHADEHJF, NFCEFKHBPLO)> KGDGEFIFDEO(EODDOIBLEIP BCDJFKMHLLG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EODDOIBLEIP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IELMBOEFPKD, KLHKIJHKJFB)> CCJPNMOLCBI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class KLFNHPJFBGE : CKGBMCJBKPM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public KLFNHPJFBGE()
	{
	}
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

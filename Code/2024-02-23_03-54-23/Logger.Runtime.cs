using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DICBJLADGGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23BCD38023BCCF", Offset = "0x0", VA = "0x23BCD50023BCCF", Slot = "0")]
	void BDAJDFAFKKC(object HILPECKCPNP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23BCD389712300", Offset = "0x0", VA = "0x23BCD509712300", Slot = "1")]
	void AGKLEKFKKEI(object HILPECKCPNP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x97122EE8023BD26", Offset = "0x0", VA = "0x97122F00023BD26", Slot = "2")]
	void EIOKCLMHEHA(object HILPECKCPNP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23BD528023BD30", Offset = "0x0", VA = "0x23BD540023BD30", Slot = "3")]
	void MOJGEKPLGFC(object PEHINKLIDNC, string CLNBNIFIABA, params object[] AHLEFKCGEBC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23BD5289525D30", Offset = "0x0", VA = "0x23BD5409525D30", Slot = "4")]
	void LOHEEKGGMHP(Exception NGHCMOPLFIN);
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

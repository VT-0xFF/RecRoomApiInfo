using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DICBJLADGGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x94E139E802380B5", Offset = "0x0", VA = "0x94E13A0002380B5", Slot = "0")]
	void BDAJDFAFKKC(object HILPECKCPNP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2380B9802380B5", Offset = "0x0", VA = "0x2380BB002380B5", Slot = "1")]
	void AGKLEKFKKEI(object HILPECKCPNP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2380B9894E13B0", Offset = "0x0", VA = "0x2380BB094E13B0", Slot = "2")]
	void EIOKCLMHEHA(object HILPECKCPNP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x94E139E8023810C", Offset = "0x0", VA = "0x94E13A00023810C", Slot = "3")]
	void MOJGEKPLGFC(object PEHINKLIDNC, string CLNBNIFIABA, params object[] AHLEFKCGEBC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23813380238110", Offset = "0x0", VA = "0x23813500238110", Slot = "4")]
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

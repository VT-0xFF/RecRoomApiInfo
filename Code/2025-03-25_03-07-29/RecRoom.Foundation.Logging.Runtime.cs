using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct OIPGGBBFLGE
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x782BAD0", Offset = "0x782AED0", VA = "0x18782BAD0")]
	public static OIPGGBBFLGE MDKCMNAEKLA(ABDDJEPKCOD LEMJHEDOKDF)
	{
		return default(OIPGGBBFLGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x782BBB0", Offset = "0x782AFB0", VA = "0x18782BBB0")]
	public OIPGGBBFLGE(ABDDJEPKCOD LEMJHEDOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x782BAF0", Offset = "0x782AEF0", VA = "0x18782BAF0")]
	public void LMAJAPFLJFK([In] FixedString128Bytes DBFOBELGJDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CNLPKDPEPML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x782BAD0", Offset = "0x782AED0", VA = "0x18782BAD0")]
	public static OIPGGBBFLGE OGNFHJDGKDN(this ABDDJEPKCOD LEMJHEDOKDF)
	{
		return default(OIPGGBBFLGE);
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

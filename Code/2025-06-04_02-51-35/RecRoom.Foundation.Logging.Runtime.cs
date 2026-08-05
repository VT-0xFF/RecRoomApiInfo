using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct KCMKKNMOMLD
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FB78F0", Offset = "0x7FB60F0", VA = "0x187FB78F0")]
	public static KCMKKNMOMLD KEINEINMKGA(BMELPJIFPCL GLHOMCPEEHH)
	{
		return default(KCMKKNMOMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FB79D0", Offset = "0x7FB61D0", VA = "0x187FB79D0")]
	public KCMKKNMOMLD(BMELPJIFPCL GLHOMCPEEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7910", Offset = "0x7FB6110", VA = "0x187FB7910")]
	public void GNLEBEMCOJM([In] FixedString128Bytes FIBFJHPJKOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ANKHDJJJAOM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FB78F0", Offset = "0x7FB60F0", VA = "0x187FB78F0")]
	public static KCMKKNMOMLD ABLPKHPKPGG(this BMELPJIFPCL GLHOMCPEEHH)
	{
		return default(KCMKKNMOMLD);
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

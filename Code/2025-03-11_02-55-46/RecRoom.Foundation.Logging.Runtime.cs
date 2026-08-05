using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct JKLLMNIDIJM
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75FD7D0", Offset = "0x75FCBD0", VA = "0x1875FD7D0")]
	public static JKLLMNIDIJM JKGHIELMIOO(HLBHMADGLFA GCIBFPDCNDK)
	{
		return default(JKLLMNIDIJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75FD7F0", Offset = "0x75FCBF0", VA = "0x1875FD7F0")]
	public JKLLMNIDIJM(HLBHMADGLFA GCIBFPDCNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75FD710", Offset = "0x75FCB10", VA = "0x1875FD710")]
	public void IBIHEEBAPEC([In] FixedString128Bytes KDFEGOCHHNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OFNMJOMIHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75FD7D0", Offset = "0x75FCBD0", VA = "0x1875FD7D0")]
	public static JKLLMNIDIJM IANBHEHPNND(this HLBHMADGLFA GCIBFPDCNDK)
	{
		return default(JKLLMNIDIJM);
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

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct OBKHFCPPOFB
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75171C0", Offset = "0x75157C0", VA = "0x1875171C0")]
	public static OBKHFCPPOFB HEGJABMHLEC(IBCMILIKEJG DDKJAEALMGF)
	{
		return default(OBKHFCPPOFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75172A0", Offset = "0x75158A0", VA = "0x1875172A0")]
	public OBKHFCPPOFB(IBCMILIKEJG DDKJAEALMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75171E0", Offset = "0x75157E0", VA = "0x1875171E0")]
	public void IOEKNDJEAJM([In] FixedString128Bytes GIFBANFPJGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JDDNDAKKGJF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75171C0", Offset = "0x75157C0", VA = "0x1875171C0")]
	public static OBKHFCPPOFB KLACFPPOKCB(this IBCMILIKEJG DDKJAEALMGF)
	{
		return default(OBKHFCPPOFB);
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

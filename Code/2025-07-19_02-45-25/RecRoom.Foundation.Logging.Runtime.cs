using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct ABJLBJBDBFA
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81868F0", Offset = "0x81858F0", VA = "0x1881868F0")]
	public static ABJLBJBDBFA MJOOONLKLLN(ONIHMLNNEEF EFJNGOKNPIL)
	{
		return default(ABJLBJBDBFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8186910", Offset = "0x8185910", VA = "0x188186910")]
	public ABJLBJBDBFA(ONIHMLNNEEF EFJNGOKNPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8186830", Offset = "0x8185830", VA = "0x188186830")]
	public void GMJFKJBABOF([In] FixedString128Bytes NGKMMOMPFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKKOJPMCADA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81868F0", Offset = "0x81858F0", VA = "0x1881868F0")]
	public static ABJLBJBDBFA BAPMOCIABGF(this ONIHMLNNEEF EFJNGOKNPIL)
	{
		return default(ABJLBJBDBFA);
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

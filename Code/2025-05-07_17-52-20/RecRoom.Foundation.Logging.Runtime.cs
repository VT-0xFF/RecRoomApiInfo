using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct KDFKAHGAOEH
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BFA0", Offset = "0x7C7AFA0", VA = "0x187C7BFA0")]
	public static KDFKAHGAOEH OIFHDJNIHDL(JBBHIJHGEPM PAJIGEJCNAP)
	{
		return default(KDFKAHGAOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BFC0", Offset = "0x7C7AFC0", VA = "0x187C7BFC0")]
	public KDFKAHGAOEH(JBBHIJHGEPM PAJIGEJCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BEE0", Offset = "0x7C7AEE0", VA = "0x187C7BEE0")]
	public void DHIFPOPFCLO([In] FixedString128Bytes ANKDPLMACBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PHOPOCFEBED
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BFA0", Offset = "0x7C7AFA0", VA = "0x187C7BFA0")]
	public static KDFKAHGAOEH BIPDJFDCEDO(this JBBHIJHGEPM PAJIGEJCNAP)
	{
		return default(KDFKAHGAOEH);
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

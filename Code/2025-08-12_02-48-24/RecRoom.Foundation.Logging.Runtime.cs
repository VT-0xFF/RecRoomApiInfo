using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct PBOENNNNPFH
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8477490", Offset = "0x8475A90", VA = "0x188477490")]
	public static PBOENNNNPFH HPNBGLLBBBG(IDGHEFJHGEI FEFALLLFAGB)
	{
		return default(PBOENNNNPFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8477570", Offset = "0x8475B70", VA = "0x188477570")]
	public PBOENNNNPFH(IDGHEFJHGEI FEFALLLFAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84774B0", Offset = "0x8475AB0", VA = "0x1884774B0")]
	public void BBAMHENPGLL([In] FixedString128Bytes IAKFGDELOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HCIPJEINLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8477490", Offset = "0x8475A90", VA = "0x188477490")]
	public static PBOENNNNPFH AMKDPDCHKLJ(this IDGHEFJHGEI FEFALLLFAGB)
	{
		return default(PBOENNNNPFH);
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

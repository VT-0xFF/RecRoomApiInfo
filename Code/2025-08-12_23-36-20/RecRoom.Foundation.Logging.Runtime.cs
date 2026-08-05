using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct DJADLDGOOAP
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x839E7E0", Offset = "0x839D5E0", VA = "0x18839E7E0")]
	public static DJADLDGOOAP MIDAFINGFAP(ALMLLDBPKBM IPEKLICENHF)
	{
		return default(DJADLDGOOAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x839E800", Offset = "0x839D600", VA = "0x18839E800")]
	public DJADLDGOOAP(ALMLLDBPKBM IPEKLICENHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x839E720", Offset = "0x839D520", VA = "0x18839E720")]
	public void DBOKEBLPHBF([In] FixedString128Bytes PBHOCHKFEPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KOKLMPGIKMK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x839E7E0", Offset = "0x839D5E0", VA = "0x18839E7E0")]
	public static DJADLDGOOAP JJIJJJMADKN(this ALMLLDBPKBM IPEKLICENHF)
	{
		return default(DJADLDGOOAP);
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

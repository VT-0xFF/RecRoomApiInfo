using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct OCFFNMOJDBP
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7922960", Offset = "0x7921360", VA = "0x187922960")]
	public static OCFFNMOJDBP MEHFEEABIDG(LMPJBEBLCLM BLAHIKOFFGK)
	{
		return default(OCFFNMOJDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7922A40", Offset = "0x7921440", VA = "0x187922A40")]
	public OCFFNMOJDBP(LMPJBEBLCLM BLAHIKOFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7922980", Offset = "0x7921380", VA = "0x187922980")]
	public void CDNOHIHAHHE([In] FixedString128Bytes FHBIJDIKBHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JOABIBJHKDL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7922960", Offset = "0x7921360", VA = "0x187922960")]
	public static OCFFNMOJDBP HMBCLPLCAAD(this LMPJBEBLCLM BLAHIKOFFGK)
	{
		return default(OCFFNMOJDBP);
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

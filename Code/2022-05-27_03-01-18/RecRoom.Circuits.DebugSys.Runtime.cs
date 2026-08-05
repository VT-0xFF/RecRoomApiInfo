using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BLKKGAJFLDC : AAMHCKMDAGP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool IIJGBLKAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x551490", Offset = "0x550490", VA = "0x180551490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private BLKKGAJFLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E38C70", Offset = "0x1E37C70", VA = "0x181E38C70")]
	public static BLKKGAJFLDC CIAOGEOFBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "4")]
	public void IIENMAPCGDB(Func<string> MONHCMBIJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
	public void PJMPHDDNAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E38CC0", Offset = "0x1E37CC0", VA = "0x181E38CC0", Slot = "6")]
	public void HNAKDFJPKGM(object EPAKPJCIEHE)
	{
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

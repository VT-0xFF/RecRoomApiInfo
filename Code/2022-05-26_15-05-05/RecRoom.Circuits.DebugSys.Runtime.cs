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
		[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private BLKKGAJFLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E81980", Offset = "0x4E7FF80", VA = "0x184E81980")]
	public static BLKKGAJFLDC CIAOGEOFBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "4")]
	public void IIENMAPCGDB(Func<string> MONHCMBIJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
	public void PJMPHDDNAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E819D0", Offset = "0x4E7FFD0", VA = "0x184E819D0", Slot = "6")]
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

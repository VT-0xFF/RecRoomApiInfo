using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CEFEOEKPPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CultureInfo NFDADAGFOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6FC0", Offset = "0x5DD5BC0", VA = "0x185DD6FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7000", Offset = "0x5DD5C00", VA = "0x185DD7000")]
	public static bool PGOGCJKJINM(string KICEKCLGKNJ, [Out] float FMIKHKOMIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6FC0", Offset = "0x5DD5BC0", VA = "0x185DD6FC0")]
	private static CultureInfo GAICBJEEHOL()
	{
		return null;
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

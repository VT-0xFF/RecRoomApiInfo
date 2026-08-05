using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JAADLDMLCNC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CultureInfo PFBJKJNLPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8042060", Offset = "0x8040E60", VA = "0x188042060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x80420A0", Offset = "0x8040EA0", VA = "0x1880420A0")]
	public static bool MCJLAKADNGF(string BDLFDEHGIJN, [Out] float HDKAAHALABG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8042060", Offset = "0x8040E60", VA = "0x188042060")]
	private static CultureInfo BBHHMLEOCFK()
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

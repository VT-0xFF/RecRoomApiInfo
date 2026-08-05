using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OHNOKKPKAOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CultureInfo AIGIBEKGOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D50210", Offset = "0x7D4EE10", VA = "0x187D50210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D501A0", Offset = "0x7D4EDA0", VA = "0x187D501A0")]
	public static bool AOAAIPGIELF(string PLDFJIOPMNL, [Out] float OOKIAAGJPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D50210", Offset = "0x7D4EE10", VA = "0x187D50210")]
	private static CultureInfo MIEDCFLBGAJ()
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

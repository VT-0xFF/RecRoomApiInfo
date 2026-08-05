using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class HEBCHIILMLF : CCHJJOJOFGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Guid NMMDGLGKJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCE63C0", Offset = "0xCE57C0", VA = "0x180CE63C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
	public void Bind(EOBJHPIPJLN DPPHJIBJCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public HEBCHIILMLF(Guid DBODHDCBMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xEA51A0", Offset = "0xEA45A0", VA = "0x180EA51A0")]
	public static HEBCHIILMLF CCFMECMIHDM(Guid DBODHDCBMLJ)
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

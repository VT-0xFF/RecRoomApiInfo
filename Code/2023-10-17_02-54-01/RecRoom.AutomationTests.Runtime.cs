using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CGGIDFKBDLE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool COKDKOBHNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2930", Offset = "0x5BF1130", VA = "0x185BF2930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static bool EMLDAIEPEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2980", Offset = "0x5BF1180", VA = "0x185BF2980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool IDAMFGAFBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BF29D0", Offset = "0x5BF11D0", VA = "0x185BF29D0")]
		get
		{
			return default(bool);
		}
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

using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MCJBPJHHFFI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5870", Offset = "0x5CA4670", VA = "0x185CA5870")]
	public static KeepsakeTheme LOFOICJHIFM(this LEEKAEBIADD AMCDJKCDDEF, Guid CANNKHOFJNE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CA57C0", Offset = "0x5CA45C0", VA = "0x185CA57C0")]
	public static KeepsakeTheme LOFOICJHIFM(this LEEKAEBIADD AMCDJKCDDEF, FIFGPMJDIDB EFAHJGJJMIA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5680", Offset = "0x5CA4480", VA = "0x185CA5680")]
	public static List<KeepsakeTheme> AKCIIBNAHDD(this LEEKAEBIADD AMCDJKCDDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5960", Offset = "0x5CA4760", VA = "0x185CA5960")]
	public static FIFGPMJDIDB NFJHAFFNJDA(this LEEKAEBIADD AMCDJKCDDEF, Guid CANNKHOFJNE)
	{
		return default(FIFGPMJDIDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5740", Offset = "0x5CA4540", VA = "0x185CA5740")]
	public static int DMFFHNAAFHN(this LEEKAEBIADD AMCDJKCDDEF, FIFGPMJDIDB BIINJGPDFPI)
	{
		return default(int);
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

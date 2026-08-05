using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NKLKDMBLNDI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int NEADGACLCEH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int ICEINJILNBO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int FJBADGEFHOD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C1B0", Offset = "0x6C5ADB0", VA = "0x186C5C1B0")]
	public static void NFGDBFMGPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BE40", Offset = "0x6C5AA40", VA = "0x186C5BE40")]
	public static void JNJGJCOMEHB(int[] BEJHDCNFAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BF20", Offset = "0x6C5AB20", VA = "0x186C5BF20")]
	public static int LDLPBFJCPNJ(int KAGIIBOHGNG, Func<int, bool> AHACPHKNEJG, bool IICAKOGPAOH = true)
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

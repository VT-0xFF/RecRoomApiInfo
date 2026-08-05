using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KLHDDFDLJGK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int NNFLCGACMNG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int AHIELHPCNMK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int MAMFDKEDOHH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D92E0", Offset = "0x69D7EE0", VA = "0x1869D92E0")]
	public static void HCAJOGBHDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D8F60", Offset = "0x69D7B60", VA = "0x1869D8F60")]
	public static void ADIJPIDBLEJ(int[] HIKCELAEHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D9040", Offset = "0x69D7C40", VA = "0x1869D9040")]
	public static int ENFMCBONLPD(int HGCAPKAHNIN, Func<int, bool> INACLPMBALI, bool DALOIFMFNHN = true)
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

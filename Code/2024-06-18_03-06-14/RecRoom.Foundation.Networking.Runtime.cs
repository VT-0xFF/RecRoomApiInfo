using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PFONIGIPDKE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int INKJIPNPGAB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int LEJLFKNJEGL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int FAJFCFBMEJA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68D3960", Offset = "0x68D2360", VA = "0x1868D3960")]
	public static void DEOIAKFAMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68D3C50", Offset = "0x68D2650", VA = "0x1868D3C50")]
	public static void LBCPFNLLNAI(int[] JPJLKOKHIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68D39B0", Offset = "0x68D23B0", VA = "0x1868D39B0")]
	public static int KJCELLBJKMB(int EJEGHFDCNGL, Func<int, bool> NHHGMCELHLH, bool NBICPNDICJM = true)
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

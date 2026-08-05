using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LBIJLBNFABI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int NDCINFCBDGN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int JAEMAGHHIII;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int FKKLAEDBJKD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68DA8D0", Offset = "0x68D94D0", VA = "0x1868DA8D0")]
	public static void IEJFOADPLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68DA7F0", Offset = "0x68D93F0", VA = "0x1868DA7F0")]
	public static void FFEHDKHFFLI(int[] HMBOHCOGFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68DA920", Offset = "0x68D9520", VA = "0x1868DA920")]
	public static int JPPPDHPGIPP(int PFEGAMGCHMC, Func<int, bool> KALBCHMBCJN, bool CBPGNJIGOAM = true)
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

using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DPBJOPLKOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int ICKEKPFEAGB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int AMBMLLLONJG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int ICBKPANNHOF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8B20", Offset = "0x6DF7F20", VA = "0x186DF8B20")]
	public static void HDGFLJAEPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8E00", Offset = "0x6DF8200", VA = "0x186DF8E00")]
	public static void MMEKFMLKEJN(int[] ADOJMKHMPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8B70", Offset = "0x6DF7F70", VA = "0x186DF8B70")]
	public static int IFPDBFOPDFM(int NODJAIEKKLA, Func<int, bool> ECPFHLACGHG, bool JLAFHBMDFIB = true)
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

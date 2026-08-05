using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BJIJOKEMMAK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int MHIEBOFAOPP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int EMADGPDFFOI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int ILFLILKFBMI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F62390", Offset = "0x6F60B90", VA = "0x186F62390")]
	public static void IBGCNOPAHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F622B0", Offset = "0x6F60AB0", VA = "0x186F622B0")]
	public static void GKAPGKGDHGG(int[] BAFBHJKPHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F62010", Offset = "0x6F60810", VA = "0x186F62010")]
	public static int FPMEDOFLJJD(int GBLGOLMBAIG, Func<int, bool> CHOINNOMOOM, bool CKODNLBJAMF = true)
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

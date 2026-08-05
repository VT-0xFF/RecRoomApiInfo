using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BCBLBFAFKAK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int PBIOACOPGDK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int IAEIPDPPIGA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int NLPAKOKAOCM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68FB380", Offset = "0x68FA580", VA = "0x1868FB380")]
	public static void FAHKBAJJAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68FB670", Offset = "0x68FA870", VA = "0x1868FB670")]
	public static void PLINCHPOKOM(int[] CJKANOFKAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68FB3D0", Offset = "0x68FA5D0", VA = "0x1868FB3D0")]
	public static int MOKCAGPEMMJ(int KIHIEPKGFPB, Func<int, bool> BNMFJOGFKGE, bool EDCOIAMNKAC = true)
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

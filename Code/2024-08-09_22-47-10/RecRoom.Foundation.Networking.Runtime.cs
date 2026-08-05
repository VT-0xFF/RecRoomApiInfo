using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IMJOHGJIICL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int LEOMHCCFHDD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int ELJPOMIEMCI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int GNLDINMBCDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68FF9D0", Offset = "0x68FEDD0", VA = "0x1868FF9D0")]
	public static void BKAKLGGNIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68FFCC0", Offset = "0x68FF0C0", VA = "0x1868FFCC0")]
	public static void OJMFNBKKFOF(int[] CFJGGPLDADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68FFA20", Offset = "0x68FEE20", VA = "0x1868FFA20")]
	public static int DEOCCCLBEFC(int PIMCGIEEKKB, Func<int, bool> DOFMMIFCMPK, bool LFNHHPGIKEO = true)
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

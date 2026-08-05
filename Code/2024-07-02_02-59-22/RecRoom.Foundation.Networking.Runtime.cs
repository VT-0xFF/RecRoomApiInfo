using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANCIIFIPGBO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int NEAFNKFENEE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int HBAOGKHFBIH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int ALLCBCHNNPH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x697B0D0", Offset = "0x697A0D0", VA = "0x18697B0D0")]
	public static void FOHOPJMGEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x697B120", Offset = "0x697A120", VA = "0x18697B120")]
	public static void GEPECGELJDG(int[] MFGMNOEBEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x697AE30", Offset = "0x6979E30", VA = "0x18697AE30")]
	public static int AALGDIHOKAE(int EENKAFFLAOE, Func<int, bool> BCAHIINHLCF, bool DCJFJENKPND = true)
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

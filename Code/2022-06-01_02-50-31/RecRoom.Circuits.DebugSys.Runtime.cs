using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KFNHIPCDCEJ : DHENGFPFHPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool APNKICKGPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private KFNHIPCDCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D89980", Offset = "0x4D88380", VA = "0x184D89980")]
	public static KFNHIPCDCEJ IHEMFNLEEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "4")]
	public void NHFHDPJNNGP(Func<string> JMIBJFINBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
	public void PEOFAEMEKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D899D0", Offset = "0x4D883D0", VA = "0x184D899D0", Slot = "6")]
	public void KDLACNANENH(object OLLHPIFFHKE)
	{
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

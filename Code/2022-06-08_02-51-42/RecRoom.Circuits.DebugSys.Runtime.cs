using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class HFJCAJKCGBN : FBBCDINPCLM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool ENMFGLNNNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private HFJCAJKCGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DA60B0", Offset = "0x4DA50B0", VA = "0x184DA60B0")]
	public static HFJCAJKCGBN BAPHMNFAJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "4")]
	public void OEFPAGDPCPD(Func<string> JIEIIEKPPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
	public void IICKABKBFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6100", Offset = "0x4DA5100", VA = "0x184DA6100", Slot = "6")]
	public void FIDJCKEKCHO(object LMJMILCCPPB)
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

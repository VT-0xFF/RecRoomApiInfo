using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CJNAIEFAPKK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string CDKGOIHMIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D43420", Offset = "0x7D41E20", VA = "0x187D43420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string MMBHELJGMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D43320", Offset = "0x7D41D20", VA = "0x187D43320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string PBBKJCCMPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D43320", Offset = "0x7D41D20", VA = "0x187D43320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string CDIPLENAJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D43420", Offset = "0x7D41E20", VA = "0x187D43420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D43490", Offset = "0x7D41E90", VA = "0x187D43490")]
	public static string NDNALHBOHGB([Optional] string AIAGHJMBNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D43430", Offset = "0x7D41E30", VA = "0x187D43430")]
	private static string JCBPDFJJKIF(string KJHMBICDBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D432A0", Offset = "0x7D41CA0", VA = "0x187D432A0")]
	public static void ECLFHLGPLNI(string KJHMBICDBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D433B0", Offset = "0x7D41DB0", VA = "0x187D433B0")]
	public static bool GPBMKCADOHH(string KJHMBICDBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D43330", Offset = "0x7D41D30", VA = "0x187D43330")]
	public static void FPHKJJMNPBJ(string KJHMBICDBAO, string HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D43510", Offset = "0x7D41F10", VA = "0x187D43510")]
	public static string OGMLOBJLBIA(string KJHMBICDBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D43230", Offset = "0x7D41C30", VA = "0x187D43230")]
	public static void AJKBEILJFFK(string KJHMBICDBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void OLFGIEDPFMJ()
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

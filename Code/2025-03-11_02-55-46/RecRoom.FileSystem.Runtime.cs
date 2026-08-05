using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CCMHEGOJKGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string IKKECKGGEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75E4CF0", Offset = "0x75E40F0", VA = "0x1875E4CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string IGCPBKLJJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75E4D70", Offset = "0x75E4170", VA = "0x1875E4D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string GHMKFPICAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75E4D70", Offset = "0x75E4170", VA = "0x1875E4D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string EOIDPLHBDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75E4CF0", Offset = "0x75E40F0", VA = "0x1875E4CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75E4D80", Offset = "0x75E4180", VA = "0x1875E4D80")]
	private static string EOGJHBGDHMG(string CBAOKODFJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75E4DE0", Offset = "0x75E41E0", VA = "0x1875E4DE0")]
	public static void IMCFGIGFEON(string CBAOKODFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75E4E60", Offset = "0x75E4260", VA = "0x1875E4E60")]
	public static bool JLNCIFPFMIF(string CBAOKODFJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75E4ED0", Offset = "0x75E42D0", VA = "0x1875E4ED0")]
	public static void LCKCLLNNFFH(string CBAOKODFJCF, string MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75E4F50", Offset = "0x75E4350", VA = "0x1875E4F50")]
	public static string MNEKMAOHEMI(string CBAOKODFJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75E4D00", Offset = "0x75E4100", VA = "0x1875E4D00")]
	public static void AJLBFBABDNH(string CBAOKODFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void CJIOKMJCHJM()
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

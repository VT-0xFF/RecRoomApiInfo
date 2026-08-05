using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IPLOOEKFMNK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string JOLDNLILGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6965940", Offset = "0x6964940", VA = "0x186965940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string NBPHODHCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6965B80", Offset = "0x6964B80", VA = "0x186965B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string MPFJBNOFLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6965940", Offset = "0x6964940", VA = "0x186965940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6965A40", Offset = "0x6964A40", VA = "0x186965A40")]
	private static string FLFBHALLEGO(string AKCHJOKAGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69658C0", Offset = "0x69648C0", VA = "0x1869658C0")]
	public static void AHJGDDKMLPD(string AKCHJOKAGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6965B10", Offset = "0x6964B10", VA = "0x186965B10")]
	public static bool KCCLNNDFKJD(string AKCHJOKAGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6965950", Offset = "0x6964950", VA = "0x186965950")]
	public static void DAOMLGHOPMN(string AKCHJOKAGJB, string FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6965AA0", Offset = "0x6964AA0", VA = "0x186965AA0")]
	public static string GJCEBGHMHIF(string AKCHJOKAGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69659D0", Offset = "0x69649D0", VA = "0x1869659D0")]
	public static void FFPIBMNGHEO(string AKCHJOKAGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void IPPGMIPAPIB()
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

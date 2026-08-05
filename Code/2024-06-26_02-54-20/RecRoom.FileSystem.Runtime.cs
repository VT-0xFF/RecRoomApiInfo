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
		[Cpp2IlInjected.Address(RVA = "0x6932CA0", Offset = "0x69312A0", VA = "0x186932CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string NBPHODHCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6932EE0", Offset = "0x69314E0", VA = "0x186932EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6932DA0", Offset = "0x69313A0", VA = "0x186932DA0")]
	private static string FLFBHALLEGO(string AKCHJOKAGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6932C20", Offset = "0x6931220", VA = "0x186932C20")]
	public static void AHJGDDKMLPD(string AKCHJOKAGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6932E70", Offset = "0x6931470", VA = "0x186932E70")]
	public static bool KCCLNNDFKJD(string AKCHJOKAGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6932CB0", Offset = "0x69312B0", VA = "0x186932CB0")]
	public static void DAOMLGHOPMN(string AKCHJOKAGJB, string FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6932E00", Offset = "0x6931400", VA = "0x186932E00")]
	public static string GJCEBGHMHIF(string AKCHJOKAGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6932D30", Offset = "0x6931330", VA = "0x186932D30")]
	public static void FFPIBMNGHEO(string AKCHJOKAGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
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

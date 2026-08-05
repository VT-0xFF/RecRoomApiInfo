using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IIGNKENPIGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LGHNAJOGGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68C5CF0", Offset = "0x68C48F0", VA = "0x1868C5CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string IKINMMAMEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68C5EC0", Offset = "0x68C4AC0", VA = "0x1868C5EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68C5E60", Offset = "0x68C4A60", VA = "0x1868C5E60")]
	private static string IDFHMKPOICN(string OMBOFKDENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68C5F40", Offset = "0x68C4B40", VA = "0x1868C5F40")]
	public static void PPJDKOEGKDB(string OMBOFKDENLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68C5D80", Offset = "0x68C4980", VA = "0x1868C5D80")]
	public static bool GDMJOIOHEFC(string OMBOFKDENLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68C5D00", Offset = "0x68C4900", VA = "0x1868C5D00")]
	public static void FIDGJKABOCM(string OMBOFKDENLD, string IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68C5ED0", Offset = "0x68C4AD0", VA = "0x1868C5ED0")]
	public static string LHFEILOKCNJ(string OMBOFKDENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68C5DF0", Offset = "0x68C49F0", VA = "0x1868C5DF0")]
	public static void HNHDILNOOHE(string OMBOFKDENLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void CJPNOEJOFIB()
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

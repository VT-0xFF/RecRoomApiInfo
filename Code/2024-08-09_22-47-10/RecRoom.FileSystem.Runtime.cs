using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANACGPJKGBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LPKNAHLFGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68EB0A0", Offset = "0x68EA4A0", VA = "0x1868EB0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string FOAPLKKEIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68EB120", Offset = "0x68EA520", VA = "0x1868EB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string BOHBPILDLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68EB120", Offset = "0x68EA520", VA = "0x1868EB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string HHOADCCBFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68EB0A0", Offset = "0x68EA4A0", VA = "0x1868EB0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68EB2A0", Offset = "0x68EA6A0", VA = "0x1868EB2A0")]
	private static string OBEBKCAFOFG(string EMHGIKAPEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68EB1A0", Offset = "0x68EA5A0", VA = "0x1868EB1A0")]
	public static void LOIJIFCFCDF(string EMHGIKAPEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68EB130", Offset = "0x68EA530", VA = "0x1868EB130")]
	public static bool JPEHINLLCND(string EMHGIKAPEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68EB220", Offset = "0x68EA620", VA = "0x1868EB220")]
	public static void NHEJJGPGFCB(string EMHGIKAPEJF, string LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68EB300", Offset = "0x68EA700", VA = "0x1868EB300")]
	public static string PFAAOCAJBEG(string EMHGIKAPEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68EB0B0", Offset = "0x68EA4B0", VA = "0x1868EB0B0")]
	public static void CNLLMJDDNDB(string EMHGIKAPEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void BPOIAEKLCDA()
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

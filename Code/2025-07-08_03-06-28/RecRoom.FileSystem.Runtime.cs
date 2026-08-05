using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GFLIFDPLBDI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string DEADCMIJKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80B4E30", Offset = "0x80B3C30", VA = "0x1880B4E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string FINMHKNHJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80B4DB0", Offset = "0x80B3BB0", VA = "0x1880B4DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string EKMLDGFJBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80B4DB0", Offset = "0x80B3BB0", VA = "0x1880B4DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string IBGAKBNDLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80B4E30", Offset = "0x80B3C30", VA = "0x1880B4E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80B4E40", Offset = "0x80B3C40", VA = "0x1880B4E40")]
	public static string KDIMDNADFFM([Optional] string GCOEEHMPEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80B4D50", Offset = "0x80B3B50", VA = "0x1880B4D50")]
	private static string CIOIJKPAFBJ(string PFPNMKAMPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80B4CD0", Offset = "0x80B3AD0", VA = "0x1880B4CD0")]
	public static void AOAJHIOFALF(string PFPNMKAMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80B4DC0", Offset = "0x80B3BC0", VA = "0x1880B4DC0")]
	public static bool EIGJFMOILPP(string PFPNMKAMPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80B4F30", Offset = "0x80B3D30", VA = "0x1880B4F30")]
	public static void OBEHCEOKJBH(string PFPNMKAMPMH, string BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80B4FB0", Offset = "0x80B3DB0", VA = "0x1880B4FB0")]
	public static string PGPJECFNIDH(string PFPNMKAMPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80B4EC0", Offset = "0x80B3CC0", VA = "0x1880B4EC0")]
	public static void KFBIFJFLFHM(string PFPNMKAMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void CPAOKNJIICF()
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

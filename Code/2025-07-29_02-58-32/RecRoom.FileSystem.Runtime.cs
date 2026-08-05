using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EJFOJIGPCCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string IFIDBHHDCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82FCBE0", Offset = "0x82FB5E0", VA = "0x1882FCBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string OFPFAMNNIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82FCC60", Offset = "0x82FB660", VA = "0x1882FCC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string NOANLKCDGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82FCC60", Offset = "0x82FB660", VA = "0x1882FCC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string BOALJAMPICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82FCBE0", Offset = "0x82FB5E0", VA = "0x1882FCBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82FCCF0", Offset = "0x82FB6F0", VA = "0x1882FCCF0")]
	public static string NDMCOACNEBF([Optional] string NOKOGGEKKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82FCB10", Offset = "0x82FB510", VA = "0x1882FCB10")]
	private static string BMOCFKCPHAE(string HODLOHIDPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82FCC70", Offset = "0x82FB670", VA = "0x1882FCC70")]
	public static void KPHPDPCFFJM(string HODLOHIDPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82FCB70", Offset = "0x82FB570", VA = "0x1882FCB70")]
	public static bool EHPAIMBMDDF(string HODLOHIDPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82FCD70", Offset = "0x82FB770", VA = "0x1882FCD70")]
	public static void PACAOCGCBJA(string HODLOHIDPMG, string GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82FCBF0", Offset = "0x82FB5F0", VA = "0x1882FCBF0")]
	public static string IOOPHHHKDFM(string HODLOHIDPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82FCAA0", Offset = "0x82FB4A0", VA = "0x1882FCAA0")]
	public static void ADAOCBDEMMH(string HODLOHIDPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void GKGBGJGHLHL()
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

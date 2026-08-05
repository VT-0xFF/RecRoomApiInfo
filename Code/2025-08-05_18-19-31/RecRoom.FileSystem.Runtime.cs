using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OJPKFDLBLGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LKEFBDFAMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82A4EF0", Offset = "0x82A42F0", VA = "0x1882A4EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DMPCNPGGABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82A4DF0", Offset = "0x82A41F0", VA = "0x1882A4DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string HNIDHKLAMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82A4DF0", Offset = "0x82A41F0", VA = "0x1882A4DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string AKOOIKDDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82A4EF0", Offset = "0x82A42F0", VA = "0x1882A4EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82A4F70", Offset = "0x82A4370", VA = "0x1882A4F70")]
	public static string MNIHKNNIOJD([Optional] string EEGGKFIEHBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82A4FF0", Offset = "0x82A43F0", VA = "0x1882A4FF0")]
	private static string NHJAPPPDJEM(string GADMOJMIIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82A4E00", Offset = "0x82A4200", VA = "0x1882A4E00")]
	public static void FPJCKLIBEOL(string GADMOJMIIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82A5050", Offset = "0x82A4450", VA = "0x1882A5050")]
	public static bool OMPIDCMFNBC(string GADMOJMIIGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82A4D70", Offset = "0x82A4170", VA = "0x1882A4D70")]
	public static void BGBJFMFHJOB(string GADMOJMIIGI, string NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82A4F00", Offset = "0x82A4300", VA = "0x1882A4F00")]
	public static string LHNFFNEDFKC(string GADMOJMIIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82A4E80", Offset = "0x82A4280", VA = "0x1882A4E80")]
	public static void GPDHPBAPPGJ(string GADMOJMIIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void LFMLNLIAMPM()
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

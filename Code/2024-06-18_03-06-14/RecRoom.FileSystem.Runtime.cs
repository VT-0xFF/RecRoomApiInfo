using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LIHPONMNLAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string AKJLBIBNGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68BE860", Offset = "0x68BD260", VA = "0x1868BE860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string MHFOABCLHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68BE7E0", Offset = "0x68BD1E0", VA = "0x1868BE7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68BE8E0", Offset = "0x68BD2E0", VA = "0x1868BE8E0")]
	private static string LOBAJBKOLPP(string LLLIHNDJKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68BE760", Offset = "0x68BD160", VA = "0x1868BE760")]
	public static void BNPPHOIGMHG(string LLLIHNDJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68BE6F0", Offset = "0x68BD0F0", VA = "0x1868BE6F0")]
	public static bool AKLIIMDKOIM(string LLLIHNDJKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68BE940", Offset = "0x68BD340", VA = "0x1868BE940")]
	public static void NGNCGBHPNKC(string LLLIHNDJKKC, string EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68BE870", Offset = "0x68BD270", VA = "0x1868BE870")]
	public static string LMKJJONPHNG(string LLLIHNDJKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68BE7F0", Offset = "0x68BD1F0", VA = "0x1868BE7F0")]
	public static void EGPLCBMKKKO(string LLLIHNDJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void BLCEECJABJC()
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

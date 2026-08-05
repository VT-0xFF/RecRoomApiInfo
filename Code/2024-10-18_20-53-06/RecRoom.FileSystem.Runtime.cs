using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FOGADMDMGFF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NPKIHJFOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DD37A0", Offset = "0x6DD2BA0", VA = "0x186DD37A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DLHAPPLCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3710", Offset = "0x6DD2B10", VA = "0x186DD3710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string CPKGHHALGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3710", Offset = "0x6DD2B10", VA = "0x186DD3710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string FKBFNCHJEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DD37A0", Offset = "0x6DD2BA0", VA = "0x186DD37A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3890", Offset = "0x6DD2C90", VA = "0x186DD3890")]
	private static string OCJOKLGHIBN(string NDECLOFKCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3690", Offset = "0x6DD2A90", VA = "0x186DD3690")]
	public static void CKOEOCLMHDA(string NDECLOFKCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DD37B0", Offset = "0x6DD2BB0", VA = "0x186DD37B0")]
	public static bool HCAHKAIBJGD(string NDECLOFKCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3720", Offset = "0x6DD2B20", VA = "0x186DD3720")]
	public static void EFKNKFHCHLN(string NDECLOFKCPB, string AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DD38F0", Offset = "0x6DD2CF0", VA = "0x186DD38F0")]
	public static string OMONNFFDGHL(string NDECLOFKCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3820", Offset = "0x6DD2C20", VA = "0x186DD3820")]
	public static void JGLFAIMPHGA(string NDECLOFKCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void ALBCIFHMNCI()
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

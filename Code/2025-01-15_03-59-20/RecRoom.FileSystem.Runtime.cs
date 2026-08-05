using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GDDNHHJNCGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string CHGDPHDGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3FA0", Offset = "0x6FF33A0", VA = "0x186FF3FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string ILFJBKBNEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4110", Offset = "0x6FF3510", VA = "0x186FF4110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string DCHNLPOIMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4110", Offset = "0x6FF3510", VA = "0x186FF4110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string CLILHOOPOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3FA0", Offset = "0x6FF33A0", VA = "0x186FF3FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4210", Offset = "0x6FF3610", VA = "0x186FF4210")]
	private static string PPINMKKEHFL(string DFDAPFPPOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4190", Offset = "0x6FF3590", VA = "0x186FF4190")]
	public static void MIHJDFNAJPC(string DFDAPFPPOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4120", Offset = "0x6FF3520", VA = "0x186FF4120")]
	public static bool HFDCBGOMNEG(string DFDAPFPPOMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3FB0", Offset = "0x6FF33B0", VA = "0x186FF3FB0")]
	public static void BBBDJLBNCJD(string DFDAPFPPOMG, string JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FF40A0", Offset = "0x6FF34A0", VA = "0x186FF40A0")]
	public static string DCPEJBGGOKL(string DFDAPFPPOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4030", Offset = "0x6FF3430", VA = "0x186FF4030")]
	public static void BLDECKDHDND(string DFDAPFPPOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void EIEKGJHLIHO()
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

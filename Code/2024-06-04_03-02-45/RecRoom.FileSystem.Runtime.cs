using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GEOEFHLAHEP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string HNNFIONJJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1EDB870", Offset = "0x1EDA070", VA = "0x181EDB870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string OBBDLOGKDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6848C00", Offset = "0x6847400", VA = "0x186848C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6848950", Offset = "0x6847150", VA = "0x186848950")]
	private static string DJNGGDOHEKA(string FKOPBOJEAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6848B80", Offset = "0x6847380", VA = "0x186848B80")]
	public static void NINKLLGMBEA(string FKOPBOJEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6848AA0", Offset = "0x68472A0", VA = "0x186848AA0")]
	public static bool FDAJDNNBAAJ(string FKOPBOJEAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68489B0", Offset = "0x68471B0", VA = "0x1868489B0")]
	public static void ECPLJPEFIBM(string FKOPBOJEAII, string MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6848A30", Offset = "0x6847230", VA = "0x186848A30")]
	public static string EOIAMDPHPJL(string FKOPBOJEAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6848B10", Offset = "0x6847310", VA = "0x186848B10")]
	public static void HCPFOAPBKKL(string FKOPBOJEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void FFJHOCEODPO()
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

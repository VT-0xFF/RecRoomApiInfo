using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OBCADHKMIOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string HNBGKFDEGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75F7160", Offset = "0x75F6360", VA = "0x1875F7160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string EJKPHDMJCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75F7170", Offset = "0x75F6370", VA = "0x1875F7170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string DFFECMDNIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75F7170", Offset = "0x75F6370", VA = "0x1875F7170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string JNONBOJFHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75F7160", Offset = "0x75F6360", VA = "0x1875F7160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75F7180", Offset = "0x75F6380", VA = "0x1875F7180")]
	private static string JPDNONHMFMM(string PFECANJBHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75F6F10", Offset = "0x75F6110", VA = "0x1875F6F10")]
	public static void CFFNIGOMDHG(string PFECANJBHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75F70F0", Offset = "0x75F62F0", VA = "0x1875F70F0")]
	public static bool EOOFOHJKKAD(string PFECANJBHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75F6F90", Offset = "0x75F6190", VA = "0x1875F6F90")]
	public static void CJMLDBDBLHP(string PFECANJBHHJ, string LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75F7010", Offset = "0x75F6210", VA = "0x1875F7010")]
	public static string CPPCALEIPNB(string PFECANJBHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75F7080", Offset = "0x75F6280", VA = "0x1875F7080")]
	public static void DPGFDJJCMPM(string PFECANJBHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void EKNOEBDFPCD()
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

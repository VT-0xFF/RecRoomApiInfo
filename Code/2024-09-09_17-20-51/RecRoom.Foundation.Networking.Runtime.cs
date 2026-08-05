using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EFCLOACHOKG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int ALLCLFEKFHN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int EJGNIBDDDLK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int JMHJGGEAKGJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BA11F0", Offset = "0x6B9FBF0", VA = "0x186BA11F0")]
	public static void IBOFOOIIGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1240", Offset = "0x6B9FC40", VA = "0x186BA1240")]
	public static void LNAOBLFCHGE(int[] ECDNGAEDABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0F60", Offset = "0x6B9F960", VA = "0x186BA0F60")]
	public static int AEPFKHMCMAP(int HFMCJOMGJPP, Func<int, bool> BKLOHCBACAO, bool HICLNCPDBIH = true)
	{
		return default(int);
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

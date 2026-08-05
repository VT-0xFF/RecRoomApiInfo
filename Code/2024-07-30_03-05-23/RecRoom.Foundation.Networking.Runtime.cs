using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KDOCIAHIEFM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int CKKLDBMHAFC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int KCADDMLBNFO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int GCEBHFDKBDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F200", Offset = "0x6A0D800", VA = "0x186A0F200")]
	public static void NMINEEMHFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F120", Offset = "0x6A0D720", VA = "0x186A0F120")]
	public static void KJBGKIKFGMM(int[] FBLJCMMPNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EE80", Offset = "0x6A0D480", VA = "0x186A0EE80")]
	public static int BGLCEJOCIJA(int PFOIJIJHNJN, Func<int, bool> LAJAAJFEIOC, bool DOOJKBPPBJI = true)
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

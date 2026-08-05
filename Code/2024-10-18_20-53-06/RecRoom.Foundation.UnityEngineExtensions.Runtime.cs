using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANOOAILMLAC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EJKBPOBBLJI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x358B5B0", Offset = "0x358A9B0", VA = "0x18358B5B0")]
	public static T JDGJDOIJLCH<T>(this T MCPMOAEEEOJ) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x358B520", Offset = "0x358A920", VA = "0x18358B520")]
	public static T EAEHADEFEJO<T>(this T MCPMOAEEEOJ) where T : class, EJKBPOBBLJI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x358B610", Offset = "0x358AA10", VA = "0x18358B610")]
	public static void KPIOBCONOIH<T>(T MCPMOAEEEOJ, T KNLMODPGFOA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x358B490", Offset = "0x358A890", VA = "0x18358B490")]
	public static bool CAJJPFFNMIP<T>(this T FMAFBHGACNM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8000", Offset = "0x6DF7400", VA = "0x186DF8000")]
	public static string HKODDKFOBKM(this UnityEngine.Object FMAFBHGACNM)
	{
		return null;
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

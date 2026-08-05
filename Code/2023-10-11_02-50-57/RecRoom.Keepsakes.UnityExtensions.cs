using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KFPJMOLDJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD5A0", Offset = "0x5CFC3A0", VA = "0x185CFD5A0")]
	public static KeepsakeTheme BAABPCKLBDG(this NDHFENFHDKP OHOLEEOLBDH, Guid IEFINHMKLDJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD4F0", Offset = "0x5CFC2F0", VA = "0x185CFD4F0")]
	public static KeepsakeTheme BAABPCKLBDG(this NDHFENFHDKP OHOLEEOLBDH, HHMMOFCFDIK OCCPBLJFHDM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD710", Offset = "0x5CFC510", VA = "0x185CFD710")]
	public static List<KeepsakeTheme> GBIHGLGDAIH(this NDHFENFHDKP OHOLEEOLBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD7D0", Offset = "0x5CFC5D0", VA = "0x185CFD7D0")]
	public static HHMMOFCFDIK HIHBMDEGPAE(this NDHFENFHDKP OHOLEEOLBDH, Guid IEFINHMKLDJ)
	{
		return default(HHMMOFCFDIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD690", Offset = "0x5CFC490", VA = "0x185CFD690")]
	public static int FIJMKBPAOAM(this NDHFENFHDKP OHOLEEOLBDH, HHMMOFCFDIK DPDBKELBPLF)
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

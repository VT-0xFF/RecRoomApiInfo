using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NEKLDFONDHM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6187090", Offset = "0x6186290", VA = "0x186187090")]
	public static KeepsakeTheme DAHMJLNKEKK(this DKCLAHPHHOD HOHFFEHOKPA, Guid KOEFBEKPCLL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6187180", Offset = "0x6186380", VA = "0x186187180")]
	public static KeepsakeTheme DAHMJLNKEKK(this DKCLAHPHHOD HOHFFEHOKPA, JNKBGACMLPG NKFJFJINODG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61872B0", Offset = "0x61864B0", VA = "0x1861872B0")]
	public static List<KeepsakeTheme> KCLHOLOGACK(this DKCLAHPHHOD HOHFFEHOKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6187000", Offset = "0x6186200", VA = "0x186187000")]
	public static JNKBGACMLPG CFIPBPNALFL(this DKCLAHPHHOD HOHFFEHOKPA, Guid KOEFBEKPCLL)
	{
		return default(JNKBGACMLPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6187230", Offset = "0x6186430", VA = "0x186187230")]
	public static int EDFNPPCENKB(this DKCLAHPHHOD HOHFFEHOKPA, JNKBGACMLPG OLJOPAJLGHD)
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

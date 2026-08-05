using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CNFLLILBBCA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F934F0", Offset = "0x6F91CF0", VA = "0x186F934F0")]
	public static KeepsakeTheme NGHAFLAMKGN(this NKDGPEANBAO JIPBFCNFKIF, Guid NOIIKCGGEGJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F93440", Offset = "0x6F91C40", VA = "0x186F93440")]
	public static KeepsakeTheme NGHAFLAMKGN(this NKDGPEANBAO JIPBFCNFKIF, NHCLBNIPKNG OLBNCIHHNLM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F93370", Offset = "0x6F91B70", VA = "0x186F93370")]
	public static List<KeepsakeTheme> KOCIPCAFION(this NKDGPEANBAO JIPBFCNFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F932D0", Offset = "0x6F91AD0", VA = "0x186F932D0")]
	public static NHCLBNIPKNG KHABKCJGAII(this NKDGPEANBAO JIPBFCNFKIF, Guid NOIIKCGGEGJ)
	{
		return default(NHCLBNIPKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F93240", Offset = "0x6F91A40", VA = "0x186F93240")]
	public static int FCLLNHAKHOI(this NKDGPEANBAO JIPBFCNFKIF, NHCLBNIPKNG HJOECMPFEAP)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KHOECKEMPNA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FA6F40", Offset = "0x6FA6340", VA = "0x186FA6F40")]
	public static KeepsakeTheme DDGJJBONLIJ(this BEPGKHCEPLH MLODHIKJENP, Guid PHMLMEFLACC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7040", Offset = "0x6FA6440", VA = "0x186FA7040")]
	public static KeepsakeTheme DDGJJBONLIJ(this BEPGKHCEPLH MLODHIKJENP, ALPCGHPMCLM GGCHLADAEML)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7260", Offset = "0x6FA6660", VA = "0x186FA7260")]
	public static List<KeepsakeTheme> PIACNCNKIKO(this BEPGKHCEPLH MLODHIKJENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7150", Offset = "0x6FA6550", VA = "0x186FA7150")]
	public static ALPCGHPMCLM DDPBADBHIKN(this BEPGKHCEPLH MLODHIKJENP, Guid PHMLMEFLACC)
	{
		return default(ALPCGHPMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FA71E0", Offset = "0x6FA65E0", VA = "0x186FA71E0")]
	public static int DGLLIBIHLPM(this BEPGKHCEPLH MLODHIKJENP, ALPCGHPMCLM EJHGPGAGNJJ)
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

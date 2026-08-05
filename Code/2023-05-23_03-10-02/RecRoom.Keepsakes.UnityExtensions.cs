using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LGDJFFHLLIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x170CE50", Offset = "0x170C250", VA = "0x18170CE50")]
	public static KeepsakeTheme OOBHNNBFNME(this KMDGAKGFJAF JMAEGHAGIPP, Guid NLEOMGLIGJK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x170CD40", Offset = "0x170C140", VA = "0x18170CD40")]
	public static KeepsakeTheme OOBHNNBFNME(this KMDGAKGFJAF JMAEGHAGIPP, CCLDPBPGLEA DJFFIAHDEHP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x170CC10", Offset = "0x170C010", VA = "0x18170CC10")]
	public static List<KeepsakeTheme> HPCGGMDIOPG(this KMDGAKGFJAF JMAEGHAGIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x170CB80", Offset = "0x170BF80", VA = "0x18170CB80")]
	public static CCLDPBPGLEA FFJOELKNMHA(this KMDGAKGFJAF JMAEGHAGIPP, Guid NLEOMGLIGJK)
	{
		return default(CCLDPBPGLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x170CCC0", Offset = "0x170C0C0", VA = "0x18170CCC0")]
	public static int KEFPFIACKDB(this KMDGAKGFJAF JMAEGHAGIPP, CCLDPBPGLEA EIJDJFDKAHK)
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

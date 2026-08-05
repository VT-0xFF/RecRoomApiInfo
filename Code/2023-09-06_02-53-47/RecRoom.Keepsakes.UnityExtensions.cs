using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GANODDMOLGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3CE0", Offset = "0x6FF22E0", VA = "0x186FF3CE0")]
	public static KeepsakeTheme IDPGOKMPIJF(this LKLECENCKFL AMKEFDBPHKK, Guid ABCJLNPFGLC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3DE0", Offset = "0x6FF23E0", VA = "0x186FF3DE0")]
	public static KeepsakeTheme IDPGOKMPIJF(this LKLECENCKFL AMKEFDBPHKK, KNBGGKHAOAH MPEAHHAHGHN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3F70", Offset = "0x6FF2570", VA = "0x186FF3F70")]
	public static List<KeepsakeTheme> PPLLEALICEC(this LKLECENCKFL AMKEFDBPHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3C50", Offset = "0x6FF2250", VA = "0x186FF3C50")]
	public static KNBGGKHAOAH HEIFICLGALJ(this LKLECENCKFL AMKEFDBPHKK, Guid ABCJLNPFGLC)
	{
		return default(KNBGGKHAOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3EF0", Offset = "0x6FF24F0", VA = "0x186FF3EF0")]
	public static int OFLLFELLOJD(this LKLECENCKFL AMKEFDBPHKK, KNBGGKHAOAH GMLMLHACFDB)
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

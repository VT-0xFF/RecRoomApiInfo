using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LLILJEHKLED
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x703B630", Offset = "0x703AA30", VA = "0x18703B630")]
	public static KeepsakeTheme CAIFLFDPCAP(this GDPBDJEECFD KCLPDCIIPCH, Guid MALKHIENPGL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x703B580", Offset = "0x703A980", VA = "0x18703B580")]
	public static KeepsakeTheme CAIFLFDPCAP(this GDPBDJEECFD KCLPDCIIPCH, BLGKFNMKMGA CAODEBKBHGA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x703B7C0", Offset = "0x703ABC0", VA = "0x18703B7C0")]
	public static List<KeepsakeTheme> FJKOOGAGLEK(this GDPBDJEECFD KCLPDCIIPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x703B890", Offset = "0x703AC90", VA = "0x18703B890")]
	public static BLGKFNMKMGA GJMPMPMEFKM(this GDPBDJEECFD KCLPDCIIPCH, Guid MALKHIENPGL)
	{
		return default(BLGKFNMKMGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x703B730", Offset = "0x703AB30", VA = "0x18703B730")]
	public static int FHJOKBAPILC(this GDPBDJEECFD KCLPDCIIPCH, BLGKFNMKMGA HBNOJOAIBEL)
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

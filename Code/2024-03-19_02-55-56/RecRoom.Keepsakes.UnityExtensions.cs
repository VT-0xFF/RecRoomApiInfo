using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OCIOLLKJJBA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61C54F0", Offset = "0x61C44F0", VA = "0x1861C54F0")]
	public static KeepsakeTheme ICAOCLOFDIC(this BPEEKCLPMIM JDIOCIOLNIG, Guid AHLCAKLIDLG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61C5440", Offset = "0x61C4440", VA = "0x1861C5440")]
	public static KeepsakeTheme ICAOCLOFDIC(this BPEEKCLPMIM JDIOCIOLNIG, HNLAOBHNGAL AOLBHFHDMNL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61C5660", Offset = "0x61C4660", VA = "0x1861C5660")]
	public static List<KeepsakeTheme> OOPDPNABHLO(this BPEEKCLPMIM JDIOCIOLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61C53B0", Offset = "0x61C43B0", VA = "0x1861C53B0")]
	public static HNLAOBHNGAL CLMGOHMLJMA(this BPEEKCLPMIM JDIOCIOLNIG, Guid AHLCAKLIDLG)
	{
		return default(HNLAOBHNGAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61C55E0", Offset = "0x61C45E0", VA = "0x1861C55E0")]
	public static int KGJICEIGDLE(this BPEEKCLPMIM JDIOCIOLNIG, HNLAOBHNGAL MPJODJODHKN)
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

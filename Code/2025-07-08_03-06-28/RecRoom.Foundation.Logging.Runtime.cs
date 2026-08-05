using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MLLMCFMNMBG
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80D1460", Offset = "0x80D0260", VA = "0x1880D1460")]
	public static MLLMCFMNMBG JGGBAIGHKJA(PHLHEDGDBJO CFEMPAINFAM)
	{
		return default(MLLMCFMNMBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x80D1540", Offset = "0x80D0340", VA = "0x1880D1540")]
	public MLLMCFMNMBG(PHLHEDGDBJO CFEMPAINFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80D1480", Offset = "0x80D0280", VA = "0x1880D1480")]
	public void JBNCFEFNHCM([In] FixedString128Bytes JFJICNCOLKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BCAJEGDAEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80D1460", Offset = "0x80D0260", VA = "0x1880D1460")]
	public static MLLMCFMNMBG EICLNKFDJAG(this PHLHEDGDBJO CFEMPAINFAM)
	{
		return default(MLLMCFMNMBG);
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

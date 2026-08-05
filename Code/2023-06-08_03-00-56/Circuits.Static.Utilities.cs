using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OIMBAJDJINM : DLNGEOPAEBA, KCFDFNEEHDO, JILPNNKAMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x13802B0", Offset = "0x137F0B0", VA = "0x1813802B0")]
	protected OIMBAJDJINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class BBOMDKJMIPM<TData> : OIMBAJDJINM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FFBIEHGLHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData DKPMKJNEILJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "7")]
	public override string AFBGODFOPHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4930", Offset = "0x3DD3730", VA = "0x183DD4930")]
	internal BBOMDKJMIPM(string CAJMIGKHKEC, in TData FAJCHBCCGOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OOEOPGAJMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x19439D0", Offset = "0x19427D0", VA = "0x1819439D0")]
	public static BBOMDKJMIPM<MELLEHNAKNA> PKJHFAGPFPD(string CAJMIGKHKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25DF010", Offset = "0x25DDE10", VA = "0x1825DF010")]
	public static BBOMDKJMIPM<TData> PKJHFAGPFPD<TData>(string CAJMIGKHKEC, in TData FAJCHBCCGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JKMGIDHJFKB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E08050", Offset = "0x2E06E50", VA = "0x182E08050")]
	public static ABAABAMKHON<TOk, KCFDFNEEHDO> FEIHBGIEIBN<TOk>(this in ABAABAMKHON<TOk, KCFDFNEEHDO> FEEMIHFJMDK, string CAJMIGKHKEC)
	{
		return default(ABAABAMKHON<TOk, KCFDFNEEHDO>);
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

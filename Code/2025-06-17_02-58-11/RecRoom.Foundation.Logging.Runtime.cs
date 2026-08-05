using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct NKPBLELBANM
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F800", Offset = "0x7D5E200", VA = "0x187D5F800")]
	public static NKPBLELBANM HNONLACFBHP(COJJKFBGGKB PMPMPCJHKKF)
	{
		return default(NKPBLELBANM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F8E0", Offset = "0x7D5E2E0", VA = "0x187D5F8E0")]
	public NKPBLELBANM(COJJKFBGGKB PMPMPCJHKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F820", Offset = "0x7D5E220", VA = "0x187D5F820")]
	public void JKOFKEGKJJH([In] FixedString128Bytes JDGADODOANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GJMAGJNBNLA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F800", Offset = "0x7D5E200", VA = "0x187D5F800")]
	public static NKPBLELBANM JPMEGINBNDF(this COJJKFBGGKB PMPMPCJHKKF)
	{
		return default(NKPBLELBANM);
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

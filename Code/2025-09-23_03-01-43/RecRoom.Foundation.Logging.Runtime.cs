using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct HBHKBOLJAIK
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8513C80", Offset = "0x8512280", VA = "0x188513C80")]
	public static HBHKBOLJAIK HNGLNPFKABH(IPHNFELODMJ AMCHCCAPJNG)
	{
		return default(HBHKBOLJAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8513D60", Offset = "0x8512360", VA = "0x188513D60")]
	public HBHKBOLJAIK(IPHNFELODMJ AMCHCCAPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8513CA0", Offset = "0x85122A0", VA = "0x188513CA0")]
	public void HNPAIDKDOLO([In] FixedString128Bytes DPCMOBNBPGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BGGNLIMHNPF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8513C80", Offset = "0x8512280", VA = "0x188513C80")]
	public static HBHKBOLJAIK HJAJFPNNABB(this IPHNFELODMJ AMCHCCAPJNG)
	{
		return default(HBHKBOLJAIK);
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

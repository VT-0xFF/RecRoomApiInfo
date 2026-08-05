using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct OEHOPICDGPE
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BE60", Offset = "0x7C6B060", VA = "0x187C6BE60")]
	public static OEHOPICDGPE PDHAGBEBCNG(KEPOMIIOHBM EBHKLAMEJCE)
	{
		return default(OEHOPICDGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BE80", Offset = "0x7C6B080", VA = "0x187C6BE80")]
	public OEHOPICDGPE(KEPOMIIOHBM EBHKLAMEJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BDA0", Offset = "0x7C6AFA0", VA = "0x187C6BDA0")]
	public void EMKHHFBFKOJ([In] FixedString128Bytes EBPGPJLLHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OEIFBHKMABO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BE60", Offset = "0x7C6B060", VA = "0x187C6BE60")]
	public static OEHOPICDGPE HHDMAFMANDK(this KEPOMIIOHBM EBHKLAMEJCE)
	{
		return default(OEHOPICDGPE);
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

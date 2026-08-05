using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct BOMKGDKIDOA
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8509BC0", Offset = "0x85085C0", VA = "0x188509BC0")]
	public static BOMKGDKIDOA HDPJNBPLGPE(OLFEOKKCIEG JHGFKLHHPJD)
	{
		return default(BOMKGDKIDOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8509CA0", Offset = "0x85086A0", VA = "0x188509CA0")]
	public BOMKGDKIDOA(OLFEOKKCIEG JHGFKLHHPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8509BE0", Offset = "0x85085E0", VA = "0x188509BE0")]
	public void KCFDIHIJGKF([In] FixedString128Bytes KKIOLBHBACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OPLFKAEBEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8509BC0", Offset = "0x85085C0", VA = "0x188509BC0")]
	public static BOMKGDKIDOA NPLNJBDFBPF(this OLFEOKKCIEG JHGFKLHHPJD)
	{
		return default(BOMKGDKIDOA);
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

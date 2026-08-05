using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MEIOACIPJEK
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B40180", Offset = "0x7B3E980", VA = "0x187B40180")]
	public static MEIOACIPJEK FGIKKMMHFBO(LLPKKNNAIAE NOMHFHBJHNN)
	{
		return default(MEIOACIPJEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B401A0", Offset = "0x7B3E9A0", VA = "0x187B401A0")]
	public MEIOACIPJEK(LLPKKNNAIAE NOMHFHBJHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B400C0", Offset = "0x7B3E8C0", VA = "0x187B400C0")]
	public void AMHNOMFECLM([In] FixedString128Bytes NECPKEMHBDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OGCPCHABJNK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B40180", Offset = "0x7B3E980", VA = "0x187B40180")]
	public static MEIOACIPJEK DCKPOIIIIMN(this LLPKKNNAIAE NOMHFHBJHNN)
	{
		return default(MEIOACIPJEK);
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

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct PEGDFKJEACD
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3EF0", Offset = "0x7DB2CF0", VA = "0x187DB3EF0")]
	public static PEGDFKJEACD HEKJAOMNHLJ(IEBEPMGFCGH NHLEILEPJMB)
	{
		return default(PEGDFKJEACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3FD0", Offset = "0x7DB2DD0", VA = "0x187DB3FD0")]
	public PEGDFKJEACD(IEBEPMGFCGH NHLEILEPJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3F10", Offset = "0x7DB2D10", VA = "0x187DB3F10")]
	public void AJDOOHBHBHH([In] FixedString128Bytes DOABHODDFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IEIGFLDJMJD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3EF0", Offset = "0x7DB2CF0", VA = "0x187DB3EF0")]
	public static PEGDFKJEACD CLMBGJKGPJO(this IEBEPMGFCGH NHLEILEPJMB)
	{
		return default(PEGDFKJEACD);
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

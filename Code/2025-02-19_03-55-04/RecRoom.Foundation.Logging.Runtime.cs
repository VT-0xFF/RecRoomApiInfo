using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct GJGFFPGHNGN
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74BD8A0", Offset = "0x74BC4A0", VA = "0x1874BD8A0")]
	public static GJGFFPGHNGN NIBCGLOMJGK(NDNFAPMFFIF DFFCPCMIFOD)
	{
		return default(GJGFFPGHNGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74BD980", Offset = "0x74BC580", VA = "0x1874BD980")]
	public GJGFFPGHNGN(NDNFAPMFFIF DFFCPCMIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74BD8C0", Offset = "0x74BC4C0", VA = "0x1874BD8C0")]
	public void OCMEEKEHCCG([In] FixedString128Bytes FDHHCKGHMND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NDNCFMAODEL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74BD8A0", Offset = "0x74BC4A0", VA = "0x1874BD8A0")]
	public static GJGFFPGHNGN BGAKGNLMHKJ(this NDNFAPMFFIF DFFCPCMIFOD)
	{
		return default(GJGFFPGHNGN);
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

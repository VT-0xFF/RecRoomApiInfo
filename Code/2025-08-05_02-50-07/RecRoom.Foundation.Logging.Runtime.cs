using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LGJNHGLBBGC
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82C15A0", Offset = "0x82C09A0", VA = "0x1882C15A0")]
	public static LGJNHGLBBGC GKKMDDPCKIG(AKNCNLDICPO CCLJCJDJCOE)
	{
		return default(LGJNHGLBBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x82C15C0", Offset = "0x82C09C0", VA = "0x1882C15C0")]
	public LGJNHGLBBGC(AKNCNLDICPO CCLJCJDJCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82C14E0", Offset = "0x82C08E0", VA = "0x1882C14E0")]
	public void DMPPDIEEMEF([In] FixedString128Bytes BPHJBCALMCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NLNICLDHNDK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82C15A0", Offset = "0x82C09A0", VA = "0x1882C15A0")]
	public static LGJNHGLBBGC EPLIIPGNGDP(this AKNCNLDICPO CCLJCJDJCOE)
	{
		return default(LGJNHGLBBGC);
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

using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KMIBKBPLFPH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x289EB70", Offset = "0x289DD70", VA = "0x18289EB70")]
	public static Guid DDLOEABCGKO(this ByteString BJFNBIEJBCK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x289EC70", Offset = "0x289DE70", VA = "0x18289EC70")]
	public static ByteString LPPBJNCKBIA(this Guid BJFNBIEJBCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JFMLLGCMFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x289E920", Offset = "0x289DB20", VA = "0x18289E920")]
	public static DLKGECJAHJF LIOPAMDCNLD(this in Guid BJFNBIEJBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x289E840", Offset = "0x289DA40", VA = "0x18289E840")]
	public static Guid LGPKACCHBHO(this DLKGECJAHJF BJFNBIEJBCK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x289EA40", Offset = "0x289DC40", VA = "0x18289EA40")]
	public static Guid? OPOOJAAODPG(this DLKGECJAHJF BJFNBIEJBCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MGLNELNGAPD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x289EDC0", Offset = "0x289DFC0", VA = "0x18289EDC0")]
	public static int COKFENFJNIK(this FODENONHEJC EPKKJAHBGLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x19A5A10", Offset = "0x19A4C10", VA = "0x1819A5A10")]
	public static int OBGAGKOELDM()
	{
		return default(int);
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

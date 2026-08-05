using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HPNKGNOOHNC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61F0A60", Offset = "0x61EFE60", VA = "0x1861F0A60")]
	public static KeepsakeTheme AHPEIPPBODL(this IALAHAHMGNK BJMBJJIMGHO, Guid MIPKJNCHBBK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61F0B50", Offset = "0x61EFF50", VA = "0x1861F0B50")]
	public static KeepsakeTheme AHPEIPPBODL(this IALAHAHMGNK BJMBJJIMGHO, EIOCNLPONOP BLDEJBNOCJA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61F0C80", Offset = "0x61F0080", VA = "0x1861F0C80")]
	public static List<KeepsakeTheme> EIAFINHAKFL(this IALAHAHMGNK BJMBJJIMGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61F0D40", Offset = "0x61F0140", VA = "0x1861F0D40")]
	public static EIOCNLPONOP HIPGKNFDLAJ(this IALAHAHMGNK BJMBJJIMGHO, Guid MIPKJNCHBBK)
	{
		return default(EIOCNLPONOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61F0C00", Offset = "0x61F0000", VA = "0x1861F0C00")]
	public static int EBBOPNIMCPF(this IALAHAHMGNK BJMBJJIMGHO, EIOCNLPONOP DLIABPPAJGJ)
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

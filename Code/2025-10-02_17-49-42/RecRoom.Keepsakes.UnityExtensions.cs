using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MOPCMLLOMCH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x854A700", Offset = "0x8549100", VA = "0x18854A700")]
	public static KeepsakeTheme MLAFBNPHGCG(this DNDJMNPJOGO KFMMGFEJHFC, Guid KHHJKJEPENJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x854A650", Offset = "0x8549050", VA = "0x18854A650")]
	public static KeepsakeTheme MLAFBNPHGCG(this DNDJMNPJOGO KFMMGFEJHFC, OJBCBIHCMHF JCGKACEFOIP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x854A580", Offset = "0x8548F80", VA = "0x18854A580")]
	public static List<KeepsakeTheme> JNIMJMNAKPN(this DNDJMNPJOGO KFMMGFEJHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x854A450", Offset = "0x8548E50", VA = "0x18854A450")]
	public static OJBCBIHCMHF BFCBEBOCGNE(this DNDJMNPJOGO KFMMGFEJHFC, Guid KHHJKJEPENJ)
	{
		return default(OJBCBIHCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x854A4F0", Offset = "0x8548EF0", VA = "0x18854A4F0")]
	public static int HPMLLJCHHCI(this DNDJMNPJOGO KFMMGFEJHFC, OJBCBIHCMHF CBICHGNAKFE)
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

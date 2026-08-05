using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MOOLDMDENBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E10440", Offset = "0x5E0F240", VA = "0x185E10440")]
	public static KeepsakeTheme LJCNKJMKPEM(this AJCPDLIEOGO LBHKILDBCNO, Guid KJOKGMJIJOB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E10390", Offset = "0x5E0F190", VA = "0x185E10390")]
	public static KeepsakeTheme LJCNKJMKPEM(this AJCPDLIEOGO LBHKILDBCNO, PEEBFJALEIP INCPJCGPEGF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E102D0", Offset = "0x5E0F0D0", VA = "0x185E102D0")]
	public static List<KeepsakeTheme> LHLBGACKEKG(this AJCPDLIEOGO LBHKILDBCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E10530", Offset = "0x5E0F330", VA = "0x185E10530")]
	public static PEEBFJALEIP PGPBOFBAPMB(this AJCPDLIEOGO LBHKILDBCNO, Guid KJOKGMJIJOB)
	{
		return default(PEEBFJALEIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E105C0", Offset = "0x5E0F3C0", VA = "0x185E105C0")]
	public static int PIOPAKOGGIF(this AJCPDLIEOGO LBHKILDBCNO, PEEBFJALEIP FJKDCPDNMDF)
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

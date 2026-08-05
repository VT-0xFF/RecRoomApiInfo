using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EPOIEMJMDPA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74F64A0", Offset = "0x74F50A0", VA = "0x1874F64A0")]
	public static KeepsakeTheme JIDHCLNHDBO(this DCLHAILMONJ JHBOJJACLJB, Guid LEOGHFCHCNG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74F65A0", Offset = "0x74F51A0", VA = "0x1874F65A0")]
	public static KeepsakeTheme JIDHCLNHDBO(this DCLHAILMONJ JHBOJJACLJB, NIBHALALNCK AAJAJOCCJMO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74F6650", Offset = "0x74F5250", VA = "0x1874F6650")]
	public static List<KeepsakeTheme> KLLIGBJKBKG(this DCLHAILMONJ JHBOJJACLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74F6400", Offset = "0x74F5000", VA = "0x1874F6400")]
	public static NIBHALALNCK HHKBPOJFPMF(this DCLHAILMONJ JHBOJJACLJB, Guid LEOGHFCHCNG)
	{
		return default(NIBHALALNCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74F6370", Offset = "0x74F4F70", VA = "0x1874F6370")]
	public static int BOMNICLBDBE(this DCLHAILMONJ JHBOJJACLJB, NIBHALALNCK KAHENFKDGLP)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PBHNOHJABNE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FAD0", Offset = "0x7B4EED0", VA = "0x187B4FAD0")]
	public static KeepsakeTheme JBPJJCCDGNL(this MOHEIPBOAIA BIGODBDFGBM, Guid AKMEAMPGKCA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FBD0", Offset = "0x7B4EFD0", VA = "0x187B4FBD0")]
	public static KeepsakeTheme JBPJJCCDGNL(this MOHEIPBOAIA BIGODBDFGBM, KICOBCGECLF FLDMMNOKDMI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B4F970", Offset = "0x7B4ED70", VA = "0x187B4F970")]
	public static List<KeepsakeTheme> APPNNLADMOG(this MOHEIPBOAIA BIGODBDFGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FC80", Offset = "0x7B4F080", VA = "0x187B4FC80")]
	public static KICOBCGECLF KHFFJMHNJKD(this MOHEIPBOAIA BIGODBDFGBM, Guid AKMEAMPGKCA)
	{
		return default(KICOBCGECLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FA40", Offset = "0x7B4EE40", VA = "0x187B4FA40")]
	public static int GADJPMIIHCN(this MOHEIPBOAIA BIGODBDFGBM, KICOBCGECLF LGAIICCJHFP)
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

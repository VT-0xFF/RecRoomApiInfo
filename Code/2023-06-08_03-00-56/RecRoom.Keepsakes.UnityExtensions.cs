using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DLHPIGPEIKF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x193C7A0", Offset = "0x193B5A0", VA = "0x18193C7A0")]
	public static KeepsakeTheme AOBCKBKOJCM(this BKMMAEGBDIF PNDAGJIDNCN, Guid JAGFBLADBKH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x193C8A0", Offset = "0x193B6A0", VA = "0x18193C8A0")]
	public static KeepsakeTheme AOBCKBKOJCM(this BKMMAEGBDIF PNDAGJIDNCN, CJCGELBDEFP DOFHEOOBLPL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x193CA30", Offset = "0x193B830", VA = "0x18193CA30")]
	public static List<KeepsakeTheme> IONCGEAODPO(this BKMMAEGBDIF PNDAGJIDNCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x193CAE0", Offset = "0x193B8E0", VA = "0x18193CAE0")]
	public static CJCGELBDEFP OKJIFNLNNDF(this BKMMAEGBDIF PNDAGJIDNCN, Guid JAGFBLADBKH)
	{
		return default(CJCGELBDEFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x193C9B0", Offset = "0x193B7B0", VA = "0x18193C9B0")]
	public static int ECHMHLNGOJH(this BKMMAEGBDIF PNDAGJIDNCN, CJCGELBDEFP OBLILFIPCML)
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

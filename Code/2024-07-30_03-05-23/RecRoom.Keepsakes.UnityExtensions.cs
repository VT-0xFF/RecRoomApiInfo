using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IJFHPOHJIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F8D0", Offset = "0x6A3DED0", VA = "0x186A3F8D0")]
	public static KeepsakeTheme CGNHKNDLKBL(this OMPDHGEOOIM FECFMDJKBKG, Guid GONKBJGDKNO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F830", Offset = "0x6A3DE30", VA = "0x186A3F830")]
	public static KeepsakeTheme CGNHKNDLKBL(this OMPDHGEOOIM FECFMDJKBKG, CBGIMLDOAMC DKCMGPKABHP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FAD0", Offset = "0x6A3E0D0", VA = "0x186A3FAD0")]
	public static List<KeepsakeTheme> OBFAMGKMJJM(this OMPDHGEOOIM FECFMDJKBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F9C0", Offset = "0x6A3DFC0", VA = "0x186A3F9C0")]
	public static CBGIMLDOAMC NJPBJAHPHIO(this OMPDHGEOOIM FECFMDJKBKG, Guid GONKBJGDKNO)
	{
		return default(CBGIMLDOAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FA50", Offset = "0x6A3E050", VA = "0x186A3FA50")]
	public static int NOECHKMOHNK(this OMPDHGEOOIM FECFMDJKBKG, CBGIMLDOAMC INMPAEBBELA)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ABJBNOMPLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6434460", Offset = "0x6433660", VA = "0x186434460")]
	public static KeepsakeTheme IMGHJAMPLOC(this MGOECACFHAI LJOFMHFOMJI, Guid ONKALMANOMD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6434550", Offset = "0x6433750", VA = "0x186434550")]
	public static KeepsakeTheme IMGHJAMPLOC(this MGOECACFHAI LJOFMHFOMJI, HMDPKHAHMIL LMDCONBEFJA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6434600", Offset = "0x6433800", VA = "0x186434600")]
	public static List<KeepsakeTheme> IOPBGAIODOB(this MGOECACFHAI LJOFMHFOMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64343D0", Offset = "0x64335D0", VA = "0x1864343D0")]
	public static HMDPKHAHMIL EJEBELJDLGO(this MGOECACFHAI LJOFMHFOMJI, Guid ONKALMANOMD)
	{
		return default(HMDPKHAHMIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64346C0", Offset = "0x64338C0", VA = "0x1864346C0")]
	public static int LFAMGMNGNCN(this MGOECACFHAI LJOFMHFOMJI, HMDPKHAHMIL ODFNPJJNHGP)
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

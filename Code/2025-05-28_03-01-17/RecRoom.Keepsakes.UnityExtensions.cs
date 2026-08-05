using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AJMGBKIICAF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2330", Offset = "0x7DF1130", VA = "0x187DF2330")]
	public static KeepsakeTheme HELPBNIMHPF(this CGBFJHHLEPI HBNPNMJNNHB, Guid IKDHIALBBON)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2430", Offset = "0x7DF1230", VA = "0x187DF2430")]
	public static KeepsakeTheme HELPBNIMHPF(this CGBFJHHLEPI HBNPNMJNNHB, IDPKHHDKFDH FJMABOKHCMJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2570", Offset = "0x7DF1370", VA = "0x187DF2570")]
	public static List<KeepsakeTheme> IGDDFDCDECN(this CGBFJHHLEPI HBNPNMJNNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2640", Offset = "0x7DF1440", VA = "0x187DF2640")]
	public static IDPKHHDKFDH LMHGFMOGJFL(this CGBFJHHLEPI HBNPNMJNNHB, Guid IKDHIALBBON)
	{
		return default(IDPKHHDKFDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DF24E0", Offset = "0x7DF12E0", VA = "0x187DF24E0")]
	public static int IBMNAKENHDI(this CGBFJHHLEPI HBNPNMJNNHB, IDPKHHDKFDH MENJAAJDEPJ)
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

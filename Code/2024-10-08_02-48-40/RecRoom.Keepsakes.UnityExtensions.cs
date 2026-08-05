using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KFICELPLBDM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD310", Offset = "0x6CAC510", VA = "0x186CAD310")]
	public static KeepsakeTheme EJJDIPCBDHN(this ONIHNJBGLHK CAKLHAFGFAN, Guid PGHMPIEDMEN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD250", Offset = "0x6CAC450", VA = "0x186CAD250")]
	public static KeepsakeTheme EJJDIPCBDHN(this ONIHNJBGLHK CAKLHAFGFAN, MHCJLGGOLOL IAOCAGNLCGA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD050", Offset = "0x6CAC250", VA = "0x186CAD050")]
	public static List<KeepsakeTheme> AAJKADLKICC(this ONIHNJBGLHK CAKLHAFGFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD1B0", Offset = "0x6CAC3B0", VA = "0x186CAD1B0")]
	public static MHCJLGGOLOL EDJGABAIIKP(this ONIHNJBGLHK CAKLHAFGFAN, Guid PGHMPIEDMEN)
	{
		return default(MHCJLGGOLOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD120", Offset = "0x6CAC320", VA = "0x186CAD120")]
	public static int BPFDMDJEBHF(this ONIHNJBGLHK CAKLHAFGFAN, MHCJLGGOLOL KLEDGAFGMCL)
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

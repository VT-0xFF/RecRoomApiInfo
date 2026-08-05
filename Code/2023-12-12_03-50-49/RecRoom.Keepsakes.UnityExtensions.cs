using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HGHKGIMKCGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E33910", Offset = "0x5E32110", VA = "0x185E33910")]
	public static KeepsakeTheme LBEKGHCCDHC(this NGKNKPGIFHJ CLDKLPDMMOI, Guid DCEEIMKHNGB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E33A00", Offset = "0x5E32200", VA = "0x185E33A00")]
	public static KeepsakeTheme LBEKGHCCDHC(this NGKNKPGIFHJ CLDKLPDMMOI, KDELBGGBBMK DCPLCFEFNMN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E33850", Offset = "0x5E32050", VA = "0x185E33850")]
	public static List<KeepsakeTheme> ICDCOFHDNIJ(this NGKNKPGIFHJ CLDKLPDMMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E337C0", Offset = "0x5E31FC0", VA = "0x185E337C0")]
	public static KDELBGGBBMK FIHLHIFNBDM(this NGKNKPGIFHJ CLDKLPDMMOI, Guid DCEEIMKHNGB)
	{
		return default(KDELBGGBBMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E33AB0", Offset = "0x5E322B0", VA = "0x185E33AB0")]
	public static int PJEGGMBMDOH(this NGKNKPGIFHJ CLDKLPDMMOI, KDELBGGBBMK CIGBGDCPOFI)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JNFFFOANHNB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6810B50", Offset = "0x680FD50", VA = "0x186810B50")]
	public static KeepsakeTheme PLEMIPEPCOP(this PNPHOOBLIIO ACDHNMANGFE, Guid OPOMJNNALCB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6810C40", Offset = "0x680FE40", VA = "0x186810C40")]
	public static KeepsakeTheme PLEMIPEPCOP(this PNPHOOBLIIO ACDHNMANGFE, BLIIKHLKHJA JNJJAGBFLFH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6810A20", Offset = "0x680FC20", VA = "0x186810A20")]
	public static List<KeepsakeTheme> FOBNNADNICC(this PNPHOOBLIIO ACDHNMANGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6810990", Offset = "0x680FB90", VA = "0x186810990")]
	public static BLIIKHLKHJA CJFLFLJLCNF(this PNPHOOBLIIO ACDHNMANGFE, Guid OPOMJNNALCB)
	{
		return default(BLIIKHLKHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6810AD0", Offset = "0x680FCD0", VA = "0x186810AD0")]
	public static int GDNMCOAKBNH(this PNPHOOBLIIO ACDHNMANGFE, BLIIKHLKHJA OHMIKIIHJHM)
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

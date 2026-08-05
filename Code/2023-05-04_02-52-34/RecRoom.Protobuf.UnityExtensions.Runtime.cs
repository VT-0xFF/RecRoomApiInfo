using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class APEJINGBNLK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A42C20", Offset = "0x6A42020", VA = "0x186A42C20")]
	public static OILFAMMNBJM HLHCEBOKDMG(this in Color INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A42CA0", Offset = "0x6A420A0", VA = "0x186A42CA0")]
	public static Color JDGCKOHAIDJ(this OILFAMMNBJM INHKNJBCCPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A42D00", Offset = "0x6A42100", VA = "0x186A42D00")]
	public static Color? JJNEIHLFGOO(this OILFAMMNBJM INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PBDIBABOIMP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A431C0", Offset = "0x6A425C0", VA = "0x186A431C0")]
	public static Quaternion NPAMDMDLBAH(LKDBDJAKKHC HIDEHJGLNHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A430B0", Offset = "0x6A424B0", VA = "0x186A430B0")]
	public static NCJDAJDANII CEKMCLGGALI(Quaternion KMFDPHJEDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A43150", Offset = "0x6A42550", VA = "0x186A43150")]
	public static Quaternion EEFACGACOLC(NCJDAJDANII HIDEHJGLNHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DDNNGOJBGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A42DC0", Offset = "0x6A421C0", VA = "0x186A42DC0")]
	public static HEBKOAEJDJG HLHCEBOKDMG(this in Quaternion INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A42E40", Offset = "0x6A42240", VA = "0x186A42E40")]
	public static Quaternion JDGCKOHAIDJ(this HEBKOAEJDJG INHKNJBCCPD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A42EA0", Offset = "0x6A422A0", VA = "0x186A42EA0")]
	public static Quaternion? JJNEIHLFGOO(this HEBKOAEJDJG INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DIJEGCIAKLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A42F60", Offset = "0x6A42360", VA = "0x186A42F60")]
	public static NCJDAJDANII HLHCEBOKDMG(this in Vector3 INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A42FD0", Offset = "0x6A423D0", VA = "0x186A42FD0")]
	public static Vector3 JDGCKOHAIDJ(this NCJDAJDANII INHKNJBCCPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A43020", Offset = "0x6A42420", VA = "0x186A43020")]
	public static Vector3? JJNEIHLFGOO(this NCJDAJDANII INHKNJBCCPD)
	{
		return null;
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

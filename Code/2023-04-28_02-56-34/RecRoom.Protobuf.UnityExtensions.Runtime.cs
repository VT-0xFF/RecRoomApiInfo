using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class APEJINGBNLK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BDB0", Offset = "0x6A1A7B0", VA = "0x186A1BDB0")]
	public static OILFAMMNBJM HLHCEBOKDMG(this in Color INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BE30", Offset = "0x6A1A830", VA = "0x186A1BE30")]
	public static Color JDGCKOHAIDJ(this OILFAMMNBJM INHKNJBCCPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BE90", Offset = "0x6A1A890", VA = "0x186A1BE90")]
	public static Color? JJNEIHLFGOO(this OILFAMMNBJM INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PBDIBABOIMP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C350", Offset = "0x6A1AD50", VA = "0x186A1C350")]
	public static Quaternion NPAMDMDLBAH(LKDBDJAKKHC HIDEHJGLNHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C240", Offset = "0x6A1AC40", VA = "0x186A1C240")]
	public static NCJDAJDANII CEKMCLGGALI(Quaternion KMFDPHJEDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C2E0", Offset = "0x6A1ACE0", VA = "0x186A1C2E0")]
	public static Quaternion EEFACGACOLC(NCJDAJDANII HIDEHJGLNHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DDNNGOJBGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BF50", Offset = "0x6A1A950", VA = "0x186A1BF50")]
	public static HEBKOAEJDJG HLHCEBOKDMG(this in Quaternion INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BFD0", Offset = "0x6A1A9D0", VA = "0x186A1BFD0")]
	public static Quaternion JDGCKOHAIDJ(this HEBKOAEJDJG INHKNJBCCPD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C030", Offset = "0x6A1AA30", VA = "0x186A1C030")]
	public static Quaternion? JJNEIHLFGOO(this HEBKOAEJDJG INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DIJEGCIAKLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C0F0", Offset = "0x6A1AAF0", VA = "0x186A1C0F0")]
	public static NCJDAJDANII HLHCEBOKDMG(this in Vector3 INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C160", Offset = "0x6A1AB60", VA = "0x186A1C160")]
	public static Vector3 JDGCKOHAIDJ(this NCJDAJDANII INHKNJBCCPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C1B0", Offset = "0x6A1ABB0", VA = "0x186A1C1B0")]
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

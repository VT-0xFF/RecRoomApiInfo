using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CHKMEBDADGA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D30E70", Offset = "0x7D30070", VA = "0x187D30E70")]
	public static IHHDGIIMFMG JEAAONFOJJH([In] this Color NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D30DC0", Offset = "0x7D2FFC0", VA = "0x187D30DC0")]
	public static Color ANADGBKPLNB(this IHHDGIIMFMG NAELBAPCKEH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D30DF0", Offset = "0x7D2FFF0", VA = "0x187D30DF0")]
	public static Color? DGHDDEIICIO(this IHHDGIIMFMG NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OLIONDPGOOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D31210", Offset = "0x7D30410", VA = "0x187D31210")]
	public static Quaternion NAKCAFCJHDM(OIJFAMPJOKH LJELDKAOCJM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D31120", Offset = "0x7D30320", VA = "0x187D31120")]
	public static FEAOMDPGIAD JMGKHPLDKLA(Quaternion HIKEKHKKGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D31080", Offset = "0x7D30280", VA = "0x187D31080")]
	public static Quaternion CLKPFMNOBCA(FEAOMDPGIAD LJELDKAOCJM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GOJNNAFFCBC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D31000", Offset = "0x7D30200", VA = "0x187D31000")]
	public static OFLJDICJBJK JEAAONFOJJH([In] this Quaternion NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D30EF0", Offset = "0x7D300F0", VA = "0x187D30EF0")]
	public static Quaternion ANADGBKPLNB(this OFLJDICJBJK NAELBAPCKEH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D30F60", Offset = "0x7D30160", VA = "0x187D30F60")]
	public static Quaternion? DGHDDEIICIO(this OFLJDICJBJK NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PKMODEOGMLD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D31480", Offset = "0x7D30680", VA = "0x187D31480")]
	public static BDLIJJPGICH JEAAONFOJJH([In] this Vector2 NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D31420", Offset = "0x7D30620", VA = "0x187D31420")]
	public static Vector2 ANADGBKPLNB(this BDLIJJPGICH NAELBAPCKEH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AMMMKBCJAJC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D30D50", Offset = "0x7D2FF50", VA = "0x187D30D50")]
	public static FEAOMDPGIAD JEAAONFOJJH([In] this Vector3 NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D30C90", Offset = "0x7D2FE90", VA = "0x187D30C90")]
	public static FEAOMDPGIAD FGPKCKONPNL([In] this Vector3? NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D30B90", Offset = "0x7D2FD90", VA = "0x187D30B90")]
	public static Vector3 ANADGBKPLNB(this FEAOMDPGIAD NAELBAPCKEH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D30C00", Offset = "0x7D2FE00", VA = "0x187D30C00")]
	public static Vector3? DGHDDEIICIO(this FEAOMDPGIAD NAELBAPCKEH)
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

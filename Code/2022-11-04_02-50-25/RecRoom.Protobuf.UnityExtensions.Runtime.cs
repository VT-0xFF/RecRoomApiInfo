using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GDCIFKPJONL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x600C5F0", Offset = "0x600B9F0", VA = "0x18600C5F0")]
	public static OMKOFNCFKFL CAOILNKOGOI(this in Color DMBAJFNFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x600C670", Offset = "0x600BA70", VA = "0x18600C670")]
	public static Color DBBEJMFMHKH(this OMKOFNCFKFL DMBAJFNFPGC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x600C6D0", Offset = "0x600BAD0", VA = "0x18600C6D0")]
	public static Color? FIOPLMDKMLE(this OMKOFNCFKFL DMBAJFNFPGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GNGANNAHDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x600C790", Offset = "0x600BB90", VA = "0x18600C790")]
	public static Quaternion ABIDIKPKLOL(KILLDODGHDO HANEMGLFJMM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x600C920", Offset = "0x600BD20", VA = "0x18600C920")]
	public static NJEKNBIECNJ KHEAENAKLAH(Quaternion JCCFLIFBPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x600C9C0", Offset = "0x600BDC0", VA = "0x18600C9C0")]
	public static Quaternion OBKCONBPGPI(NJEKNBIECNJ HANEMGLFJMM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NDFHJJHLDPP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x600CC40", Offset = "0x600C040", VA = "0x18600CC40")]
	public static JNBNLMDJECL CAOILNKOGOI(this in Quaternion DMBAJFNFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x600CDE0", Offset = "0x600C1E0", VA = "0x18600CDE0")]
	public static JNBNLMDJECL OMAAKPJBPKH(this in Quaternion? DMBAJFNFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x600CCC0", Offset = "0x600C0C0", VA = "0x18600CCC0")]
	public static Quaternion DBBEJMFMHKH(this JNBNLMDJECL DMBAJFNFPGC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x600CD20", Offset = "0x600C120", VA = "0x18600CD20")]
	public static Quaternion? FIOPLMDKMLE(this JNBNLMDJECL DMBAJFNFPGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KPDEJGENAGM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x600CA30", Offset = "0x600BE30", VA = "0x18600CA30")]
	public static NJEKNBIECNJ CAOILNKOGOI(this in Vector3 DMBAJFNFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x600CB80", Offset = "0x600BF80", VA = "0x18600CB80")]
	public static NJEKNBIECNJ OMAAKPJBPKH(this in Vector3? DMBAJFNFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x600CAA0", Offset = "0x600BEA0", VA = "0x18600CAA0")]
	public static Vector3 DBBEJMFMHKH(this NJEKNBIECNJ DMBAJFNFPGC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x600CAF0", Offset = "0x600BEF0", VA = "0x18600CAF0")]
	public static Vector3? FIOPLMDKMLE(this NJEKNBIECNJ DMBAJFNFPGC)
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

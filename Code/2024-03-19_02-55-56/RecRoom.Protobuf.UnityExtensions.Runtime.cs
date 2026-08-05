using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AGLICGDACOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67181C0", Offset = "0x67171C0", VA = "0x1867181C0")]
	public static CCDIMLPIEFE PAKOMNGHIKD([In] this Color AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6718190", Offset = "0x6717190", VA = "0x186718190")]
	public static Color MPIEPNPHGIA(this CCDIMLPIEFE AOFEPADBPDL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6718240", Offset = "0x6717240", VA = "0x186718240")]
	public static Color? PGPCKMOJADL(this CCDIMLPIEFE AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JOOHHKIIDAB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6718500", Offset = "0x6717500", VA = "0x186718500")]
	public static Quaternion HJDLIFFLGHH(HBEEOLAAOLD ELANMAGHLLI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6718720", Offset = "0x6717720", VA = "0x186718720")]
	public static IFNBMGFOGHC KJDKNENJNNO(Quaternion EGKMBNJNKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6718810", Offset = "0x6717810", VA = "0x186718810")]
	public static Quaternion MLPHDBCCOCI(IFNBMGFOGHC ELANMAGHLLI)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PDPNHDIHEMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6718920", Offset = "0x6717920", VA = "0x186718920")]
	public static LIIJFBEJDNN PAKOMNGHIKD([In] this Quaternion AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67188B0", Offset = "0x67178B0", VA = "0x1867188B0")]
	public static Quaternion MPIEPNPHGIA(this LIIJFBEJDNN AOFEPADBPDL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67189A0", Offset = "0x67179A0", VA = "0x1867189A0")]
	public static Quaternion? PGPCKMOJADL(this LIIJFBEJDNN AOFEPADBPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGMICNEMAPL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6718490", Offset = "0x6717490", VA = "0x186718490")]
	public static PNHJNKBAPEH PAKOMNGHIKD([In] this Vector2 AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6718430", Offset = "0x6717430", VA = "0x186718430")]
	public static Vector2 MPIEPNPHGIA(this PNHJNKBAPEH AOFEPADBPDL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IEHHEOLAKAE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6718330", Offset = "0x6717330", VA = "0x186718330")]
	public static IFNBMGFOGHC PAKOMNGHIKD([In] this Vector3 AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67182C0", Offset = "0x67172C0", VA = "0x1867182C0")]
	public static Vector3 MPIEPNPHGIA(this IFNBMGFOGHC AOFEPADBPDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67183A0", Offset = "0x67173A0", VA = "0x1867183A0")]
	public static Vector3? PGPCKMOJADL(this IFNBMGFOGHC AOFEPADBPDL)
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

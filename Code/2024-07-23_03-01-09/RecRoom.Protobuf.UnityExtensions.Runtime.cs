using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EFCEAOGKNPI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B7A0", Offset = "0x6F3A9A0", VA = "0x186F3B7A0")]
	public static FCLMOJJNFOE OPCGAJMHMBL([In] this Color HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B770", Offset = "0x6F3A970", VA = "0x186F3B770")]
	public static Color DGBBAPGEGII(this FCLMOJJNFOE HIKEOGPAJAF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B6F0", Offset = "0x6F3A8F0", VA = "0x186F3B6F0")]
	public static Color? CEMMLNGONHG(this FCLMOJJNFOE HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NELIJENJNAP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BB70", Offset = "0x6F3AD70", VA = "0x186F3BB70")]
	public static Quaternion EOLPNPBPJME(LBLCMJLNDPD LINJEFIAFHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BA80", Offset = "0x6F3AC80", VA = "0x186F3BA80")]
	public static GHNKAEIALIE EAMGMDNKIDC(Quaternion JFJFBMJOGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BD90", Offset = "0x6F3AF90", VA = "0x186F3BD90")]
	public static Quaternion JLOLNCEPBEH(GHNKAEIALIE LINJEFIAFHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IBCAPBHEKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B930", Offset = "0x6F3AB30", VA = "0x186F3B930")]
	public static LOKANIAFGFC OPCGAJMHMBL([In] this Quaternion HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B8C0", Offset = "0x6F3AAC0", VA = "0x186F3B8C0")]
	public static Quaternion DGBBAPGEGII(this LOKANIAFGFC HIKEOGPAJAF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B820", Offset = "0x6F3AA20", VA = "0x186F3B820")]
	public static Quaternion? CEMMLNGONHG(this LOKANIAFGFC HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNLLNLNFAMM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BA10", Offset = "0x6F3AC10", VA = "0x186F3BA10")]
	public static ALDMNNMFKDH OPCGAJMHMBL([In] this Vector2 HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B9B0", Offset = "0x6F3ABB0", VA = "0x186F3B9B0")]
	public static Vector2 DGBBAPGEGII(this ALDMNNMFKDH HIKEOGPAJAF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OFKNEPOGEHO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BF30", Offset = "0x6F3B130", VA = "0x186F3BF30")]
	public static GHNKAEIALIE OPCGAJMHMBL([In] this Vector3 HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BEC0", Offset = "0x6F3B0C0", VA = "0x186F3BEC0")]
	public static Vector3 DGBBAPGEGII(this GHNKAEIALIE HIKEOGPAJAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BE30", Offset = "0x6F3B030", VA = "0x186F3BE30")]
	public static Vector3? CEMMLNGONHG(this GHNKAEIALIE HIKEOGPAJAF)
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

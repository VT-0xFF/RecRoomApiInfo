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
	[Cpp2IlInjected.Address(RVA = "0x6F1CBC0", Offset = "0x6F1B5C0", VA = "0x186F1CBC0")]
	public static FCLMOJJNFOE OPCGAJMHMBL([In] this Color HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CB90", Offset = "0x6F1B590", VA = "0x186F1CB90")]
	public static Color DGBBAPGEGII(this FCLMOJJNFOE HIKEOGPAJAF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CB10", Offset = "0x6F1B510", VA = "0x186F1CB10")]
	public static Color? CEMMLNGONHG(this FCLMOJJNFOE HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NELIJENJNAP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CF90", Offset = "0x6F1B990", VA = "0x186F1CF90")]
	public static Quaternion EOLPNPBPJME(LBLCMJLNDPD LINJEFIAFHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CEA0", Offset = "0x6F1B8A0", VA = "0x186F1CEA0")]
	public static GHNKAEIALIE EAMGMDNKIDC(Quaternion JFJFBMJOGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D1B0", Offset = "0x6F1BBB0", VA = "0x186F1D1B0")]
	public static Quaternion JLOLNCEPBEH(GHNKAEIALIE LINJEFIAFHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IBCAPBHEKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CD50", Offset = "0x6F1B750", VA = "0x186F1CD50")]
	public static LOKANIAFGFC OPCGAJMHMBL([In] this Quaternion HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CCE0", Offset = "0x6F1B6E0", VA = "0x186F1CCE0")]
	public static Quaternion DGBBAPGEGII(this LOKANIAFGFC HIKEOGPAJAF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CC40", Offset = "0x6F1B640", VA = "0x186F1CC40")]
	public static Quaternion? CEMMLNGONHG(this LOKANIAFGFC HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNLLNLNFAMM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CE30", Offset = "0x6F1B830", VA = "0x186F1CE30")]
	public static ALDMNNMFKDH OPCGAJMHMBL([In] this Vector2 HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CDD0", Offset = "0x6F1B7D0", VA = "0x186F1CDD0")]
	public static Vector2 DGBBAPGEGII(this ALDMNNMFKDH HIKEOGPAJAF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OFKNEPOGEHO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D350", Offset = "0x6F1BD50", VA = "0x186F1D350")]
	public static GHNKAEIALIE OPCGAJMHMBL([In] this Vector3 HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D2E0", Offset = "0x6F1BCE0", VA = "0x186F1D2E0")]
	public static Vector3 DGBBAPGEGII(this GHNKAEIALIE HIKEOGPAJAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D250", Offset = "0x6F1BC50", VA = "0x186F1D250")]
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

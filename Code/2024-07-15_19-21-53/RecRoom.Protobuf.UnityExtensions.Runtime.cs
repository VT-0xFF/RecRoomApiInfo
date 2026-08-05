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
	[Cpp2IlInjected.Address(RVA = "0x6F1CAC0", Offset = "0x6F1B2C0", VA = "0x186F1CAC0")]
	public static FCLMOJJNFOE OPCGAJMHMBL([In] this Color HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA90", Offset = "0x6F1B290", VA = "0x186F1CA90")]
	public static Color DGBBAPGEGII(this FCLMOJJNFOE HIKEOGPAJAF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA10", Offset = "0x6F1B210", VA = "0x186F1CA10")]
	public static Color? CEMMLNGONHG(this FCLMOJJNFOE HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NELIJENJNAP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CE90", Offset = "0x6F1B690", VA = "0x186F1CE90")]
	public static Quaternion EOLPNPBPJME(LBLCMJLNDPD LINJEFIAFHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CDA0", Offset = "0x6F1B5A0", VA = "0x186F1CDA0")]
	public static GHNKAEIALIE EAMGMDNKIDC(Quaternion JFJFBMJOGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D0B0", Offset = "0x6F1B8B0", VA = "0x186F1D0B0")]
	public static Quaternion JLOLNCEPBEH(GHNKAEIALIE LINJEFIAFHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IBCAPBHEKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CC50", Offset = "0x6F1B450", VA = "0x186F1CC50")]
	public static LOKANIAFGFC OPCGAJMHMBL([In] this Quaternion HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CBE0", Offset = "0x6F1B3E0", VA = "0x186F1CBE0")]
	public static Quaternion DGBBAPGEGII(this LOKANIAFGFC HIKEOGPAJAF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CB40", Offset = "0x6F1B340", VA = "0x186F1CB40")]
	public static Quaternion? CEMMLNGONHG(this LOKANIAFGFC HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNLLNLNFAMM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CD30", Offset = "0x6F1B530", VA = "0x186F1CD30")]
	public static ALDMNNMFKDH OPCGAJMHMBL([In] this Vector2 HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CCD0", Offset = "0x6F1B4D0", VA = "0x186F1CCD0")]
	public static Vector2 DGBBAPGEGII(this ALDMNNMFKDH HIKEOGPAJAF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OFKNEPOGEHO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D250", Offset = "0x6F1BA50", VA = "0x186F1D250")]
	public static GHNKAEIALIE OPCGAJMHMBL([In] this Vector3 HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D1E0", Offset = "0x6F1B9E0", VA = "0x186F1D1E0")]
	public static Vector3 DGBBAPGEGII(this GHNKAEIALIE HIKEOGPAJAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D150", Offset = "0x6F1B950", VA = "0x186F1D150")]
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

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AFIIODFLFOI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7459B60", Offset = "0x7458F60", VA = "0x187459B60")]
	public static LGMPLHMJNLL KEEAKGCJIOB([In] this Color MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7459B30", Offset = "0x7458F30", VA = "0x187459B30")]
	public static Color GEBAPMNFHGF(this LGMPLHMJNLL MBGHIKEGJAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7459BE0", Offset = "0x7458FE0", VA = "0x187459BE0")]
	public static Color? MNJLECJLNPP(this LGMPLHMJNLL MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PGFACPBNAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x745A0F0", Offset = "0x74594F0", VA = "0x18745A0F0")]
	public static Quaternion AABICCHFIPB(OMOLGNEMBFE MPMEGOKIEPF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x745A300", Offset = "0x7459700", VA = "0x18745A300")]
	public static MIEAMCACODE ENIOGCECMFB(Quaternion CBGCFAPHFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x745A3F0", Offset = "0x74597F0", VA = "0x18745A3F0")]
	public static Quaternion IICIPEIBLAF(MIEAMCACODE MPMEGOKIEPF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OFONGHLOCFO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7459FD0", Offset = "0x74593D0", VA = "0x187459FD0")]
	public static PLANNOENCOF KEEAKGCJIOB([In] this Quaternion MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7459F60", Offset = "0x7459360", VA = "0x187459F60")]
	public static Quaternion GEBAPMNFHGF(this PLANNOENCOF MBGHIKEGJAA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x745A050", Offset = "0x7459450", VA = "0x18745A050")]
	public static Quaternion? MNJLECJLNPP(this PLANNOENCOF MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EIKLGMKLNCE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7459EF0", Offset = "0x74592F0", VA = "0x187459EF0")]
	public static GANGNMIPFJN KEEAKGCJIOB([In] this Vector2 MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7459E90", Offset = "0x7459290", VA = "0x187459E90")]
	public static Vector2 GEBAPMNFHGF(this GANGNMIPFJN MBGHIKEGJAA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BMEPDKDBNDJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7459D90", Offset = "0x7459190", VA = "0x187459D90")]
	public static MIEAMCACODE KEEAKGCJIOB([In] this Vector3 MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7459CD0", Offset = "0x74590D0", VA = "0x187459CD0")]
	public static MIEAMCACODE JEPNPLJNMNK([In] this Vector3? MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7459C60", Offset = "0x7459060", VA = "0x187459C60")]
	public static Vector3 GEBAPMNFHGF(this MIEAMCACODE MBGHIKEGJAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7459E00", Offset = "0x7459200", VA = "0x187459E00")]
	public static Vector3? MNJLECJLNPP(this MIEAMCACODE MBGHIKEGJAA)
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

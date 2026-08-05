using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DCPGJIJPCBG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x638FC70", Offset = "0x638E870", VA = "0x18638FC70")]
	public static BHALJHNIHON OIIEHDKDHEB([In] this Color HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x638FC40", Offset = "0x638E840", VA = "0x18638FC40")]
	public static Color JFKFFNFOIMD(this BHALJHNIHON HHHLENOMLMP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x638FBC0", Offset = "0x638E7C0", VA = "0x18638FBC0")]
	public static Color? IEELEGEMBJH(this BHALJHNIHON HHHLENOMLMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ONKDLMHPKDI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63900C0", Offset = "0x638ECC0", VA = "0x1863900C0")]
	public static Quaternion FKGILGHEACL(DFKCHGBLCJE IGJLGPELHOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63902E0", Offset = "0x638EEE0", VA = "0x1863902E0")]
	public static CKGDEDLLLMM IFAKDCALOCK(Quaternion HAOINCLECDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63903D0", Offset = "0x638EFD0", VA = "0x1863903D0")]
	public static Quaternion JJOIOHMPIHB(CKGDEDLLLMM IGJLGPELHOJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GLKENAELDPO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638FE00", Offset = "0x638EA00", VA = "0x18638FE00")]
	public static JBJBNOFMAFL OIIEHDKDHEB([In] this Quaternion HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638FD90", Offset = "0x638E990", VA = "0x18638FD90")]
	public static Quaternion JFKFFNFOIMD(this JBJBNOFMAFL HHHLENOMLMP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638FCF0", Offset = "0x638E8F0", VA = "0x18638FCF0")]
	public static Quaternion? IEELEGEMBJH(this JBJBNOFMAFL HHHLENOMLMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JJCJMCLLNJJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6390050", Offset = "0x638EC50", VA = "0x186390050")]
	public static DLOGPLAOPNP OIIEHDKDHEB([In] this Vector2 HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x638FFF0", Offset = "0x638EBF0", VA = "0x18638FFF0")]
	public static Vector2 JFKFFNFOIMD(this DLOGPLAOPNP HHHLENOMLMP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HHLECJJHIHJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x638FF80", Offset = "0x638EB80", VA = "0x18638FF80")]
	public static CKGDEDLLLMM OIIEHDKDHEB([In] this Vector3 HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x638FF10", Offset = "0x638EB10", VA = "0x18638FF10")]
	public static Vector3 JFKFFNFOIMD(this CKGDEDLLLMM HHHLENOMLMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x638FE80", Offset = "0x638EA80", VA = "0x18638FE80")]
	public static Vector3? IEELEGEMBJH(this CKGDEDLLLMM HHHLENOMLMP)
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

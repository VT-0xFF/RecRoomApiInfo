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
	[Cpp2IlInjected.Address(RVA = "0x638FD00", Offset = "0x638E900", VA = "0x18638FD00")]
	public static BHALJHNIHON OIIEHDKDHEB([In] this Color HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x638FCD0", Offset = "0x638E8D0", VA = "0x18638FCD0")]
	public static Color JFKFFNFOIMD(this BHALJHNIHON HHHLENOMLMP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x638FC50", Offset = "0x638E850", VA = "0x18638FC50")]
	public static Color? IEELEGEMBJH(this BHALJHNIHON HHHLENOMLMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ONKDLMHPKDI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6390150", Offset = "0x638ED50", VA = "0x186390150")]
	public static Quaternion FKGILGHEACL(DFKCHGBLCJE IGJLGPELHOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6390370", Offset = "0x638EF70", VA = "0x186390370")]
	public static CKGDEDLLLMM IFAKDCALOCK(Quaternion HAOINCLECDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6390460", Offset = "0x638F060", VA = "0x186390460")]
	public static Quaternion JJOIOHMPIHB(CKGDEDLLLMM IGJLGPELHOJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GLKENAELDPO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638FE90", Offset = "0x638EA90", VA = "0x18638FE90")]
	public static JBJBNOFMAFL OIIEHDKDHEB([In] this Quaternion HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638FE20", Offset = "0x638EA20", VA = "0x18638FE20")]
	public static Quaternion JFKFFNFOIMD(this JBJBNOFMAFL HHHLENOMLMP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638FD80", Offset = "0x638E980", VA = "0x18638FD80")]
	public static Quaternion? IEELEGEMBJH(this JBJBNOFMAFL HHHLENOMLMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JJCJMCLLNJJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63900E0", Offset = "0x638ECE0", VA = "0x1863900E0")]
	public static DLOGPLAOPNP OIIEHDKDHEB([In] this Vector2 HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6390080", Offset = "0x638EC80", VA = "0x186390080")]
	public static Vector2 JFKFFNFOIMD(this DLOGPLAOPNP HHHLENOMLMP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HHLECJJHIHJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6390010", Offset = "0x638EC10", VA = "0x186390010")]
	public static CKGDEDLLLMM OIIEHDKDHEB([In] this Vector3 HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x638FFA0", Offset = "0x638EBA0", VA = "0x18638FFA0")]
	public static Vector3 JFKFFNFOIMD(this CKGDEDLLLMM HHHLENOMLMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x638FF10", Offset = "0x638EB10", VA = "0x18638FF10")]
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

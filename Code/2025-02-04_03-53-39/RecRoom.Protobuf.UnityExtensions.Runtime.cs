using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IPNNKFEHFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x795E140", Offset = "0x795CF40", VA = "0x18795E140")]
	public static OPFJGEEMIOJ NPIKEPIONAB([In] this Color DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x795E110", Offset = "0x795CF10", VA = "0x18795E110")]
	public static Color FEIAPADJKML(this OPFJGEEMIOJ DJAJDIFOIHP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x795E1C0", Offset = "0x795CFC0", VA = "0x18795E1C0")]
	public static Color? ODAAPEHDCIB(this OPFJGEEMIOJ DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFPACABHEDO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x795DF00", Offset = "0x795CD00", VA = "0x18795DF00")]
	public static Quaternion MCIHJAFCFFP(OBDDKEFAOIN JOAPLPPIFPC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x795DD70", Offset = "0x795CB70", VA = "0x18795DD70")]
	public static GOKNIDMECKI EIHLMPMBIBB(Quaternion OODPKLAFMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x795DE60", Offset = "0x795CC60", VA = "0x18795DE60")]
	public static Quaternion GODMEHHHIOA(GOKNIDMECKI JOAPLPPIFPC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JHKHOAHCJEF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x795E2B0", Offset = "0x795D0B0", VA = "0x18795E2B0")]
	public static DLGBFJGAHIO NPIKEPIONAB([In] this Quaternion DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x795E240", Offset = "0x795D040", VA = "0x18795E240")]
	public static Quaternion FEIAPADJKML(this DLGBFJGAHIO DJAJDIFOIHP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x795E330", Offset = "0x795D130", VA = "0x18795E330")]
	public static Quaternion? ODAAPEHDCIB(this DLGBFJGAHIO DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PMKFFCDOJEB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x795E660", Offset = "0x795D460", VA = "0x18795E660")]
	public static OAOMOJHCCHH NPIKEPIONAB([In] this Vector2 DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x795E600", Offset = "0x795D400", VA = "0x18795E600")]
	public static Vector2 FEIAPADJKML(this OAOMOJHCCHH DJAJDIFOIHP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MFPHBMCMFHA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x795E440", Offset = "0x795D240", VA = "0x18795E440")]
	public static GOKNIDMECKI NPIKEPIONAB([In] this Vector3 DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x795E540", Offset = "0x795D340", VA = "0x18795E540")]
	public static GOKNIDMECKI PLJHGHAFHMH([In] this Vector3? DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x795E3D0", Offset = "0x795D1D0", VA = "0x18795E3D0")]
	public static Vector3 FEIAPADJKML(this GOKNIDMECKI DJAJDIFOIHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x795E4B0", Offset = "0x795D2B0", VA = "0x18795E4B0")]
	public static Vector3? ODAAPEHDCIB(this GOKNIDMECKI DJAJDIFOIHP)
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

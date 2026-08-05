using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CPBFBHCMNKP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63685A0", Offset = "0x63673A0", VA = "0x1863685A0")]
	public static BHAPPHHMEIM OJBJHHLKILJ([In] this Color HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6368570", Offset = "0x6367370", VA = "0x186368570")]
	public static Color LKNPCKIALBL(this BHAPPHHMEIM HLCOOGAGOEK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63684F0", Offset = "0x63672F0", VA = "0x1863684F0")]
	public static Color? HAJPDDBALOF(this BHAPPHHMEIM HLCOOGAGOEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AKABHCFNMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6368230", Offset = "0x6367030", VA = "0x186368230")]
	public static Quaternion LKDMDDOMJOG(FDIKPEDFKFO KNAIEKIJLBC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6368140", Offset = "0x6366F40", VA = "0x186368140")]
	public static JDAJBGJADHP IJFNADODJOC(Quaternion CPDAKCGMDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6368450", Offset = "0x6367250", VA = "0x186368450")]
	public static Quaternion PDJHHPNMBFK(JDAJBGJADHP KNAIEKIJLBC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HNPDDKCPHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6368800", Offset = "0x6367600", VA = "0x186368800")]
	public static BIMEJPOEALH OJBJHHLKILJ([In] this Quaternion HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6368790", Offset = "0x6367590", VA = "0x186368790")]
	public static Quaternion LKNPCKIALBL(this BIMEJPOEALH HLCOOGAGOEK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63686F0", Offset = "0x63674F0", VA = "0x1863686F0")]
	public static Quaternion? HAJPDDBALOF(this BIMEJPOEALH HLCOOGAGOEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DHOEIPLJPIO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6368680", Offset = "0x6367480", VA = "0x186368680")]
	public static FFOHGPLLAAM OJBJHHLKILJ([In] this Vector2 HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6368620", Offset = "0x6367420", VA = "0x186368620")]
	public static Vector2 LKNPCKIALBL(this FFOHGPLLAAM HLCOOGAGOEK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NKONCJCGODI
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6368980", Offset = "0x6367780", VA = "0x186368980")]
	public static JDAJBGJADHP OJBJHHLKILJ([In] this Vector3 HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6368910", Offset = "0x6367710", VA = "0x186368910")]
	public static Vector3 LKNPCKIALBL(this JDAJBGJADHP HLCOOGAGOEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6368880", Offset = "0x6367680", VA = "0x186368880")]
	public static Vector3? HAJPDDBALOF(this JDAJBGJADHP HLCOOGAGOEK)
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

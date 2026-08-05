using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AEHEMGJNCLA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x662F140", Offset = "0x662DF40", VA = "0x18662F140")]
	public static FCCDICPOFMA CDDFPMJNNJO([In] this Color OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x662F110", Offset = "0x662DF10", VA = "0x18662F110")]
	public static Color APHAODHFANA(this FCCDICPOFMA OELHNDCFEMO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x662F1C0", Offset = "0x662DFC0", VA = "0x18662F1C0")]
	public static Color? GNPLABBPFLC(this FCCDICPOFMA OELHNDCFEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFGOKBOKAKP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x662F2E0", Offset = "0x662E0E0", VA = "0x18662F2E0")]
	public static Quaternion GHOCPGJJHKA(FBPKHDIPHIN EEDANCJJEPL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x662F500", Offset = "0x662E300", VA = "0x18662F500")]
	public static IHPGJMCLDKK OPBAHOPHGIJ(Quaternion HPBGKKDJMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x662F240", Offset = "0x662E040", VA = "0x18662F240")]
	public static Quaternion CPHDMBFEJJM(IHPGJMCLDKK EEDANCJJEPL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KMIFPNPDNJE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x662F660", Offset = "0x662E460", VA = "0x18662F660")]
	public static DMBFNDIOBEH CDDFPMJNNJO([In] this Quaternion OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x662F5F0", Offset = "0x662E3F0", VA = "0x18662F5F0")]
	public static Quaternion APHAODHFANA(this DMBFNDIOBEH OELHNDCFEMO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x662F6E0", Offset = "0x662E4E0", VA = "0x18662F6E0")]
	public static Quaternion? GNPLABBPFLC(this DMBFNDIOBEH OELHNDCFEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MJFODABDPBN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x662F950", Offset = "0x662E750", VA = "0x18662F950")]
	public static KFJPINCLHOA CDDFPMJNNJO([In] this Vector2 OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x662F8F0", Offset = "0x662E6F0", VA = "0x18662F8F0")]
	public static Vector2 APHAODHFANA(this KFJPINCLHOA OELHNDCFEMO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MHJCNILBFAC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x662F7F0", Offset = "0x662E5F0", VA = "0x18662F7F0")]
	public static IHPGJMCLDKK CDDFPMJNNJO([In] this Vector3 OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x662F780", Offset = "0x662E580", VA = "0x18662F780")]
	public static Vector3 APHAODHFANA(this IHPGJMCLDKK OELHNDCFEMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x662F860", Offset = "0x662E660", VA = "0x18662F860")]
	public static Vector3? GNPLABBPFLC(this IHPGJMCLDKK OELHNDCFEMO)
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

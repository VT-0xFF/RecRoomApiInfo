using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PIMFMIGNCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6130", Offset = "0x6FF4730", VA = "0x186FF6130")]
	public static JGAILJBPLBL HLDMGFBCHDH(this in Color CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FF62F0", Offset = "0x6FF48F0", VA = "0x186FF62F0")]
	public static Color LKBINHHANLF(this JGAILJBPLBL CDBMADFDGCE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FF61D0", Offset = "0x6FF47D0", VA = "0x186FF61D0")]
	public static Color? LEEMJMJBDBJ(this JGAILJBPLBL CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BEHKFBNGBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5B40", Offset = "0x6FF4140", VA = "0x186FF5B40")]
	public static PHFCFEDPGPF HLDMGFBCHDH(this in Quaternion CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5D00", Offset = "0x6FF4300", VA = "0x186FF5D00")]
	public static Quaternion LKBINHHANLF(this PHFCFEDPGPF CDBMADFDGCE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5BE0", Offset = "0x6FF41E0", VA = "0x186FF5BE0")]
	public static Quaternion? LEEMJMJBDBJ(this PHFCFEDPGPF CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGHGKAKHACB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5E80", Offset = "0x6FF4480", VA = "0x186FF5E80")]
	public static Quaternion KINJKOPLCON(DACGHEEGBGA JAIGDBINGHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5DD0", Offset = "0x6FF43D0", VA = "0x186FF5DD0")]
	public static OGIOJDJNKII FIGOLAKKKDF(Quaternion DCPLJCMINKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6090", Offset = "0x6FF4690", VA = "0x186FF6090")]
	public static Quaternion NOLAGOKOEOC(OGIOJDJNKII JAIGDBINGHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class APGCAOKGAKP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5950", Offset = "0x6FF3F50", VA = "0x186FF5950")]
	public static OGIOJDJNKII HLDMGFBCHDH(this in Vector3 CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5AA0", Offset = "0x6FF40A0", VA = "0x186FF5AA0")]
	public static Vector3 LKBINHHANLF(this OGIOJDJNKII CDBMADFDGCE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF59E0", Offset = "0x6FF3FE0", VA = "0x186FF59E0")]
	public static Vector3? LEEMJMJBDBJ(this OGIOJDJNKII CDBMADFDGCE)
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

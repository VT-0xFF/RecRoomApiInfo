using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GBBICIAGJDO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72C8CB0", Offset = "0x72C7CB0", VA = "0x1872C8CB0")]
	public static IEHKKLCOLGH BCEEACLIKPE(this in Color DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72C8D50", Offset = "0x72C7D50", VA = "0x1872C8D50")]
	public static Color BPADPDDPOEA(this IEHKKLCOLGH DPHICODLGJD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72C8E20", Offset = "0x72C7E20", VA = "0x1872C8E20")]
	public static Color? FPBPKFANCJJ(this IEHKKLCOLGH DPHICODLGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JAEBDMDLPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72C9130", Offset = "0x72C8130", VA = "0x1872C9130")]
	public static CFAIOEHCDHJ BCEEACLIKPE(this in Quaternion DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72C91D0", Offset = "0x72C81D0", VA = "0x1872C91D0")]
	public static Quaternion BPADPDDPOEA(this CFAIOEHCDHJ DPHICODLGJD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72C92A0", Offset = "0x72C82A0", VA = "0x1872C92A0")]
	public static Quaternion? FPBPKFANCJJ(this CFAIOEHCDHJ DPHICODLGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JJGGCODLCKN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72C9510", Offset = "0x72C8510", VA = "0x1872C9510")]
	public static Quaternion NECPFKMLEBF(GPIANAFEHPL HCKNMLENIIG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72C93C0", Offset = "0x72C83C0", VA = "0x1872C93C0")]
	public static KBOKMEOFLIN FANKDHPIDLM(Quaternion ICPBCBMOLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72C9470", Offset = "0x72C8470", VA = "0x1872C9470")]
	public static Quaternion JEKICHPNGLE(KBOKMEOFLIN HCKNMLENIIG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class INKDDIDJAMM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72C8F40", Offset = "0x72C7F40", VA = "0x1872C8F40")]
	public static KBOKMEOFLIN BCEEACLIKPE(this in Vector3 DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72C8FD0", Offset = "0x72C7FD0", VA = "0x1872C8FD0")]
	public static Vector3 BPADPDDPOEA(this KBOKMEOFLIN DPHICODLGJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72C9070", Offset = "0x72C8070", VA = "0x1872C9070")]
	public static Vector3? FPBPKFANCJJ(this KBOKMEOFLIN DPHICODLGJD)
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

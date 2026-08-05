using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MPFBJBGOACK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E827F0", Offset = "0x6E80FF0", VA = "0x186E827F0")]
	public static INJBPOHEHLM HNAIEAEAFJH([In] this Color EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E828F0", Offset = "0x6E810F0", VA = "0x186E828F0")]
	public static Color PKPMANIAHDL(this INJBPOHEHLM EGJINJKGIAK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E82870", Offset = "0x6E81070", VA = "0x186E82870")]
	public static Color? JLENAAGCGEI(this INJBPOHEHLM EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LGCOEHIPKMF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E82450", Offset = "0x6E80C50", VA = "0x186E82450")]
	public static Quaternion MGGLOFJCPIJ(AJEHEHAHMCJ MLKNGAFFKGE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E82700", Offset = "0x6E80F00", VA = "0x186E82700")]
	public static KHFCIDGMDLD OPMHEAMGNDE(Quaternion AOJABCDMJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E82660", Offset = "0x6E80E60", VA = "0x186E82660")]
	public static Quaternion OJLAIJHFCMD(KHFCIDGMDLD MLKNGAFFKGE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GJBOCNPHJDN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E82080", Offset = "0x6E80880", VA = "0x186E82080")]
	public static ELJNMNHGMLJ HNAIEAEAFJH([In] this Quaternion EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E821A0", Offset = "0x6E809A0", VA = "0x186E821A0")]
	public static Quaternion PKPMANIAHDL(this ELJNMNHGMLJ EGJINJKGIAK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E82100", Offset = "0x6E80900", VA = "0x186E82100")]
	public static Quaternion? JLENAAGCGEI(this ELJNMNHGMLJ EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KPAGNAEMKCA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E82380", Offset = "0x6E80B80", VA = "0x186E82380")]
	public static EBLJJILPMKK HNAIEAEAFJH([In] this Vector2 EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E823F0", Offset = "0x6E80BF0", VA = "0x186E823F0")]
	public static Vector2 PKPMANIAHDL(this EBLJJILPMKK EGJINJKGIAK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HDCHDKJKABJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E82210", Offset = "0x6E80A10", VA = "0x186E82210")]
	public static KHFCIDGMDLD HNAIEAEAFJH([In] this Vector3 EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E82310", Offset = "0x6E80B10", VA = "0x186E82310")]
	public static Vector3 PKPMANIAHDL(this KHFCIDGMDLD EGJINJKGIAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E82280", Offset = "0x6E80A80", VA = "0x186E82280")]
	public static Vector3? JLENAAGCGEI(this KHFCIDGMDLD EGJINJKGIAK)
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

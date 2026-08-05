using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AFFJHPLLNEF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A690", Offset = "0x6F39A90", VA = "0x186F3A690")]
	public static NIHAHBHGGKA KPIBKDOHBCB([In] this Color ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A660", Offset = "0x6F39A60", VA = "0x186F3A660")]
	public static Color JLCLGLEKPEG(this NIHAHBHGGKA ABPJKOBADEP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A5E0", Offset = "0x6F399E0", VA = "0x186F3A5E0")]
	public static Color? GLKGNIFDMEG(this NIHAHBHGGKA ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BAKDIFEONJF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A800", Offset = "0x6F39C00", VA = "0x186F3A800")]
	public static Quaternion LINGFOODKLO(AKAIBECCKOE LDNEPNAGEGN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A710", Offset = "0x6F39B10", VA = "0x186F3A710")]
	public static LLHMGLFFDLF HFOCMJEFAHC(Quaternion CJDGIBJGBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AA20", Offset = "0x6F39E20", VA = "0x186F3AA20")]
	public static Quaternion NPDMODIHNIA(LLHMGLFFDLF LDNEPNAGEGN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HKELNADIBJN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AE10", Offset = "0x6F3A210", VA = "0x186F3AE10")]
	public static AGAOIMGBAFB KPIBKDOHBCB([In] this Quaternion ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ADA0", Offset = "0x6F3A1A0", VA = "0x186F3ADA0")]
	public static Quaternion JLCLGLEKPEG(this AGAOIMGBAFB ABPJKOBADEP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AD00", Offset = "0x6F3A100", VA = "0x186F3AD00")]
	public static Quaternion? GLKGNIFDMEG(this AGAOIMGBAFB ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FHPOCNJBOKF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AC90", Offset = "0x6F3A090", VA = "0x186F3AC90")]
	public static HGOIMPODJNM KPIBKDOHBCB([In] this Vector2 ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AC30", Offset = "0x6F3A030", VA = "0x186F3AC30")]
	public static Vector2 JLCLGLEKPEG(this HGOIMPODJNM ABPJKOBADEP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EEGDBGDJGCM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ABC0", Offset = "0x6F39FC0", VA = "0x186F3ABC0")]
	public static LLHMGLFFDLF KPIBKDOHBCB([In] this Vector3 ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AB50", Offset = "0x6F39F50", VA = "0x186F3AB50")]
	public static Vector3 JLCLGLEKPEG(this LLHMGLFFDLF ABPJKOBADEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AAC0", Offset = "0x6F39EC0", VA = "0x186F3AAC0")]
	public static Vector3? GLKGNIFDMEG(this LLHMGLFFDLF ABPJKOBADEP)
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
